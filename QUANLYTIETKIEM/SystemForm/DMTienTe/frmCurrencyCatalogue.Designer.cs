namespace QUANLYTIETKIEM.SystemForm.DMTienTe
{
    partial class frmCurrencyCatalogue
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
            this.dtgrvCurrencyCatalogue = new System.Windows.Forms.DataGridView();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCurrencyCatalogue)).BeginInit();
            this.grbDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvCurrencyCatalogue
            // 
            this.dtgrvCurrencyCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvCurrencyCatalogue.Location = new System.Drawing.Point(1, 1);
            this.dtgrvCurrencyCatalogue.Name = "dtgrvCurrencyCatalogue";
            this.dtgrvCurrencyCatalogue.Size = new System.Drawing.Size(428, 250);
            this.dtgrvCurrencyCatalogue.TabIndex = 0;
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.label3);
            this.grbDetail.Controls.Add(this.label2);
            this.grbDetail.Controls.Add(this.label1);
            this.grbDetail.Controls.Add(this.txtRate);
            this.grbDetail.Controls.Add(this.txtName);
            this.grbDetail.Controls.Add(this.txtID);
            this.grbDetail.Controls.Add(this.btCancel);
            this.grbDetail.Controls.Add(this.btCommit);
            this.grbDetail.Location = new System.Drawing.Point(1, 267);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(570, 117);
            this.grbDetail.TabIndex = 1;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tỷ giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên tiền tệ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã tiền tệ";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(117, 85);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(248, 26);
            this.txtRate.TabIndex = 10;
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 53);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 26);
            this.txtName.TabIndex = 9;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 21);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(248, 26);
            this.txtID.TabIndex = 8;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(457, 69);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(91, 30);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(457, 33);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(91, 30);
            this.btCommit.TabIndex = 6;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(435, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 248);
            this.panel1.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(23, 194);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(91, 30);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(23, 158);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(91, 30);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(23, 122);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(91, 30);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(23, 86);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(91, 30);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(23, 50);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(91, 30);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(23, 14);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 30);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // frmCurrencyCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.dtgrvCurrencyCatalogue);
            this.Name = "frmCurrencyCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục tiền tệ";
            this.Load += new System.EventHandler(this.frmCurrencyCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCurrencyCatalogue)).EndInit();
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvCurrencyCatalogue;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
    }
}