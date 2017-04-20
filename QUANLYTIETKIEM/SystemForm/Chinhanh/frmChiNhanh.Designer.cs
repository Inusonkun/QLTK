namespace QUANLYTIETKIEM.SystemForm.Chinhanh
{
    partial class frmChiNhanh
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
            this.dtgrvOffice = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCommit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLeader = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvOffice)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvOffice
            // 
            this.dtgrvOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvOffice.Location = new System.Drawing.Point(0, 1);
            this.dtgrvOffice.Name = "dtgrvOffice";
            this.dtgrvOffice.Size = new System.Drawing.Size(548, 237);
            this.dtgrvOffice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(554, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 244);
            this.panel1.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(4, 211);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(96, 30);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(4, 171);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(96, 34);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(4, 133);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(96, 32);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(4, 94);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 33);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(4, 52);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(96, 36);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(4, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 34);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.label5);
            this.grbDetail.Controls.Add(this.label4);
            this.grbDetail.Controls.Add(this.txtLeader);
            this.grbDetail.Controls.Add(this.txtPhoneNumber);
            this.grbDetail.Controls.Add(this.btCancel);
            this.grbDetail.Controls.Add(this.btCommit);
            this.grbDetail.Controls.Add(this.label3);
            this.grbDetail.Controls.Add(this.label2);
            this.grbDetail.Controls.Add(this.txtAddress);
            this.grbDetail.Controls.Add(this.txtName);
            this.grbDetail.Controls.Add(this.label1);
            this.grbDetail.Controls.Add(this.txtID);
            this.grbDetail.Location = new System.Drawing.Point(0, 248);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(658, 111);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(107, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã CN";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(78, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(443, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên CN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa điểm";
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(558, 32);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(96, 28);
            this.btCommit.TabIndex = 6;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(558, 76);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(96, 28);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(78, 48);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtLeader
            // 
            this.txtLeader.Location = new System.Drawing.Point(279, 48);
            this.txtLeader.Name = "txtLeader";
            this.txtLeader.Size = new System.Drawing.Size(242, 20);
            this.txtLeader.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trưởng CN";
            // 
            // frmChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 358);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgrvOffice);
            this.Name = "frmChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi nh¸nh";
            this.Load += new System.EventHandler(this.frmChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvOffice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvOffice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeader;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}