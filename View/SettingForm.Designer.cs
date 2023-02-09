
namespace cloth_cutting_data_report
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxScaleSetting = new System.Windows.Forms.GroupBox();
            this.btnRefreshPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.gbxEmpSetting = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmpCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.lbDataUpdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txbDataFileLocation = new System.Windows.Forms.TextBox();
            this.gbxScaleSetting.SuspendLayout();
            this.gbxEmpSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxScaleSetting
            // 
            this.gbxScaleSetting.Controls.Add(this.btnRefreshPort);
            this.gbxScaleSetting.Controls.Add(this.label1);
            this.gbxScaleSetting.Controls.Add(this.cbxComPort);
            this.gbxScaleSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxScaleSetting.Location = new System.Drawing.Point(0, 0);
            this.gbxScaleSetting.Name = "gbxScaleSetting";
            this.gbxScaleSetting.Size = new System.Drawing.Size(528, 107);
            this.gbxScaleSetting.TabIndex = 0;
            this.gbxScaleSetting.TabStop = false;
            this.gbxScaleSetting.Text = "Cài đặt cân điện tử / 设置电子称";
            // 
            // btnRefreshPort
            // 
            this.btnRefreshPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefreshPort.ForeColor = System.Drawing.Color.Red;
            this.btnRefreshPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefreshPort.Location = new System.Drawing.Point(313, 25);
            this.btnRefreshPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefreshPort.Name = "btnRefreshPort";
            this.btnRefreshPort.Size = new System.Drawing.Size(204, 67);
            this.btnRefreshPort.TabIndex = 2;
            this.btnRefreshPort.Text = "Tải lại danh sách cổng\r\n重新加载 COM 端口列表";
            this.btnRefreshPort.UseVisualStyleBackColor = false;
            this.btnRefreshPort.Click += new System.EventHandler(this.btnRefreshPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cổng kết nối\r\n串口";
            // 
            // cbxComPort
            // 
            this.cbxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Location = new System.Drawing.Point(133, 45);
            this.cbxComPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(145, 28);
            this.cbxComPort.TabIndex = 0;
            // 
            // gbxEmpSetting
            // 
            this.gbxEmpSetting.Controls.Add(this.label4);
            this.gbxEmpSetting.Controls.Add(this.txbEmpCode);
            this.gbxEmpSetting.Controls.Add(this.label3);
            this.gbxEmpSetting.Controls.Add(this.label2);
            this.gbxEmpSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxEmpSetting.Location = new System.Drawing.Point(0, 107);
            this.gbxEmpSetting.Name = "gbxEmpSetting";
            this.gbxEmpSetting.Size = new System.Drawing.Size(528, 160);
            this.gbxEmpSetting.TabIndex = 1;
            this.gbxEmpSetting.TabStop = false;
            this.gbxEmpSetting.Text = "Cài đặt nhân viên / 员工设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vui lòng chỉ nhập số trong mã nhân viên. Ví dụ: TL - 14042 nhập 14042.\r\n在员工工号中，请仅" +
    "输入数字。比如：TL-14042 --- 填：14042。\r\n";
            // 
            // txbEmpCode
            // 
            this.txbEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txbEmpCode.Location = new System.Drawing.Point(202, 45);
            this.txbEmpCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Size = new System.Drawing.Size(149, 27);
            this.txbEmpCode.TabIndex = 3;
            this.txbEmpCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(154, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TL -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:\r\n员工工号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveSetting);
            this.groupBox1.Controls.Add(this.lbDataUpdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBrowseFile);
            this.groupBox1.Controls.Add(this.txbDataFileLocation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt dữ liệu: / 数据设置";
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveSetting.Location = new System.Drawing.Point(313, 205);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(194, 66);
            this.btnSaveSetting.TabIndex = 6;
            this.btnSaveSetting.Text = "LƯU CÀI ĐẶT\r\n保存设置";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // lbDataUpdate
            // 
            this.lbDataUpdate.AutoSize = true;
            this.lbDataUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDataUpdate.Location = new System.Drawing.Point(215, 77);
            this.lbDataUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataUpdate.Name = "lbDataUpdate";
            this.lbDataUpdate.Size = new System.Drawing.Size(0, 20);
            this.lbDataUpdate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(18, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày cập nhật dữ liệu:\r\n数据更新日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "File dữ liệu chỉ thay đổi khi có thay đổi về mã sản phẩm.\r\n 数据文件仅在产品代码发生变化时发生变化";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseFile.Location = new System.Drawing.Point(363, 38);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(39, 23);
            this.btnBrowseFile.TabIndex = 2;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // txbDataFileLocation
            // 
            this.txbDataFileLocation.Enabled = false;
            this.txbDataFileLocation.Location = new System.Drawing.Point(18, 38);
            this.txbDataFileLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbDataFileLocation.Name = "txbDataFileLocation";
            this.txbDataFileLocation.Size = new System.Drawing.Size(318, 27);
            this.txbDataFileLocation.TabIndex = 1;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxEmpSetting);
            this.Controls.Add(this.gbxScaleSetting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.gbxScaleSetting.ResumeLayout(false);
            this.gbxScaleSetting.PerformLayout();
            this.gbxEmpSetting.ResumeLayout(false);
            this.gbxEmpSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxScaleSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.Button btnRefreshPort;
        private System.Windows.Forms.GroupBox gbxEmpSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmpCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDataFileLocation;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDataUpdate;
        private System.Windows.Forms.Button btnSaveSetting;
    }
}