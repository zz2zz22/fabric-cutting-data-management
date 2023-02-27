using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloth_cutting_data_report
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txbUsername, "Tên đăng nhập không được trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbUsername, null);
            }
        }

        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txbPassword, "Mật khẩu không được trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbPassword, null);
            }
        }
        private bool checkAccount(string username, string password)
        {
            SqlSoft sqlSOFT = new SqlSoft();
            if (username != String.Empty && password != String.Empty)
            {
                string rsu = sqlSOFT.sqlExecuteScalarString("select distinct user_name from base_user_info where user_name = '" + username + "' and account_app = 'HTV5-Controller'");
                if (rsu != String.Empty)
                {

                    string rsp = sqlSOFT.sqlExecuteScalarString("select user_password from base_user_info where user_name = '" + username + "' and account_app = 'HTV5-Controller'");
                    if (rsp != String.Empty)
                    {
                        if (rsp == password)
                        {
                            //SaveVariables.OperatorUUID = sqlSOFT.sqlExecuteScalarString("select distinct uuid from base_user_info where user_name = '" + username + "' and account_app = 'HTV5-Controller'");
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (checkAccount(txbUsername.Text.TrimEnd(), txbPassword.Text.TrimEnd()))
                    {
                        EditDataForm editData = new EditDataForm();
                        editData.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        errorProvider.SetError(txbUsername, "Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (checkAccount(txbUsername.Text.TrimEnd(), txbPassword.Text.TrimEnd()))
                {
                    EditDataForm editData = new EditDataForm();
                    editData.ShowDialog();
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(txbUsername, "Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }
    }
}
