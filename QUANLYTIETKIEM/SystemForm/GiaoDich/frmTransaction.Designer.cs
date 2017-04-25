namespace QUANLYTIETKIEM.SystemForm.GiaoDich
{
    partial class frmTransaction
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
            this.dtgrvTransaction = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.cbbSavingsID = new System.Windows.Forms.ComboBox();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemainingMoney = new System.Windows.Forms.TextBox();
            this.txtMoneyTransaction = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.rdbtDeposit = new System.Windows.Forms.RadioButton();
            this.rdbtWithdrawal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvTransaction)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvTransaction
            // 
            this.dtgrvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvTransaction.Location = new System.Drawing.Point(3, 4);
            this.dtgrvTransaction.Name = "dtgrvTransaction";
            this.dtgrvTransaction.Size = new System.Drawing.Size(641, 246);
            this.dtgrvTransaction.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(650, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 244);
            this.panel1.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(22, 202);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(86, 32);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(22, 164);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(86, 32);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(22, 126);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(86, 32);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(22, 88);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 32);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(22, 50);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(86, 32);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(22, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(86, 32);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.rdbtWithdrawal);
            this.grbDetail.Controls.Add(this.rdbtDeposit);
            this.grbDetail.Controls.Add(this.txtCustomers);
            this.grbDetail.Controls.Add(this.cbbSavingsID);
            this.grbDetail.Controls.Add(this.cbbStaff);
            this.grbDetail.Controls.Add(this.dtpkDate);
            this.grbDetail.Controls.Add(this.txtRemainingMoney);
            this.grbDetail.Controls.Add(this.txtMoneyTransaction);
            this.grbDetail.Controls.Add(this.txtID);
            this.grbDetail.Controls.Add(this.label7);
            this.grbDetail.Controls.Add(this.label6);
            this.grbDetail.Controls.Add(this.label5);
            this.grbDetail.Controls.Add(this.label4);
            this.grbDetail.Controls.Add(this.label3);
            this.grbDetail.Controls.Add(this.label2);
            this.grbDetail.Controls.Add(this.label1);
            this.grbDetail.Controls.Add(this.btCancel);
            this.grbDetail.Controls.Add(this.btCommit);
            this.grbDetail.Location = new System.Drawing.Point(5, 271);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(775, 152);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // cbbSavingsID
            // 
            this.cbbSavingsID.FormattingEnabled = true;
            this.cbbSavingsID.Location = new System.Drawing.Point(131, 53);
            this.cbbSavingsID.Name = "cbbSavingsID";
            this.cbbSavingsID.Size = new System.Drawing.Size(146, 21);
            this.cbbSavingsID.TabIndex = 23;
            this.cbbSavingsID.SelectedIndexChanged += new System.EventHandler(this.cbbSavingsID_SelectedIndexChanged);
            this.cbbSavingsID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbSavingsID_KeyDown);
            // 
            // cbbStaff
            // 
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(426, 22);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(146, 21);
            this.cbbStaff.TabIndex = 21;
            this.cbbStaff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbStaff_KeyDown);
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(131, 84);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(146, 20);
            this.dtpkDate.TabIndex = 20;
            this.dtpkDate.Value = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            this.dtpkDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpkDate_KeyDown);
            // 
            // txtRemainingMoney
            // 
            this.txtRemainingMoney.Location = new System.Drawing.Point(426, 119);
            this.txtRemainingMoney.Name = "txtRemainingMoney";
            this.txtRemainingMoney.Size = new System.Drawing.Size(146, 20);
            this.txtRemainingMoney.TabIndex = 18;
            // 
            // txtMoneyTransaction
            // 
            this.txtMoneyTransaction.Location = new System.Drawing.Point(131, 119);
            this.txtMoneyTransaction.Name = "txtMoneyTransaction";
            this.txtMoneyTransaction.Size = new System.Drawing.Size(146, 20);
            this.txtMoneyTransaction.TabIndex = 17;
            this.txtMoneyTransaction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoneyTransaction_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 20);
            this.txtID.TabIndex = 16;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số tiền còn lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số tiền giao dịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sổ tiết kiệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày giao dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số giao dịch";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(667, 84);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 32);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(667, 35);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(86, 32);
            this.btCommit.TabIndex = 6;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(426, 53);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(146, 20);
            this.txtCustomers.TabIndex = 24;
            // 
            // rdbtDeposit
            // 
            this.rdbtDeposit.AutoSize = true;
            this.rdbtDeposit.Location = new System.Drawing.Point(426, 88);
            this.rdbtDeposit.Name = "rdbtDeposit";
            this.rdbtDeposit.Size = new System.Drawing.Size(61, 17);
            this.rdbtDeposit.TabIndex = 25;
            this.rdbtDeposit.TabStop = true;
            this.rdbtDeposit.Text = "Gửi tiền";
            this.rdbtDeposit.UseVisualStyleBackColor = true;
            // 
            // rdbtWithdrawal
            // 
            this.rdbtWithdrawal.AutoSize = true;
            this.rdbtWithdrawal.Location = new System.Drawing.Point(510, 87);
            this.rdbtWithdrawal.Name = "rdbtWithdrawal";
            this.rdbtWithdrawal.Size = new System.Drawing.Size(62, 17);
            this.rdbtWithdrawal.TabIndex = 26;
            this.rdbtWithdrawal.TabStop = true;
            this.rdbtWithdrawal.Text = "Rút tiền";
            this.rdbtWithdrawal.UseVisualStyleBackColor = true;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgrvTransaction);
            this.Name = "frmTransaction";
            this.Text = "Giao dịch tiết kiệm";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.ComboBox cbbSavingsID;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.TextBox txtRemainingMoney;
        private System.Windows.Forms.TextBox txtMoneyTransaction;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.RadioButton rdbtWithdrawal;
        private System.Windows.Forms.RadioButton rdbtDeposit;
    }
}