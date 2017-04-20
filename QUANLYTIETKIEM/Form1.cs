using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTIETKIEM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kháchHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
        }

        private void MnuItemOffice_Click(object sender, EventArgs e)
        {
            SystemForm.Chinhanh.frmChiNhanh frm = new SystemForm.Chinhanh.frmChiNhanh();
            frm.ShowDialog();
        }

        private void MnuItemDue_Click(object sender, EventArgs e)
        {
            //frmKyHan frm = new frmKyHan();
            //frm.Show();
        }
    }
}
