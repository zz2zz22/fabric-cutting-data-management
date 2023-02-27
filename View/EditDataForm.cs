using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace cloth_cutting_data_report
{
    public partial class EditDataForm : Form
    {
        public EditDataForm()
        {
            InitializeComponent();
        }
        private DataTable LoadDataWithKey(string keyword, string date)
        {
            DataTable dataTable = new DataTable();
            SqlSoft sqlSoft = new SqlSoft();
            StringBuilder stringBuilder= new StringBuilder();
            if (String.IsNullOrEmpty(keyword))
                stringBuilder.Append("select * from CuttingRealtimeData where create_date >= '" + date + " 00:00:00' and create_date <= '" + date + " 23:59:59' order by create_date desc");
            else if (!String.IsNullOrEmpty(keyword))
                stringBuilder.Append("select * from CuttingRealtimeData where (product_no like '%" + keyword + "%' or cloth_no like '%" + keyword + "%') and create_date >= '" + date + " 00:00:00' and create_date <= '" + date + " 23:59:59' order by create_date desc");
            sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dataTable);
            return dataTable;
        }
        private void LoadShowDTGV(string keyword)
        {
            dtgvShowData.DataSource = null;
            dtgvShowData.DataSource = LoadDataWithKey(keyword, dtpSearchDate.Value.ToString("yyyy-MM-dd"));
            dtgvShowData.Columns["create_date"].HeaderText = "Ngày tạo";
            dtgvShowData.Columns["create_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dtgvShowData.Columns["product_no"].HeaderText = "Mã thành phẩm";
            dtgvShowData.Columns["cloth_no"].HeaderText = "Mã lớp vải";
            dtgvShowData.Columns["quantity"].HeaderText = "Số Lượng";
            dtgvShowData.Columns["weight"].HeaderText = "Khối lượng";
            dtgvShowData.Columns["sender"].HeaderText = "Người ghi";
            dtgvShowData.Columns["receiver"].HeaderText = "Người nhận";
        }
        private void EditDataForm_Load(object sender, EventArgs e)
        {
            dtpSearchDate.Value = DateTime.Now;
            LoadShowDTGV(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
        }

        private void dtgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowData.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowData.Rows[selectedrowindex];
                dtpCreateDate.Value = Convert.ToDateTime(selectedRow.Cells["create_date"].Value);
                txbProductNo.Text = Convert.ToString(selectedRow.Cells["product_no"].Value);
                txbClothNo.Text = Convert.ToString(selectedRow.Cells["cloth_no"].Value);
                txbQuantity.Text = Convert.ToString(selectedRow.Cells["quantity"].Value);
                txbWeight.Text = Convert.ToString(selectedRow.Cells["weight"].Value);
                string[] senderEmpCode = Convert.ToString(selectedRow.Cells["sender"].Value).Split('-');
                string[] receiverEmpCode = Convert.ToString(selectedRow.Cells["receiver"].Value).Split('-');
                txbSender.Text = senderEmpCode[1].Trim();
                txbReceiver.Text = receiverEmpCode[1].Trim();
            }
        }
        private bool CheckIsExisted(string date)
        {
            SqlSoft sqlSoft = new SqlSoft();
            string check = sqlSoft.sqlExecuteScalarString("select product_no where create_date = '" + date + "'");
            if (String.IsNullOrEmpty(check))
                return false;
            else
                return true;
        }
        private string GetEmpData(string Code)
        {
            SqlHR sqlHR = new SqlHR();
            string EmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + Code + "'");
            string EmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + EmpCode + "'");
            return EmpCode + " - " + EmpName.TrimEnd();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thêm dữ liệu vừa nhập ? Hãy kiểm tra kĩ lại trước khi xác nhận!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                DateTime time = new DateTime();
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder sqlInsert = new StringBuilder();
                if (CheckIsExisted(dtpCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.000")))
                {
                    time = dtpCreateDate.Value.AddSeconds(1);
                }
                else
                {
                    time = dtpCreateDate.Value;
                }
                string senderEmp = GetEmpData(txbSender.Text.Trim());
                string receiverEmp = GetEmpData(txbReceiver.Text.Trim());
                sqlInsert.Append("insert into CuttingRealtimeData ");
                sqlInsert.Append("(create_date, product_no, cloth_no, quantity, weight, sender, receiver) ");
                sqlInsert.Append("values ");
                sqlInsert.Append("('" + time.ToString("yyyy-MM-dd HH:mm:ss.000") + "', '" + txbProductNo.Text.Trim().ToUpper() + "', '" + txbClothNo.Text.Trim().ToUpper() + "', '" + txbQuantity.Text + "', '" + txbWeight.Text + "', '" + senderEmp + "', '" + receiverEmp + "')");
                sqlSoft.sqlExecuteNonQuery(sqlInsert.ToString(), false);
                MessageBox.Show("Thêm thành công");
                LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
            }
            
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbSender_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbReceiver_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Chỉnh sửa dữ liệu ? Hãy kiểm tra kĩ lại trước khi xác nhận!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder sqlUpdate = new StringBuilder();
                sqlUpdate.Append("update CuttingRealtimeData ");
                sqlUpdate.Append("set product_no = '" + txbProductNo.Text.Trim().ToUpper() + "',  cloth_no = '" + txbClothNo.Text.Trim().ToUpper() + "', quantity = '" + txbQuantity.Text + "', weight = '" + txbWeight.Text + "' ");
                sqlUpdate.Append("where create_date = '" + dtpCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.000") + "'");
                sqlSoft.sqlExecuteNonQuery(sqlUpdate.ToString(), false);
                MessageBox.Show("Sửa thành công!");
                LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xóa dữ liệu vừa chọn ? Hãy kiểm tra kĩ lại trước khi xác nhận!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder sqlDelete = new StringBuilder();
                sqlDelete.Append("delete CuttingRealtimeData where create_date = '" + dtpCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.000") + "'");
                sqlSoft.sqlExecuteNonQuery(sqlDelete.ToString(), false);
                MessageBox.Show("Xóa thành công!");
                LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpSearchDate.Value = DateTime.Now;
            txbSearchKey.Clear();
            LoadShowDTGV(null);
        }
    }
}
