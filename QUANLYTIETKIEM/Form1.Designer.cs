namespace QUANLYTIETKIEM
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.dMnuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemPhanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemSoTietKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemExchange = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVayVon = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTienGui = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuList = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemDue = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSystem,
            this.MnuUpdate,
            this.MnuItemExchange,
            this.MnuList,
            this.MnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuSystem
            // 
            this.MnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemLogin,
            this.MnuItemChangePass,
            this.dMnuItemUsers,
            this.MnuItemPhanQuyen,
            this.MnuItemExit});
            this.MnuSystem.Name = "MnuSystem";
            this.MnuSystem.Size = new System.Drawing.Size(63, 20);
            this.MnuSystem.Text = "Hệ thống";
            // 
            // MnuItemLogin
            // 
            this.MnuItemLogin.Name = "MnuItemLogin";
            this.MnuItemLogin.Size = new System.Drawing.Size(196, 22);
            this.MnuItemLogin.Text = "Đăng nhập";
            // 
            // MnuItemChangePass
            // 
            this.MnuItemChangePass.Name = "MnuItemChangePass";
            this.MnuItemChangePass.Size = new System.Drawing.Size(196, 22);
            this.MnuItemChangePass.Text = "Đổi mật khẩu";
            // 
            // dMnuItemUsers
            // 
            this.dMnuItemUsers.Name = "dMnuItemUsers";
            this.dMnuItemUsers.Size = new System.Drawing.Size(196, 22);
            this.dMnuItemUsers.Text = "Danh sách người sử dụng";
            // 
            // MnuItemPhanQuyen
            // 
            this.MnuItemPhanQuyen.Name = "MnuItemPhanQuyen";
            this.MnuItemPhanQuyen.Size = new System.Drawing.Size(196, 22);
            this.MnuItemPhanQuyen.Text = "Phân quyền người dùng";
            // 
            // MnuItemExit
            // 
            this.MnuItemExit.Name = "MnuItemExit";
            this.MnuItemExit.Size = new System.Drawing.Size(196, 22);
            this.MnuItemExit.Text = "Thoát";
            // 
            // MnuUpdate
            // 
            this.MnuUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCustomer,
            this.MnuItemStaff,
            this.MnuItemOffice,
            this.MnuItemSoTietKiem,
            this.MnuItemAccount});
            this.MnuUpdate.Name = "MnuUpdate";
            this.MnuUpdate.Size = new System.Drawing.Size(106, 20);
            this.MnuUpdate.Text = "Cập nhật thông tin";
            // 
            // MnuItemCustomer
            // 
            this.MnuItemCustomer.Name = "MnuItemCustomer";
            this.MnuItemCustomer.Size = new System.Drawing.Size(132, 22);
            this.MnuItemCustomer.Text = "Khách hàng";
            this.MnuItemCustomer.Click += new System.EventHandler(this.kháchHànhToolStripMenuItem_Click);
            // 
            // MnuItemStaff
            // 
            this.MnuItemStaff.Name = "MnuItemStaff";
            this.MnuItemStaff.Size = new System.Drawing.Size(132, 22);
            this.MnuItemStaff.Text = "Nhân viên";
            // 
            // MnuItemOffice
            // 
            this.MnuItemOffice.Name = "MnuItemOffice";
            this.MnuItemOffice.Size = new System.Drawing.Size(132, 22);
            this.MnuItemOffice.Text = "Chi nhánh";
            this.MnuItemOffice.Click += new System.EventHandler(this.MnuItemOffice_Click);
            // 
            // MnuItemSoTietKiem
            // 
            this.MnuItemSoTietKiem.Name = "MnuItemSoTietKiem";
            this.MnuItemSoTietKiem.Size = new System.Drawing.Size(132, 22);
            this.MnuItemSoTietKiem.Text = "Sổ tiết kiệm";
            // 
            // MnuItemAccount
            // 
            this.MnuItemAccount.Name = "MnuItemAccount";
            this.MnuItemAccount.Size = new System.Drawing.Size(132, 22);
            this.MnuItemAccount.Text = "Tài khoản";
            // 
            // MnuItemExchange
            // 
            this.MnuItemExchange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemSave,
            this.MnuItemVayVon,
            this.MnuItemTienGui});
            this.MnuItemExchange.Name = "MnuItemExchange";
            this.MnuItemExchange.Size = new System.Drawing.Size(64, 20);
            this.MnuItemExchange.Text = "Giao dịch";
            // 
            // MnuItemSave
            // 
            this.MnuItemSave.Name = "MnuItemSave";
            this.MnuItemSave.Size = new System.Drawing.Size(117, 22);
            this.MnuItemSave.Text = "Tiết kiệm";
            // 
            // MnuItemVayVon
            // 
            this.MnuItemVayVon.Name = "MnuItemVayVon";
            this.MnuItemVayVon.Size = new System.Drawing.Size(117, 22);
            this.MnuItemVayVon.Text = "Vay vốn";
            // 
            // MnuItemTienGui
            // 
            this.MnuItemTienGui.Name = "MnuItemTienGui";
            this.MnuItemTienGui.Size = new System.Drawing.Size(117, 22);
            this.MnuItemTienGui.Text = "Tiền gửi";
            // 
            // MnuList
            // 
            this.MnuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemMoney,
            this.MnuItemDue});
            this.MnuList.Name = "MnuList";
            this.MnuList.Size = new System.Drawing.Size(68, 20);
            this.MnuList.Text = "Danh mục";
            // 
            // MnuItemMoney
            // 
            this.MnuItemMoney.Name = "MnuItemMoney";
            this.MnuItemMoney.Size = new System.Drawing.Size(158, 22);
            this.MnuItemMoney.Text = "Danh mục tiền tệ";
            // 
            // MnuItemDue
            // 
            this.MnuItemDue.Name = "MnuItemDue";
            this.MnuItemDue.Size = new System.Drawing.Size(158, 22);
            this.MnuItemDue.Text = "Danh mục kỳ hạn";
            this.MnuItemDue.Click += new System.EventHandler(this.MnuItemDue_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(58, 20);
            this.MnuHelp.Text = "Trợ giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLYTIETKIEM.Properties.Resources.Logo_VN_Chuan_VCB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(705, 283);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý giao dịch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuSystem;
        private System.Windows.Forms.ToolStripMenuItem MnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCustomer;
        private System.Windows.Forms.ToolStripMenuItem MnuItemStaff;
        private System.Windows.Forms.ToolStripMenuItem MnuItemOffice;
        private System.Windows.Forms.ToolStripMenuItem MnuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem MnuItemChangePass;
        private System.Windows.Forms.ToolStripMenuItem dMnuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem MnuItemPhanQuyen;
        private System.Windows.Forms.ToolStripMenuItem MnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MnuItemSoTietKiem;
        private System.Windows.Forms.ToolStripMenuItem MnuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem MnuItemExchange;
        private System.Windows.Forms.ToolStripMenuItem MnuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVayVon;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTienGui;
        private System.Windows.Forms.ToolStripMenuItem MnuList;
        private System.Windows.Forms.ToolStripMenuItem MnuItemMoney;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDue;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
    }
}

