namespace QUANLYTIETKIEM.SystemForm.NhanVien
{
    partial class frmStaff
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
            this.dtgrvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpkBirthDay = new System.Windows.Forms.DateTimePicker();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvStaff
            // 
            this.dtgrvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvStaff.Location = new System.Drawing.Point(2, 1);
            this.dtgrvStaff.Name = "dtgrvStaff";
            this.dtgrvStaff.Size = new System.Drawing.Size(660, 261);
            this.dtgrvStaff.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(668, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 261);
            this.panel1.TabIndex = 1;
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.cbbChiNhanh);
            this.grbDetail.Controls.Add(this.groupBox1);
            this.grbDetail.Controls.Add(this.cbbStatus);
            this.grbDetail.Controls.Add(this.txtAddress);
            this.grbDetail.Controls.Add(this.txtEmail);
            this.grbDetail.Controls.Add(this.txtChucVu);
            this.grbDetail.Controls.Add(this.txtName);
            this.grbDetail.Controls.Add(this.txtPhoneNumber);
            this.grbDetail.Controls.Add(this.dtpkStartDate);
            this.grbDetail.Controls.Add(this.dtpkBirthDay);
            this.grbDetail.Controls.Add(this.txtID);
            this.grbDetail.Controls.Add(this.label10);
            this.grbDetail.Controls.Add(this.label9);
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
            this.grbDetail.Location = new System.Drawing.Point(2, 286);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(783, 182);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(16, 25);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 29);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(16, 60);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(83, 29);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(16, 95);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 29);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(16, 130);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(83, 29);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(16, 165);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(83, 29);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(16, 200);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(83, 29);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(682, 51);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(83, 31);
            this.btCommit.TabIndex = 0;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(682, 97);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(83, 31);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày công tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên NV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tình trạng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chi nhánh";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(131, 20);
            this.txtID.TabIndex = 13;
            // 
            // dtpkBirthDay
            // 
            this.dtpkBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtpkBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkBirthDay.Location = new System.Drawing.Point(89, 63);
            this.dtpkBirthDay.Name = "dtpkBirthDay";
            this.dtpkBirthDay.Size = new System.Drawing.Size(131, 20);
            this.dtpkBirthDay.TabIndex = 14;
            this.dtpkBirthDay.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStartDate.Location = new System.Drawing.Point(89, 91);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(131, 20);
            this.dtpkStartDate.TabIndex = 15;
            this.dtpkStartDate.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(89, 122);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(131, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(308, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 18;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(308, 66);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(182, 20);
            this.txtChucVu.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(308, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(308, 118);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(182, 20);
            this.txtAddress.TabIndex = 21;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Đã nghỉ",
            "Tạm nghỉ",
            "Đang làm"});
            this.cbbStatus.Location = new System.Drawing.Point(307, 146);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(183, 21);
            this.cbbStatus.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nữ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(63, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nam";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(518, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 61);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(89, 148);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(131, 21);
            this.cbbChiNhanh.TabIndex = 26;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 472);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgrvStaff);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nh©n viªn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private System.Windows.Forms.DateTimePicker dtpkBirthDay;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
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
    }
}