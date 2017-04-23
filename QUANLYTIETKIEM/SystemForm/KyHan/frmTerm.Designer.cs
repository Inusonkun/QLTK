namespace QUANLYTIETKIEM.SystemForm.KyHan
{
    partial class frmTerm
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
            this.dtgrvTerm = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.cbbHTtralai = new System.Windows.Forms.ComboBox();
            this.cbbCurrency = new System.Windows.Forms.ComboBox();
            this.txtNameCurrency = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvTerm)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvTerm
            // 
            this.dtgrvTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvTerm.Location = new System.Drawing.Point(2, 2);
            this.dtgrvTerm.Name = "dtgrvTerm";
            this.dtgrvTerm.Size = new System.Drawing.Size(626, 268);
            this.dtgrvTerm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(634, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 268);
            this.panel1.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(27, 210);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(95, 32);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(27, 172);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(95, 32);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(27, 134);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(95, 32);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(27, 96);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 32);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(27, 58);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 32);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(27, 20);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(95, 32);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.cbbHTtralai);
            this.gbDetail.Controls.Add(this.cbbCurrency);
            this.gbDetail.Controls.Add(this.txtNameCurrency);
            this.gbDetail.Controls.Add(this.txtInterestRate);
            this.gbDetail.Controls.Add(this.txtTerm);
            this.gbDetail.Controls.Add(this.txtID);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.btCancel);
            this.gbDetail.Controls.Add(this.btCommit);
            this.gbDetail.Location = new System.Drawing.Point(4, 282);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(776, 132);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Chi tiết";
            // 
            // cbbHTtralai
            // 
            this.cbbHTtralai.FormattingEnabled = true;
            this.cbbHTtralai.Items.AddRange(new object[] {
            "Trả trước",
            "Trả sau"});
            this.cbbHTtralai.Location = new System.Drawing.Point(360, 105);
            this.cbbHTtralai.Name = "cbbHTtralai";
            this.cbbHTtralai.Size = new System.Drawing.Size(184, 21);
            this.cbbHTtralai.TabIndex = 14;
            this.cbbHTtralai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbHTtralai_KeyDown);
            // 
            // cbbCurrency
            // 
            this.cbbCurrency.FormattingEnabled = true;
            this.cbbCurrency.Location = new System.Drawing.Point(76, 65);
            this.cbbCurrency.Name = "cbbCurrency";
            this.cbbCurrency.Size = new System.Drawing.Size(184, 21);
            this.cbbCurrency.TabIndex = 13;
            this.cbbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbbCurrency_SelectedIndexChanged);
            this.cbbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbCurrency_KeyDown);
            // 
            // txtNameCurrency
            // 
            this.txtNameCurrency.Location = new System.Drawing.Point(360, 65);
            this.txtNameCurrency.Multiline = true;
            this.txtNameCurrency.Name = "txtNameCurrency";
            this.txtNameCurrency.Size = new System.Drawing.Size(184, 25);
            this.txtNameCurrency.TabIndex = 12;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(76, 101);
            this.txtInterestRate.Multiline = true;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(184, 25);
            this.txtInterestRate.TabIndex = 11;
            this.txtInterestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterestRate_KeyDown);
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(360, 19);
            this.txtTerm.Multiline = true;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(184, 25);
            this.txtTerm.TabIndex = 10;
            this.txtTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTerm_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 19);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(184, 25);
            this.txtID.TabIndex = 9;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hình thức trả lãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên tiền tệ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiền tệ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lãi suất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên kỳ hạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã kỳ hạn";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(657, 78);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 32);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(657, 29);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(95, 32);
            this.btCommit.TabIndex = 1;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // frmTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 415);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgrvTerm);
            this.Name = "frmTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục kỳ hạn";
            this.Load += new System.EventHandler(this.frmTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvTerm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvTerm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cbbHTtralai;
        private System.Windows.Forms.ComboBox cbbCurrency;
        private System.Windows.Forms.TextBox txtNameCurrency;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtID;
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