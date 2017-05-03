namespace QUANLYTIETKIEM.SystemForm.SoTietKiem
{
    partial class frmSavingsBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSavingsBook));
            this.dtgrvSavingsBook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDue = new System.Windows.Forms.ComboBox();
            this.cbbCustomerID = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOriginalMoney = new System.Windows.Forms.TextBox();
            this.dtpkMatureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkOpenDate = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvSavingsBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvSavingsBook
            // 
            this.dtgrvSavingsBook.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvSavingsBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvSavingsBook.Location = new System.Drawing.Point(1, 0);
            this.dtgrvSavingsBook.Name = "dtgrvSavingsBook";
            this.dtgrvSavingsBook.Size = new System.Drawing.Size(663, 250);
            this.dtgrvSavingsBook.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(670, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 250);
            this.panel1.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(19, 203);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(92, 33);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(19, 164);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(92, 33);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(19, 125);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(92, 33);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(19, 86);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(92, 33);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(19, 47);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(92, 33);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAdd.Location = new System.Drawing.Point(19, 8);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(92, 33);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.txtInterest);
            this.grbDetail.Controls.Add(this.label9);
            this.grbDetail.Controls.Add(this.cbbDue);
            this.grbDetail.Controls.Add(this.cbbCustomerID);
            this.grbDetail.Controls.Add(this.txtBalance);
            this.grbDetail.Controls.Add(this.txtName);
            this.grbDetail.Controls.Add(this.txtOriginalMoney);
            this.grbDetail.Controls.Add(this.dtpkMatureDate);
            this.grbDetail.Controls.Add(this.dtpkOpenDate);
            this.grbDetail.Controls.Add(this.txtID);
            this.grbDetail.Controls.Add(this.label8);
            this.grbDetail.Controls.Add(this.label7);
            this.grbDetail.Controls.Add(this.label6);
            this.grbDetail.Controls.Add(this.label5);
            this.grbDetail.Controls.Add(this.label4);
            this.grbDetail.Controls.Add(this.label3);
            this.grbDetail.Controls.Add(this.label2);
            this.grbDetail.Controls.Add(this.label1);
            this.grbDetail.Controls.Add(this.btCancel);
            this.grbDetail.Controls.Add(this.btCommit);
            this.grbDetail.Location = new System.Drawing.Point(2, 256);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(797, 147);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(310, 95);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(95, 20);
            this.txtInterest.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Lãi suất";
            // 
            // cbbDue
            // 
            this.cbbDue.FormattingEnabled = true;
            this.cbbDue.Location = new System.Drawing.Point(140, 95);
            this.cbbDue.Name = "cbbDue";
            this.cbbDue.Size = new System.Drawing.Size(111, 21);
            this.cbbDue.TabIndex = 23;
            this.cbbDue.SelectedIndexChanged += new System.EventHandler(this.cbbTerm_SelectedIndexChanged);
            this.cbbDue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbTerm_KeyDown);
            // 
            // cbbCustomerID
            // 
            this.cbbCustomerID.FormattingEnabled = true;
            this.cbbCustomerID.Location = new System.Drawing.Point(140, 65);
            this.cbbCustomerID.Name = "cbbCustomerID";
            this.cbbCustomerID.Size = new System.Drawing.Size(185, 21);
            this.cbbCustomerID.TabIndex = 22;
            this.cbbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbbCustomerID_SelectedIndexChanged);
            this.cbbCustomerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbCustomerID_KeyDown);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(464, 90);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(161, 20);
            this.txtBalance.TabIndex = 21;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(440, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtOriginalMoney
            // 
            this.txtOriginalMoney.Location = new System.Drawing.Point(440, 32);
            this.txtOriginalMoney.Name = "txtOriginalMoney";
            this.txtOriginalMoney.Size = new System.Drawing.Size(185, 20);
            this.txtOriginalMoney.TabIndex = 19;
            this.txtOriginalMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOriginalMoney_KeyDown);
            // 
            // dtpkMatureDate
            // 
            this.dtpkMatureDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkMatureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkMatureDate.Location = new System.Drawing.Point(440, 122);
            this.dtpkMatureDate.Name = "dtpkMatureDate";
            this.dtpkMatureDate.Size = new System.Drawing.Size(185, 20);
            this.dtpkMatureDate.TabIndex = 18;
            this.dtpkMatureDate.Value = new System.DateTime(2017, 4, 24, 0, 0, 0, 0);
            this.dtpkMatureDate.ValueChanged += new System.EventHandler(this.dtpkMatureDate_ValueChanged);
            this.dtpkMatureDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpkMatureDate_KeyDown);
            // 
            // dtpkOpenDate
            // 
            this.dtpkOpenDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkOpenDate.Location = new System.Drawing.Point(140, 122);
            this.dtpkOpenDate.Name = "dtpkOpenDate";
            this.dtpkOpenDate.Size = new System.Drawing.Size(184, 20);
            this.dtpkOpenDate.TabIndex = 17;
            this.dtpkOpenDate.Value = new System.DateTime(2017, 4, 24, 0, 0, 0, 0);
            this.dtpkOpenDate.ValueChanged += new System.EventHandler(this.dtpkOpenDate_ValueChanged);
            this.dtpkOpenDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpkOpenDate_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 20);
            this.txtID.TabIndex = 16;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày mở sổ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số dư";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày đến hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số tiền gốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kỳ hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sổ";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(687, 90);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 33);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(687, 38);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(92, 33);
            this.btCommit.TabIndex = 6;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // frmSavingsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 400);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgrvSavingsBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSavingsBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ tiết kiệm";
            this.Load += new System.EventHandler(this.frmSavingsBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvSavingsBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvSavingsBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.ComboBox cbbDue;
        private System.Windows.Forms.ComboBox cbbCustomerID;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOriginalMoney;
        private System.Windows.Forms.DateTimePicker dtpkMatureDate;
        private System.Windows.Forms.DateTimePicker dtpkOpenDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label9;
    }
}