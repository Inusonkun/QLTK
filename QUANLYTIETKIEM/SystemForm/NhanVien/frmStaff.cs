using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTIETKIEM.DAL;

namespace QUANLYTIETKIEM.SystemForm.NhanVien
{
    public partial class frmStaff : Form
    {
        DataAccess da;
        DataSet dt = new DataSet();
        public frmStaff()
        {
            InitializeComponent();
            da = new DataAccess();
        }
    }
}
