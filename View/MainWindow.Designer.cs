
namespace cloth_cutting_data_report
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopDock = new System.Windows.Forms.Panel();
            this.btnChangeData = new XanderUI.XUIButton();
            this.reload = new System.Windows.Forms.Button();
            this.btnShowData = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSetting = new XanderUI.XUIButton();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.dtgvCheckHistory = new System.Windows.Forms.DataGridView();
            this.lbAnnouce = new System.Windows.Forms.Label();
            this.panelMainLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDetailMat = new System.Windows.Forms.ComboBox();
            this.txbRawQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCutQty = new System.Windows.Forms.Label();
            this.txbEmpReceiveCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheckExcel = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSearchHisEmp = new System.Windows.Forms.Button();
            this.panelTopDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckHistory)).BeginInit();
            this.panelMainLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopDock
            // 
            this.panelTopDock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopDock.Controls.Add(this.btnChangeData);
            this.panelTopDock.Controls.Add(this.reload);
            this.panelTopDock.Controls.Add(this.btnShowData);
            this.panelTopDock.Controls.Add(this.pictureBox1);
            this.panelTopDock.Controls.Add(this.btnSetting);
            this.panelTopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopDock.Location = new System.Drawing.Point(0, 0);
            this.panelTopDock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelTopDock.Name = "panelTopDock";
            this.panelTopDock.Size = new System.Drawing.Size(1142, 59);
            this.panelTopDock.TabIndex = 0;
            // 
            // btnChangeData
            // 
            this.btnChangeData.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChangeData.ButtonImage = global::cloth_cutting_data_report.Properties.Resources.pencil;
            this.btnChangeData.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnChangeData.ButtonText = "Button";
            this.btnChangeData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChangeData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeData.CornerRadius = 5;
            this.btnChangeData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChangeData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeData.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnChangeData.Location = new System.Drawing.Point(929, 0);
            this.btnChangeData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(71, 59);
            this.btnChangeData.TabIndex = 3;
            this.btnChangeData.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.reload.Location = new System.Drawing.Point(257, 12);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(142, 28);
            this.reload.TabIndex = 2;
            this.reload.Text = "Load lại dữ liệu";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnShowData.ButtonImage = global::cloth_cutting_data_report.Properties.Resources.growth;
            this.btnShowData.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnShowData.ButtonText = "Button";
            this.btnShowData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnShowData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowData.CornerRadius = 5;
            this.btnShowData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnShowData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowData.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnShowData.Location = new System.Drawing.Point(1000, 0);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(71, 59);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::cloth_cutting_data_report.Properties.Resources.logoTechlinkFix;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSetting.ButtonImage = global::cloth_cutting_data_report.Properties.Resources.Settings_icon;
            this.btnSetting.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnSetting.ButtonText = "Button";
            this.btnSetting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetting.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.CornerRadius = 5;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetting.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnSetting.Location = new System.Drawing.Point(1071, 0);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(71, 59);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainContent.Controls.Add(this.dtgvCheckHistory);
            this.panelMainContent.Controls.Add(this.lbAnnouce);
            this.panelMainContent.Controls.Add(this.panelMainLeft);
            this.panelMainContent.Controls.Add(this.label8);
            this.panelMainContent.Controls.Add(this.dtpInDate);
            this.panelMainContent.Controls.Add(this.dtpOutDate);
            this.panelMainContent.Controls.Add(this.btnCheckExcel);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 59);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1142, 618);
            this.panelMainContent.TabIndex = 1;
            // 
            // dtgvCheckHistory
            // 
            this.dtgvCheckHistory.AllowUserToAddRows = false;
            this.dtgvCheckHistory.AllowUserToDeleteRows = false;
            this.dtgvCheckHistory.AllowUserToResizeColumns = false;
            this.dtgvCheckHistory.AllowUserToResizeRows = false;
            this.dtgvCheckHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCheckHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCheckHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCheckHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCheckHistory.GridColor = System.Drawing.Color.Black;
            this.dtgvCheckHistory.Location = new System.Drawing.Point(558, 36);
            this.dtgvCheckHistory.Name = "dtgvCheckHistory";
            this.dtgvCheckHistory.ReadOnly = true;
            this.dtgvCheckHistory.RowHeadersVisible = false;
            this.dtgvCheckHistory.RowHeadersWidth = 51;
            this.dtgvCheckHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvCheckHistory.RowTemplate.Height = 24;
            this.dtgvCheckHistory.Size = new System.Drawing.Size(571, 330);
            this.dtgvCheckHistory.TabIndex = 20;
            // 
            // lbAnnouce
            // 
            this.lbAnnouce.AutoSize = true;
            this.lbAnnouce.Location = new System.Drawing.Point(554, 12);
            this.lbAnnouce.Name = "lbAnnouce";
            this.lbAnnouce.Size = new System.Drawing.Size(347, 20);
            this.lbAnnouce.TabIndex = 19;
            this.lbAnnouce.Text = "Lịch sử nhận liệu của nhân viên trong 2 tiếng:\r\n";
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainLeft.Controls.Add(this.btnSearchHisEmp);
            this.panelMainLeft.Controls.Add(this.label1);
            this.panelMainLeft.Controls.Add(this.txbMatCode);
            this.panelMainLeft.Controls.Add(this.label2);
            this.panelMainLeft.Controls.Add(this.cbxDetailMat);
            this.panelMainLeft.Controls.Add(this.txbRawQty);
            this.panelMainLeft.Controls.Add(this.label3);
            this.panelMainLeft.Controls.Add(this.btnConfirm);
            this.panelMainLeft.Controls.Add(this.label4);
            this.panelMainLeft.Controls.Add(this.lbCutQty);
            this.panelMainLeft.Controls.Add(this.txbEmpReceiveCode);
            this.panelMainLeft.Controls.Add(this.label5);
            this.panelMainLeft.Controls.Add(this.label7);
            this.panelMainLeft.Controls.Add(this.lbWeight);
            this.panelMainLeft.Controls.Add(this.label6);
            this.panelMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Size = new System.Drawing.Size(548, 616);
            this.panelMainLeft.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thành phẩm:\r\n成品代码";
            // 
            // txbMatCode
            // 
            this.txbMatCode.FormattingEnabled = true;
            this.txbMatCode.Location = new System.Drawing.Point(151, 122);
            this.txbMatCode.Name = "txbMatCode";
            this.txbMatCode.Size = new System.Drawing.Size(312, 28);
            this.txbMatCode.TabIndex = 17;
            this.txbMatCode.SelectedIndexChanged += new System.EventHandler(this.txbMatCode_SelectedIndexChanged);
            this.txbMatCode.TextChanged += new System.EventHandler(this.txbMatCode_TextChanged);
            this.txbMatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMatCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(11, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã liệu vải:\r\n布码";
            // 
            // cbxDetailMat
            // 
            this.cbxDetailMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDetailMat.FormattingEnabled = true;
            this.cbxDetailMat.Location = new System.Drawing.Point(149, 180);
            this.cbxDetailMat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxDetailMat.Name = "cbxDetailMat";
            this.cbxDetailMat.Size = new System.Drawing.Size(314, 28);
            this.cbxDetailMat.TabIndex = 2;
            this.cbxDetailMat.SelectionChangeCommitted += new System.EventHandler(this.cbxDetailMat_SelectionChangeCommitted);
            // 
            // txbRawQty
            // 
            this.txbRawQty.Enabled = false;
            this.txbRawQty.Location = new System.Drawing.Point(149, 237);
            this.txbRawQty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbRawQty.Name = "txbRawQty";
            this.txbRawQty.Size = new System.Drawing.Size(103, 27);
            this.txbRawQty.TabIndex = 3;
            this.txbRawQty.TextChanged += new System.EventHandler(this.txbRawQty_TextChanged);
            this.txbRawQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRawQty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng gốc:\r\n原数量";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Yellow;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.Red;
            this.btnConfirm.Location = new System.Drawing.Point(314, 510);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(211, 82);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "XÁC NHẬN\r\n确认";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng cắt:\r\n裁出的数量";
            // 
            // lbCutQty
            // 
            this.lbCutQty.AutoSize = true;
            this.lbCutQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbCutQty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCutQty.Location = new System.Drawing.Point(146, 295);
            this.lbCutQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCutQty.Name = "lbCutQty";
            this.lbCutQty.Size = new System.Drawing.Size(27, 29);
            this.lbCutQty.TabIndex = 6;
            this.lbCutQty.Text = "0";
            // 
            // txbEmpReceiveCode
            // 
            this.txbEmpReceiveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txbEmpReceiveCode.Location = new System.Drawing.Point(218, 18);
            this.txbEmpReceiveCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbEmpReceiveCode.Name = "txbEmpReceiveCode";
            this.txbEmpReceiveCode.Size = new System.Drawing.Size(112, 27);
            this.txbEmpReceiveCode.TabIndex = 11;
            this.txbEmpReceiveCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpReceiveCode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trọng lượng (kg):\r\n重量(kg):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(166, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "TL - ";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.Red;
            this.lbWeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWeight.Location = new System.Drawing.Point(221, 368);
            this.lbWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(110, 51);
            this.lbWeight.TabIndex = 8;
            this.lbWeight.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã nhân viên nhận:\r\n接货的员工编号";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "V";
            // 
            // dtpInDate
            // 
            this.dtpInDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInDate.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInDate.Location = new System.Drawing.Point(728, 403);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(242, 27);
            this.dtpInDate.TabIndex = 14;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpOutDate.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutDate.Location = new System.Drawing.Point(728, 481);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(242, 27);
            this.dtpOutDate.TabIndex = 15;
            // 
            // btnCheckExcel
            // 
            this.btnCheckExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckExcel.Location = new System.Drawing.Point(772, 538);
            this.btnCheckExcel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheckExcel.Name = "btnCheckExcel";
            this.btnCheckExcel.Size = new System.Drawing.Size(151, 55);
            this.btnCheckExcel.TabIndex = 12;
            this.btnCheckExcel.Text = "Xuất báo biểu\r\n导出报表";
            this.btnCheckExcel.UseVisualStyleBackColor = true;
            this.btnCheckExcel.Click += new System.EventHandler(this.btnCheckExcel_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnSearchHisEmp
            // 
            this.btnSearchHisEmp.Location = new System.Drawing.Point(349, 10);
            this.btnSearchHisEmp.Name = "btnSearchHisEmp";
            this.btnSearchHisEmp.Size = new System.Drawing.Size(162, 43);
            this.btnSearchHisEmp.TabIndex = 18;
            this.btnSearchHisEmp.Text = "Tìm thông tin nhận";
            this.btnSearchHisEmp.UseVisualStyleBackColor = true;
            this.btnSearchHisEmp.Click += new System.EventHandler(this.btnSearchHisEmp_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 677);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTopDock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cutting Report Tool - Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelTopDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckHistory)).EndInit();
            this.panelMainLeft.ResumeLayout(false);
            this.panelMainLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopDock;
        private XanderUI.XUIButton btnSetting;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDetailMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRawQty;
        private System.Windows.Forms.Label lbCutQty;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmpReceiveCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheckExcel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private XanderUI.XUIButton btnShowData;
        private System.Windows.Forms.ComboBox txbMatCode;
        private System.Windows.Forms.Button reload;
        private XanderUI.XUIButton btnChangeData;
        private System.Windows.Forms.Label lbAnnouce;
        private System.Windows.Forms.Panel panelMainLeft;
        private System.Windows.Forms.DataGridView dtgvCheckHistory;
        private System.Windows.Forms.Button btnSearchHisEmp;
    }
}

