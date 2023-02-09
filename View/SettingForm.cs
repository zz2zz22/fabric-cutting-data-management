using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace cloth_cutting_data_report
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnRefreshPort_Click(object sender, EventArgs e)
        {
            cbxComPort.Items.Clear();
            cbxComPort.Text = Properties.Settings.Default.comPort;
            string[] ports = SerialPort.GetPortNames();
            cbxComPort.Items.AddRange(ports);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
            cbxComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbxComPort.Items.AddRange(ports);
            cbxComPort.Text = Properties.Settings.Default.comPort;
            txbEmpCode.Text = Properties.Settings.Default.empCode;
            txbDataFileLocation.Text = Properties.Settings.Default.dataFileLocation;
            lbDataUpdate.Text = Properties.Settings.Default.dataImportDate;
        }

        private void txbEmpCode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbDataFileLocation.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu để lưu! \n\r 请输入足够的数据以保存！");
            }
            else
            {
                Properties.Settings.Default.empCode = txbEmpCode.Text.Trim();
                Properties.Settings.Default.dataFileLocation = txbDataFileLocation.Text;
                Properties.Settings.Default.dataImportDate = lbDataUpdate.Text;
                Properties.Settings.Default.comPort = cbxComPort.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel Files (*.xlsx)|*.xls; *.xlsx";
            choofdlog.FilterIndex = 1;
            choofdlog.Title = "Hãy chọn file excel có chứa dữ liệu mã hàng! \n\r 请选择包含商品代码数据的excel文件！";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                lbDataUpdate.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                txbDataFileLocation.Text = choofdlog.FileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
