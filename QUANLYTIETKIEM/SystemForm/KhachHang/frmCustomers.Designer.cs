namespace QUANLYTIETKIEM.SystemForm.KhachHang
{
    partial class frmCustomers
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
            this.dtgrvCustomers = new System.Windows.Forms.DataGridView();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.rdbtFemale = new System.Windows.Forms.RadioButton();
            this.rdbtMale = new System.Windows.Forms.RadioButton();
            this.txtIDCustomers = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.txtPlaceofissue = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpkBday = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateofissue = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCustomers)).BeginInit();
            this.grbDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvCustomers
            // 
            this.dtgrvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvCustomers.Location = new System.Drawing.Point(2, 4);
            this.dtgrvCustomers.Name = "dtgrvCustomers";
            this.dtgrvCustomers.Size = new System.Drawing.Size(640, 242);
            this.dtgrvCustomers.TabIndex = 0;
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.txtEmail);
            this.grbDetail.Controls.Add(this.dtpkDateofissue);
            this.grbDetail.Controls.Add(this.dtpkBday);
            this.grbDetail.Controls.Add(this.txtAddress);
            this.grbDetail.Controls.Add(this.txtPhone);
            this.grbDetail.Controls.Add(this.txtPlaceofissue);
            this.grbDetail.Controls.Add(this.txtIdNo);
            this.grbDetail.Controls.Add(this.txtName);
            this.grbDetail.Controls.Add(this.txtIDCustomers);
            this.grbDetail.Controls.Add(this.rdbtMale);
            this.grbDetail.Controls.Add(this.rdbtFemale);
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
            this.grbDetail.Location = new System.Drawing.Point(4, 266);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(774, 177);
            this.grbDetail.TabIndex = 1;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(652, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 240);
            this.panel1.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(13, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(99, 32);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(13, 49);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(99, 32);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(13, 87);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(99, 32);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(13, 125);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(99, 32);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(13, 163);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(99, 32);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(13, 199);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(99, 32);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(661, 55);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(99, 32);
            this.btCommit.TabIndex = 3;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(661, 107);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(99, 32);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nơi cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CMND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email";
            // 
            // rdbtFemale
            // 
            this.rdbtFemale.AutoSize = true;
            this.rdbtFemale.Location = new System.Drawing.Point(513, 29);
            this.rdbtFemale.Name = "rdbtFemale";
            this.rdbtFemale.Size = new System.Drawing.Size(39, 17);
            this.rdbtFemale.TabIndex = 14;
            this.rdbtFemale.TabStop = true;
            this.rdbtFemale.Text = "Nữ";
            this.rdbtFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtMale
            // 
            this.rdbtMale.AutoSize = true;
            this.rdbtMale.Location = new System.Drawing.Point(558, 29);
            this.rdbtMale.Name = "rdbtMale";
            this.rdbtMale.Size = new System.Drawing.Size(47, 17);
            this.rdbtMale.TabIndex = 15;
            this.rdbtMale.TabStop = true;
            this.rdbtMale.Text = "Nam";
            this.rdbtMale.UseVisualStyleBackColor = true;
            // 
            // txtIDCustomers
            // 
            this.txtIDCustomers.Location = new System.Drawing.Point(134, 29);
            this.txtIDCustomers.Multiline = true;
            this.txtIDCustomers.Name = "txtIDCustomers";
            this.txtIDCustomers.Size = new System.Drawing.Size(149, 19);
            this.txtIDCustomers.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(349, 29);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(349, 58);
            this.txtIdNo.Multiline = true;
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(149, 20);
            this.txtIdNo.TabIndex = 18;
            // 
            // txtPlaceofissue
            // 
            this.txtPlaceofissue.Location = new System.Drawing.Point(349, 92);
            this.txtPlaceofissue.Multiline = true;
            this.txtPlaceofissue.Name = "txtPlaceofissue";
            this.txtPlaceofissue.Size = new System.Drawing.Size(149, 20);
            this.txtPlaceofissue.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(134, 154);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(134, 123);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(364, 20);
            this.txtAddress.TabIndex = 21;
            // 
            // dtpkBday
            // 
            this.dtpkBday.CustomFormat = "dd/MM/yyyy";
            this.dtpkBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkBday.Location = new System.Drawing.Point(134, 59);
            this.dtpkBday.Name = "dtpkBday";
            this.dtpkBday.Size = new System.Drawing.Size(148, 20);
            this.dtpkBday.TabIndex = 22;
            this.dtpkBday.Value = new System.DateTime(2017, 4, 24, 0, 0, 0, 0);
            // 
            // dtpkDateofissue
            // 
            this.dtpkDateofissue.CustomFormat = "dd/MM/yyyy";
            this.dtpkDateofissue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateofissue.Location = new System.Drawing.Point(134, 92);
            this.dtpkDateofissue.Name = "dtpkDateofissue";
            this.dtpkDateofissue.Size = new System.Drawing.Size(148, 20);
            this.dtpkDateofissue.TabIndex = 23;
            this.dtpkDateofissue.Value = new System.DateTime(2017, 4, 24, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(349, 153);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.dtgrvCustomers);
            this.Name = "frmCustomers";
            this.Text = "Danh s¸ch kh¸ch hµng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCustomers)).EndInit();
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvCustomers;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.TextBox txtIDCustomers;
        private System.Windows.Forms.RadioButton rdbtMale;
        private System.Windows.Forms.RadioButton rdbtFemale;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpkDateofissue;
        private System.Windows.Forms.DateTimePicker dtpkBday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPlaceofissue;
        private System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.TextBox txtName;
    }
}