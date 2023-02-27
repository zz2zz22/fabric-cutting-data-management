using System;
using System.Collections.Generic;
using Quartz;
using Quartz.Impl;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace cloth_cutting_data_report
{

    public partial class MainWindow : Form
    {
        string dataIn;
        double returnValue;
        int cutQty;
        DataRow[] foundRows;
        DataTable dt = new DataTable();
        DataTable dts;


        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadDTGV()
        {
            dtgvCheckHistory.DataSource = dts;
            dtgvCheckHistory.Columns["create_date"].HeaderText = "Tgian";
            dtgvCheckHistory.Columns["create_date"].DefaultCellStyle.Format = "MM/dd HH:mm";
            dtgvCheckHistory.Columns["cloth_no"].HeaderText = "Mã liệu";
            dtgvCheckHistory.Columns["quantity"].HeaderText = "PCS";
            dtgvCheckHistory.Columns["weight"].HeaderText = "KL";
            dtgvCheckHistory.Columns["receiver"].HeaderText = "Ng nhận";
        }
        //void SaveDetails(List<DetailInformation> details)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        BinaryFormatter bf = new BinaryFormatter();
        //        bf.Serialize(ms, details);
        //        ms.Position = 0;
        //        byte[] buffer = new byte[(int)ms.Length];
        //        ms.Read(buffer, 0, buffer.Length);
        //        Properties.Settings.Default.details = Convert.ToBase64String(buffer);
        //        Properties.Settings.Default.Save();
        //    }
        //}

        //List<DetailInformation> LoadDetails()
        //{
        //    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.details)))
        //    {
        //        BinaryFormatter bf = new BinaryFormatter();
        //        return (List<DetailInformation>)bf.Deserialize(ms);
        //    }
        //}

        private void MainWindow_Load(object sender, EventArgs e)
        {
            txbMatCode.Enabled = false;
            //if (String.IsNullOrEmpty(Properties.Settings.Default.empCode) || String.IsNullOrEmpty(Properties.Settings.Default.comPort))
            //{
            //    SettingForm settingForm = new SettingForm();
            //    settingForm.FormClosing += settingFormClosing;
            //    settingForm.ShowDialog();
            //}
            if (!String.IsNullOrEmpty(Properties.Settings.Default.dataFileLocation))
            {
                LoadData();
            }
            //else
            //{



            //    //IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
            //    //scheduler.Start();
            //    //IJobDetail job = JobBuilder.Create<EmailJob>().Build();
            //    //ITrigger trigger = TriggerBuilder.Create()
            //    //    .WithDailyTimeIntervalSchedule(s => 
            //    //    s.WithIntervalInHours(12)
            //    //    .OnEveryDay()
            //    //    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(8,0)))
            //    //   .Build();
            //    //scheduler.ScheduleJob(job, trigger);
            //}

        }
        private void settingFormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)sender).FormClosing -= settingFormClosing;
            if (String.IsNullOrEmpty(Properties.Settings.Default.dataFileLocation) || String.IsNullOrEmpty(Properties.Settings.Default.empCode) || String.IsNullOrEmpty(Properties.Settings.Default.comPort))
            {
                DialogResult dialogResult = MessageBox.Show("Chưa cài đặt đủ dữ liệu, bạn có muốn thoát cài đặt? \n\r 没有安装足够的数据，要退出吗？", "Cảnh báo / 警报", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                LoadData();
            }
        }
        public void LoadData()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Dispose();
                    serialPort1.Close();

                    serialPort1.PortName = Properties.Settings.Default.comPort;
                    serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.baudRate);
                    serialPort1.DataBits = Convert.ToInt32(Properties.Settings.Default.dataBits);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.stopBits);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.parityBits);
                    serialPort1.ReadTimeout = 10000000;
                    serialPort1.WriteTimeout = 10000000;
                    serialPort1.Open();
                }
                else
                {
                    serialPort1.PortName = Properties.Settings.Default.comPort;
                    serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.baudRate);
                    serialPort1.DataBits = Convert.ToInt32(Properties.Settings.Default.dataBits);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.stopBits);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.parityBits);
                    serialPort1.ReadTimeout = 10000000;
                    serialPort1.WriteTimeout = 10000000;
                    serialPort1.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cân \n\r 口连接错误:" + ex.Message);
            }
            try
            {
                if (dt.Rows.Count > 0)
                {
                    dt.Clear();
                    dt.AcceptChanges();
                }

                string sSheetName = null;
                string sConnection = null;
                DataTable dtTablesList = default(DataTable);
                OleDbCommand oleExcelCommand = default(OleDbCommand);
                OleDbConnection oleExcelConnection = default(OleDbConnection);

                sConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Properties.Settings.Default.dataFileLocation + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";

                oleExcelConnection = new OleDbConnection(sConnection);
                oleExcelConnection.Open();

                dtTablesList = oleExcelConnection.GetSchema("Tables");

                if (dtTablesList.Rows.Count > 0)
                {
                    sSheetName = dtTablesList.Rows[0]["TABLE_NAME"].ToString();
                }

                dtTablesList.Clear();
                dtTablesList.Dispose();


                if (!string.IsNullOrEmpty(sSheetName))
                {

                    oleExcelCommand = oleExcelConnection.CreateCommand();
                    oleExcelCommand.CommandText = "Select * From [" + sSheetName + "]";
                    oleExcelCommand.CommandType = CommandType.Text;

                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = oleExcelCommand;
                    da.Fill(dt);
                    //dataGridView1.DataSource = dt;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        txbMatCode.Items.Add(dt.Rows[i]["1"].ToString());
                    }
                }
                oleExcelConnection.Close();

                txbMatCode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file dữ liệu \n\r 读取数据文件时出错:" + ex.Message);
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.FormClosing += settingFormClosing;
            settingForm.ShowDialog();
        }

        private void btnCheckExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from CuttingRealtimeData where create_date >= '" + dtpInDate.Value.ToString() + "' and create_date <= '" + dtpOutDate.Value.ToString() + "'");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                if (dt.Rows.Count > 0)
                {
                    List<DetailInformation> details = new List<DetailInformation>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DetailInformation d = new DetailInformation();
                        d.DateReceive = Convert.ToDateTime(dt.Rows[i]["create_date"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                        d.MainCode = dt.Rows[i]["product_no"].ToString();
                        d.DetailCode = dt.Rows[i]["cloth_no"].ToString();
                        d.Quantity = dt.Rows[i]["quantity"].ToString();
                        d.Weight = Convert.ToDouble(dt.Rows[i]["weight"].ToString());
                        d.Sender = dt.Rows[i]["sender"].ToString();
                        d.Receiver = dt.Rows[i]["receiver"].ToString();
                        details.Add(d);

                    }
                    ExcelSave.SaveExcel(details);
                }
                else
                {
                    MessageBox.Show("Không lấy được dữ liệu từ server! \n 无法从服务器获取数据！");
                }
                //ExcelSave.SaveExcel(); // false, false
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txbEmpReceiveCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            dataIn = serialPort1.ReadLine().Replace("kg", "").Trim();
            //Problem about scale latency --> Config scale mode --> HOLD mode 0 --> Kinda ok when test multiple time ( must wait for COM port to finalizing conneection )
            this.Invoke(new EventHandler(showData));

        }
        private void showData(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dataIn))
            {
                if (double.TryParse(dataIn, out returnValue))
                {
                    returnValue = Convert.ToDouble(dataIn);
                    lbWeight.Text = returnValue.ToString();
                }
            }

        }

        private void txbMatCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string expression;
                expression = "[1] like '%" + txbMatCode.Text.Trim() + "%'";
                DataRow[] foundRows;
                foundRows = dt.Select(expression);
                txbMatCode.Items.Clear();
                for (int i = 0; i < foundRows.Length; i++)
                {
                    if (!txbMatCode.Items.Contains(foundRows[i][0].ToString()))
                    {
                        txbMatCode.Items.Add(foundRows[i][0].ToString());
                    }

                }

            }
        }

        private void cbxDetailMat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foundRows = null;
            string searchExpression = "[2] = '" + cbxDetailMat.Text.Trim() + "'";
            foundRows = dt.Select(searchExpression);
            DataRow dr = foundRows.First();
            if (int.TryParse(dr["3"].ToString(), out cutQty))
            {
                cutQty = Convert.ToInt32(dr["3"].ToString());
                if (!String.IsNullOrWhiteSpace(txbRawQty.Text))
                {
                    lbCutQty.Text = Convert.ToString(Convert.ToInt32(txbRawQty.Text) * cutQty);
                }
                else
                {
                    lbCutQty.Text = "0";
                }
            }
            else
            {
                cutQty = 0;
            }
            txbRawQty.Enabled = true;
        }

        private void txbRawQty_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txbRawQty.Text))
            {
                lbCutQty.Text = Convert.ToString(Convert.ToInt32(txbRawQty.Text) * cutQty);
            }
            else
            {
                lbCutQty.Text = "0";
            }
        }
        //private bool checkHaveGetMaterial(string detailMatCode, string quantity)
        //{

        //    return false;
        //}
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNull())
                {
                    DetailInformation d = new DetailInformation();
                    SqlHR sqlHR = new SqlHR();

                    string EmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + Properties.Settings.Default.empCode + "'");
                    string EmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + EmpCode + "'");
                    string reEmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + txbEmpReceiveCode.Text + "'");
                    string reEmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + reEmpCode + "'");
                    d.DateReceive = DateTime.Now.ToString();
                    d.Sender = EmpCode + " - " + EmpName.TrimEnd();
                    if (!String.IsNullOrEmpty(reEmpCode) && !String.IsNullOrEmpty(reEmpName))
                    {
                        if (cbxDetailMat.Items.Count > 0)
                        {
                            d.MainCode = txbMatCode.Text.Trim();
                        }
                        d.Weight = returnValue;
                        d.DetailCode = cbxDetailMat.Text.Trim();
                        d.Quantity = lbCutQty.Text;
                        d.Receiver = reEmpCode + " - " + reEmpName.TrimEnd();



                        DialogResult dialogResult = MessageBox.Show("Lưu dữ liệu ?", "XÁC NHẬN", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            SqlSoft sqlSoft = new SqlSoft();
                            StringBuilder queryInsertData = new StringBuilder();
                            queryInsertData.Append(@"insert into CuttingRealtimeData ");
                            queryInsertData.Append(@"(create_date, product_no, cloth_no, quantity, weight, sender, receiver) ");
                            queryInsertData.Append("values ");
                            queryInsertData.Append("('" + d.DateReceive + "', '" + d.MainCode + "', '" + d.DetailCode + "', " + d.Quantity + ", '" + d.Weight + "', '" + d.Sender + "', '" + d.Receiver + "')");
                            sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), false);

                            dtgvCheckHistory.DataSource = null;


                            MessageBox.Show("Lưu thành công \n\r 保存成功 !!");
                            LoadEmpGetMatData();
                            LoadDTGV();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại mã nhân viên \n\r 再次检查员工代码!!");
                    }
                }
                else
                {
                    MessageBox.Show("Không đủ dữ liệu \n\r 数据不足!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkNull()
        {
            if (String.IsNullOrEmpty(txbMatCode.Text.Trim()) || String.IsNullOrEmpty(cbxDetailMat.Text.Trim()) || String.IsNullOrEmpty(txbRawQty.Text.Trim()) || String.IsNullOrEmpty(txbEmpReceiveCode.Text.Trim()))
            {

                return false;
            }
            else
            {
                return true;
            }
        }



        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình ? \n 想退出程序？", "Cảnh báo / 警报", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Properties.Settings.Default.empCode = String.Empty;
                Properties.Settings.Default.comPort = String.Empty;
                Properties.Settings.Default.Save();
                this.Dispose();
            }
        }

        private void txbMatCode_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbMatCode.Text.Trim()))
            {
                txbMatCode.Items.Clear();
                cbxDetailMat.Items.Clear();
                txbRawQty.Text = "";
                txbRawQty.Enabled = false;
                txbEmpReceiveCode.Text = "";
                lbCutQty.Text = "0";
            }

        }

        private void txbRawQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            ShowCuttingData showData = new ShowCuttingData();
            showData.ShowDialog();
        }

        private void txbMatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txbMatCode.Text))
            {
                foundRows = null;
                string searchExpression = "[1] = '" + txbMatCode.Text.Trim() + "'";
                foundRows = dt.Select(searchExpression);
                cbxDetailMat.Items.Clear();
                foreach (DataRow dr in foundRows)
                {
                    if (!String.IsNullOrEmpty(dr["3"].ToString().Trim()))
                    {
                        cbxDetailMat.Items.Add(dr["2"].ToString());
                    }
                }

            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadEmpGetMatData()
        {
            dts = new DataTable();
            SqlSoft sqlSoft = new SqlSoft();
            StringBuilder stringBuilder = new StringBuilder();
            SqlHR sqlHR = new SqlHR();
            string EmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + txbEmpReceiveCode.Text + "'");
            string EmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + EmpCode + "'");
            stringBuilder.Append("select create_date, cloth_no, quantity, weight, receiver from CuttingRealtimeData where receiver like '%" + EmpCode + " - " + EmpName.TrimEnd() + "%' and create_date > '" + DateTime.Now.AddHours(-2).ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
            sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dts);
        }
        private void btnSearchHisEmp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txbEmpReceiveCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để tìm!");
                txbEmpReceiveCode.Text = "";
            }
            else
            {
                LoadEmpGetMatData();
                LoadDTGV();
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
