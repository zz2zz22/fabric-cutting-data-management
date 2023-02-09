using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;

namespace cloth_cutting_data_report
{
    public partial class ShowCuttingData : Form
    {
        System.Windows.Forms.Timer tmrCallBgWorker;
        object lockObject = new object();
        //Khoi tao bg worker
        BackgroundWorker bgWorker;

        System.Threading.Timer tmrEnsureWorkerGetsCalled;
        public ShowCuttingData()
        {
            InitializeComponent();
        }

        private void ShowCuttingData_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadBackgroundWorker();
            tmrCallBgWorker.Start();
        }
        private void LoadBackgroundWorker()
        {   // this timer calls bgWorker again and again after regular intervals

            tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
            tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
            tmrCallBgWorker.Interval = 300000; //3600000;

            // this is our worker
            bgWorker = new BackgroundWorker();

            // work happens in this method
            bgWorker.DoWork += new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged += BW_ProgressChanged;
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            bgWorker.WorkerReportsProgress = true;
        }

        private void ShowCuttingData_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrCallBgWorker.Stop();

            tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
            bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged -= BW_ProgressChanged;
            bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
        }

        private void timer_nextRun_Tick(object sender, EventArgs e)
        {

            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    // if bgworker is not busy the call the worker
                    if (!bgWorker.IsBusy)
                    {
                        bgWorker.RunWorkerAsync();
                    }

                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
            else
            {
                // as the bgworker is busy we will start a timer that will try to call the bgworker again after some time
                tmrEnsureWorkerGetsCalled = new System.Threading.Timer(new TimerCallback(tmrEnsureWorkerGetsCalled_Callback), null, 0, 10);
            }
        }
        
        private delegate void dlgAddCustomControl();
        private void LoadControl()
        {
            if (this.flowLayoutPanel2.InvokeRequired)
                this.Invoke(new dlgAddCustomControl(LoadControl));
            else
            {
                try
                {
                    label1.Text = DateTime.Now.AddHours(-3).ToString("HH:mm") + " - " + DateTime.Now.ToString("HH:mm");
                    flowLayoutPanel2.Controls.Clear();
                    SqlSoft sqlSoft = new SqlSoft();
                    ComboBox cbxEmp = new ComboBox();
                    StringBuilder getData = new StringBuilder();
                    getData.Append("select distinct receiver from CuttingRealtimeData where create_date >= '" + DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'");
                    sqlSoft.getComboBoxData(getData.ToString(), ref cbxEmp);
                    for (int i = 0; i < cbxEmp.Items.Count; i++)
                    {
                        StringBuilder getPersData = new StringBuilder();
                        getPersData.Append("select distinct product_no from CuttingRealtimeData where create_date >= '" + DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and receiver = '" + cbxEmp.Items[i].ToString() + "'");
                        ComboBox cbxProductNo = new ComboBox();
                        sqlSoft.getComboBoxData(getPersData.ToString(), ref cbxProductNo);
                        for (int j = 0; j < cbxProductNo.Items.Count; j++)
                        {
                            StringBuilder getMatData = new StringBuilder();
                            getMatData.Append("select MAX(quantity) from CuttingRealtimeData where create_date >= '" + DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and receiver = '" + cbxEmp.Items[i].ToString() + "' and product_no = '" + cbxProductNo.Items[j].ToString() + "'");
                            string prodQty = sqlSoft.sqlExecuteScalarString(getMatData.ToString());
                            string reDate = sqlSoft.sqlExecuteScalarString("select MAX(create_date) from CuttingRealtimeData where create_date >= '" + DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and receiver = '" + cbxEmp.Items[i].ToString() + "' and product_no = '" + cbxProductNo.Items[j].ToString() + "'");
                            string sender = sqlSoft.sqlExecuteScalarString("select distinct sender from CuttingRealtimeData where create_date >= '" + DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and receiver = '" + cbxEmp.Items[i].ToString() + "' and product_no = '" + cbxProductNo.Items[j].ToString() + "'");

                            PersCutData persCutData = new PersCutData(cbxEmp.Items[i].ToString(), cbxProductNo.Items[j].ToString(), prodQty, sender, Convert.ToDateTime(reDate).ToString("dd/MM/yyyy HH:mm:ss"));
                            flowLayoutPanel2.Controls.Add(persCutData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load control: " + ex.Message);
                }
            }
        }
        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            LoadControl();
        }
        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
            }
            catch (Exception)
            {
            }
        }

        void tmrEnsureWorkerGetsCalled_Callback(object obj)
        {
            // this timer was started as the bgworker was busy before now it will try to call the bgworker again
            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    if (!bgWorker.IsBusy)
                    {
                        bgWorker.RunWorkerAsync();
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
                tmrEnsureWorkerGetsCalled = null;
            }
        }
    }
}
