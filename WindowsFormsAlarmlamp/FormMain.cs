using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Modbus.Device;
using WinAlarmApp.Models;
using WindowsFormsAlarmlamp.UControler;

namespace WindowsFormsAlarmlamp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        IModbusMaster master = null;//主站设备
         SerialPort  serialPort = null;//串口对象
        List<SlaveInfo> slaves = new List<SlaveInfo>();//存储从站信息列表
        List<ParaInfo> paraInfos = new List<ParaInfo>();//参数列表
        List<AlarmInfo> alarmInfos = new List<AlarmInfo>();//存储预警设置列表
        System.Timers.Timer timer = null;//定时器用来定时采集数据
        bool isStart=false;//表示设备装置已启动
        Task tCheck = null;// 检测线程
        CancellationTokenSource source=new CancellationTokenSource();
        ManualResetEvent resetEvent= new ManualResetEvent(true);
        bool isFirst = false;//第一次采集数据是否完成
        Dictionary<string, string> dicValues = new Dictionary<string, string>();//存储实时采集参数值        /// <summary>
        /// 装置得启停
        /// </summary>
        /// <param name="bl"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //加载从站列表
            LoadSlaveList();
            //加载参数列表
            LoadParaList();
            //加载预警设置列表
            LoadAlarmSetList();
            //创建串口对象及主站设备
            CreateConn();
            //初始化定时器
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;//重复执行
            timer.Elapsed += Timer_Elapsed;
        }

        /// <summary>
        /// 实施采集与检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void CreateConn()
        {
            serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            if (serialPort != null)
            {

                try
                {
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        //创建主站设备需要一个串口对象
                        master = ModbusSerialMaster.CreateRtu(serialPort);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }



        }
        private void LoadSlaveList()
        {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "/configFiles/XSlave.xml";
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            if (root != null)
            {

                foreach (XmlNode node in root.ChildNodes)
                {

                    SlaveInfo slave = new SlaveInfo();
                    slave.SlaveId = byte.Parse(node.SelectSingleNode("SlaveId").InnerText);
                    slave.FuntionCode = byte.Parse(node.SelectSingleNode("FunctionCode").InnerText);
                    slave.StartAddress = ushort.Parse(node.SelectSingleNode("StartAddress").InnerText);
                    slave.Count = ushort.Parse(node.SelectSingleNode("Count").InnerText);
                    slaves.Add(slave);



                }
            }



        }
        private void LoadParaList()
        {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "/configFiles/XParas.xml";
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            if (root != null)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    ParaInfo para = new ParaInfo();
                    para.ParaName = node.SelectSingleNode("ParaName").InnerText;
                    para.SlaveId = byte.Parse(node.SelectSingleNode("SlaveId").InnerText);
                    para.Address = ushort.Parse(node.SelectSingleNode("Address").InnerText);
                    para.DataType = node.SelectSingleNode("DataType").InnerText;
                    para.Note = node.SelectSingleNode("Note").InnerText;
                    paraInfos.Add(para);


                }
            }


        }
        private void LoadAlarmSetList()
        {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "/configFiles/XAlarmValue.xml";
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            if (root != null)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    AlarmInfo alarm = new AlarmInfo();
                    alarm.ParaType = node.SelectSingleNode("ParaType").InnerText;
                    alarm.AlarmType = int.Parse(node.SelectSingleNode("AlarmType").InnerText);
                    alarm.AlarmValue = node.SelectSingleNode("AlarmValue").InnerText;
                    alarmInfos.Add(alarm);



                }

            }
        }
        /// <summary>
        /// 实时采集与检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ReadAndLoad();
        }

        private void ReadAndLoad()
        {
            Task.Run(async () =>
            {
                //读
                foreach (var slave in slaves)
                {
                    //线圈值
                    if (slave.FuntionCode == 1)
                    {
                        bool[] bls = await master.ReadCoilsAsync(slave.SlaveId, slave.StartAddress, slave.Count);
                        if (bls.Length > 0)
                        {
                            //筛选从站相关参数
                            var paras = paraInfos.Where(p => p.SlaveId == slave.SlaveId).ToList();
                            //解析与存储
                            foreach (ParaInfo para in paras)
                            {
                                ushort addr = para.Address;
                                bool blVal = bls[addr];//取到参数值
                                if (!dicValues.ContainsKey(para.ParaName))
                                    dicValues.Add(para.ParaName, blVal.ToString());
                                else
                                    dicValues[para.ParaName] = blVal.ToString();
                            }
                        }
                    }
                    else if (slave.FuntionCode == 3)//保持型寄存器
                    {
                        ushort[] uDatas = await master.ReadHoldingRegistersAsync(slave.SlaveId, slave.StartAddress, slave.Count);
                        if (uDatas.Length > 0)
                        {
                            //筛选从站相关参数
                            var paras = paraInfos.Where(p => p.SlaveId == slave.SlaveId).ToList();
                            //解析与存储
                            foreach (ParaInfo para in paras)
                            {
                                ushort addr = para.Address;
                                ushort udata = uDatas[addr];//取到参数值
                                if (!dicValues.ContainsKey(para.ParaName))
                                    dicValues.Add(para.ParaName, udata.ToString());
                                else
                                    dicValues[para.ParaName] = udata.ToString();
                            }
                        }

                    }
                }

                //检测
                if (!isFirst)
                {
                    isFirst = true;//第一次采集完成
                    //初始化检测 第一次采集才执行
                    InitAlarmList();
                    //启动实时检测线程 
                    CheckAlarm();
                }

                //加载
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() =>
                    {
                        foreach (Control c in this.Controls)
                        {
                            if (c is UPump)
                            {
                                UPump pump = (UPump)c;
                                string pName = pump.PumpStateName;//状态参数名
                                pump.ActualState = bool.Parse(dicValues[pName]);//更新水泵的状态
                            }
                            else if (c is ParaTextBox)
                            { 
                                ParaTextBox txt = (ParaTextBox)c;
                                string pName = txt.VarName;//参数名
                                txt.DataVal = dicValues[pName];//更新参数值

                            }
                        }
                        ShowWarning(txtPump01Fre, lightPump01Fre);
                        ShowWarning(txtPump01Power, lightPump01Power);
                        ShowWarning(txtPump02Fre, lightPump02Fre);
                        ShowWarning(txtPump02Power, lightPump02Power);
                        ShowWarning(txtPump03Fre, lightPump03Fre);
                        ShowWarning(txtPump03Power, lightPump03Power);

                    }));
                }
            });
        }
        Dictionary<string, int> lastAlarmValues = new Dictionary<string, int>();
        private void InitAlarmList()
        {
            var paras = paraInfos.Where(p => p.SlaveId == 2).ToList();
            foreach (AlarmInfo alarm in alarmInfos)
            {
                //报警类型 L低值   H  高值报警
                string alarmType = alarm.AlarmType == 1 ? "L" : "H";
                int.TryParse(alarm.AlarmValue, out int alarmValue);//报警临界值
                var paras1 = paras.Where(p => p.ParaName.Contains(alarm.ParaType)).ToList();//与该参数类型相同的参数
                int val = 0;//参数实时值
                foreach (ParaInfo para in paras1)
                {
                    if (!lastAlarmValues.ContainsKey(para.ParaName + alarmValue) && dicValues[para.ParaName].Length > 0)
                    {
                        string strVal = dicValues[para.ParaName];//取出实时参数值
                        int.TryParse(strVal, out val);
                        lastAlarmValues.Add(para.ParaName + alarmType, val);//添加最新检测实时值
                        if (alarm.AlarmType == 1)
                        {
                            if (val < alarmValue)//低值异常
                            {
                                //添加低值预警信息
                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "LAlarm", val, para.Note + "低值报警");
                            }
                        }
                        else if (alarm.AlarmType == 2)
                        {
                            if (val > alarmValue)
                            {
                                //添加高值预警信息
                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "HAlarm", val, para.Note + "高值报警");
                            }
                        }
                    }
                }
            }
        }



        private void ShowWarning(ParaTextBox ptxt, UCAlarmControl ulight)
        {
            string paraName = ptxt.VarName;//参数名
            var alarmLogList = CommonClass.logList.Where(log => log.ParaName == paraName).OrderBy(log => log.Id).ToList();
            if (alarmLogList.Count > 0)
            {
                //找到最后一条预警信息
                var lastInfo = alarmLogList[alarmLogList.Count - 1];
                if (lastInfo.AlarmType == 1)
                {
                    if (lastInfo.AlarmState == "LAlarm")//异常
                    {
                        ulight.IsOn = true;//闪烁
                        ulight.AlarmLightColors[1] = Color.LightBlue;
                    }
                    else
                    {
                        ulight.IsOn = false;//不闪烁
                    }
                }
                else if (lastInfo.AlarmType == 2)
                {
                    if (lastInfo.AlarmState == "HAlarm")//异常
                    {
                        ulight.IsOn = true;//闪烁
                        ulight.AlarmLightColors[1] = Color.Orange;
                    }
                    else
                    {
                        ulight.IsOn = false;//不闪烁
                    }
                }
            }
        }



            /// 实时检测

        private void CheckAlarm()
        {
            var tk = source.Token;
            if (tCheck == null)
            {
                tCheck = Task.Run(() =>
                {
                    while (true)
                    {
                        if (tk.IsCancellationRequested)
                        {
                            return;
                        }
                        var alarmValues = lastAlarmValues;
                        if (alarmValues.Count > 0)
                        {
                            var paras = paraInfos.Where(p => p.SlaveId == 2).ToList();
                            foreach (AlarmInfo alarm in alarmInfos)
                            {
                                //报警类型 L低值   H  高值报警
                                string alarmType = alarm.AlarmType == 1 ? "L" : "H";
                                int.TryParse(alarm.AlarmValue, out int alarmValue);//报警临界值
                                var paras1 = paras.Where(p => p.ParaName.Contains(alarm.ParaType)).ToList();//与该参数类型相同的参数
                                foreach (ParaInfo para in paras1)
                                {
                                    int curValue = int.Parse(dicValues[para.ParaName]);//当前值
                                    int oldValue = 0;//上次的值
                                    string keyName = para.ParaName + alarmType;//lastAlarmValues的key
                                    if (alarmValues.ContainsKey(keyName))
                                    {
                                        oldValue = alarmValues[keyName];//取出上次的值
                                        if (alarm.AlarmType == 1)
                                        {
                                            string alarmNote = para.Note + "低值报警";
                                            //低值异常：当前低于临界值，之前比临界值大
                                            if (curValue < alarmValue && oldValue >= alarmValue)
                                            {
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "LAlarm", curValue, alarmNote);
                                            }
                                            //当前正常，之前低于临界值
                                            else if (curValue >= alarmValue && oldValue < alarmValue)
                                            {
                                                //添加取消低值报警记录
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "UnLAlarm", curValue, alarmNote);
                                            }

                                        }
                                        else if (alarm.AlarmType == 2)
                                        {
                                            string alarmNote = para.Note + "高值报警";
                                            //高值异常：当前高于临界值，之前比临界值小
                                            if (curValue > alarmValue && oldValue <= alarmValue)
                                            {
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "HAlarm", curValue, alarmNote);
                                            }
                                            //当前正常，之前低于临界值
                                            else if (curValue <= alarmValue && oldValue > alarmValue)
                                            {
                                                //添加取消高值报警记录
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "UnHAlarm", curValue, alarmNote);
                                            }
                                        }
                                        lastAlarmValues[keyName] = curValue;//新采集到的数据更新到最新检测数据中
                                    }
                                }
                            }
                        }
                        Thread.Sleep(1000);//挂起1s
                    }
                }, tk);
            }
            else
            {
                resetEvent.Set();//重启线程
            }
        }
        //存储最新得用于检测得参数数据


        /// <summary>
        /// 
        /// </summary>

        int fid = 0;
        private void  AddAlarmInfo(int aType,string paraName,string aState,int val,string note)
        {
            int id = ++fid;
            AlarmLogInfo logInfo = new AlarmLogInfo(id,DateTime.Now,paraName,aType,aState,val,note);
            //添加预警记录列表中//刷新到预警列表也中
            CommonClass.logList.Add(logInfo);
            CommonClass.UpdateDgvAlarmList();




        }

        ///启动与停止
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                Start(true);
                timer.Start();
                isStart = true;
                btnStart.Text = "停止";
                lblState.Text = "运行中";

            }
            else
            {
                Start(false);//停止关掉电源
                timer.Stop();
                isStart = false;
                source.Cancel();//取消
                resetEvent.WaitOne();
                uPump1.ActualState = false;
                uPump2.ActualState = false;
                uPump3.ActualState = false;
                foreach (Control c in this.Controls)
                {
                    if (c is UCAlarmControl)
                    {
                        UCAlarmControl light = c as UCAlarmControl;
                        if (light.IsOn)
                        {
                            light.IsOn = false;
                        }
                    }


                }
                btnStart.Text = "启动";
                lblState.Text = "已停止";

            }
        }
        private void Start(bool bl)
        {
            SlaveInfo slave01 = slaves.Find(s => s.SlaveId == 1);
         
                master.WriteMultipleCoils(slave01.SlaveId, slave01.StartAddress, new bool[] { bl, bl, bl, bl });
        
          
           
        }

        private void btnAlarmList_Click(object sender, EventArgs e)
        {
            FrmAlarmList frmAlarmList = new FrmAlarmList();
            frmAlarmList.Show();
        }
    }
    }

