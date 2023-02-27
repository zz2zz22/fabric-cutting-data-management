namespace cloth_cutting_data_report
{
    partial class EditDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.txbSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtgvShowData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProductNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbClothNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbReceiver = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(13, 13);
            this.dtpSearchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(166, 27);
            this.dtpSearchDate.TabIndex = 0;
            // 
            // txbSearchKey
            // 
            this.txbSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchKey.Location = new System.Drawing.Point(197, 13);
            this.txbSearchKey.Name = "txbSearchKey";
            this.txbSearchKey.Size = new System.Drawing.Size(276, 27);
            this.txbSearchKey.TabIndex = 1;
            this.txbSearchKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtgvShowData
            // 
            this.dtgvShowData.AllowUserToAddRows = false;
            this.dtgvShowData.AllowUserToDeleteRows = false;
            this.dtgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowData.EnableHeadersVisualStyles = false;
            this.dtgvShowData.Location = new System.Drawing.Point(12, 58);
            this.dtgvShowData.Name = "dtgvShowData";
            this.dtgvShowData.ReadOnly = true;
            this.dtgvShowData.RowHeadersVisible = false;
            this.dtgvShowData.RowHeadersWidth = 51;
            this.dtgvShowData.RowTemplate.Height = 35;
            this.dtgvShowData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShowData.Size = new System.Drawing.Size(865, 607);
            this.dtgvShowData.TabIndex = 3;
            this.dtgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày tạo:";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(889, 37);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(407, 27);
            this.dtpCreateDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã thành phẩm:";
            // 
            // txbProductNo
            // 
            this.txbProductNo.Location = new System.Drawing.Point(889, 102);
            this.txbProductNo.Name = "txbProductNo";
            this.txbProductNo.Size = new System.Drawing.Size(321, 27);
            this.txbProductNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(885, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã lớp vải:";
            // 
            // txbClothNo
            // 
            this.txbClothNo.Location = new System.Drawing.Point(889, 168);
            this.txbClothNo.Name = "txbClothNo";
            this.txbClothNo.Size = new System.Drawing.Size(321, 27);
            this.txbClothNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "PCS:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(889, 234);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(188, 27);
            this.txbQuantity.TabIndex = 11;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Khối lượng:";
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(889, 299);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(188, 27);
            this.txbWeight.TabIndex = 13;
            this.txbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWeight_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Người nhập dữ liệu:";
            // 
            // txbSender
            // 
            this.txbSender.Location = new System.Drawing.Point(889, 372);
            this.txbSender.Name = "txbSender";
            this.txbSender.Size = new System.Drawing.Size(148, 27);
            this.txbSender.TabIndex = 15;
            this.txbSender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSender_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(885, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Người nhận nguyên liệu:";
            // 
            // txbReceiver
            // 
            this.txbReceiver.Location = new System.Drawing.Point(889, 449);
            this.txbReceiver.Name = "txbReceiver";
            this.txbReceiver.Size = new System.Drawing.Size(148, 27);
            this.txbReceiver.TabIndex = 17;
            this.txbReceiver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbReceiver_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(902, 518);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 72);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "CHỈNH SỬA";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1139, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 72);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "THÊM MỚI";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(1139, 614);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 51);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(679, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tải lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txbReceiver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbSender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbClothNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbProductNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvShowData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchKey);
            this.Controls.Add(this.dtpSearchDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDataForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa dữ liệu phòng cắt";
            this.Load += new System.EventHandler(this.EditDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.TextBox txbSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtgvShowData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProductNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbClothNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbReceiver;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}