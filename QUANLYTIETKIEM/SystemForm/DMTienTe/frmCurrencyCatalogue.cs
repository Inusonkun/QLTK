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
using QUANLYTIETKIEM.Reports;

namespace QUANLYTIETKIEM.SystemForm.DMTienTe
{
    public partial class frmCurrencyCatalogue : Form
    {
        DataAccess da;
        DataSet ds;
        string ButtonClick = "";

        public frmCurrencyCatalogue()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
        }

        private void ViewMode()
        {
            switch(ButtonClick)
            {
                case "Lọc":
                case "Thêm":
                    txtID.Text = "";
                    txtName.Text = "";
                    txtRate.Text = "";
                    break;
                case "Sửa":
                    txtID.Text = dtgrvCurrencyCatalogue.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dtgrvCurrencyCatalogue.CurrentRow.Cells[1].Value.ToString();
                    txtRate.Text = dtgrvCurrencyCatalogue.CurrentRow.Cells[2].Value.ToString();
                    break;
                case "":
                    grbDetail.Enabled = true;
                    this.Height = 295;
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [LoaiTien]" + str;
            try
            {
                ds = da.ExecuteAsDataSetSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dtgrvCurrencyCatalogue.DataSource = bs;
        }

        private void frmCurrencyCatalogue_Load(object sender, EventArgs e)
        {
            this.Height = 423;
            ViewMode();
            LoadData();
        }

        private void AddNew()
        {
            try
            {
                ClassCurrency tt = new ClassCurrency
                {
                    MaTien = txtID.Text.Trim(),
                    TenLoaiTien = txtName.Text.Trim(),
                    TyGia = float.Parse(txtRate.Text.ToString())
                };
                int result = da.ExecuteData(tt.ToInsertQuery(), tt.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success!");
                    ButtonClick = "";
                    ViewMode();
                    LoadData();
                }
                else MessageBox.Show("Failed!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                ClassCurrency tt = new ClassCurrency
                {
                    MaTien = txtID.Text.Trim(),
                    TenLoaiTien = txtName.Text.Trim(),
                    TyGia = float.Parse(txtRate.Text.ToString())
                };
                int result = da.ExecuteData(tt.ToUpdateQuery(), tt.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success!");
                    ButtonClick = "";
                    ViewMode();
                    LoadData();
                }
                else MessageBox.Show("Failed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.Height = 423;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.Height = 423;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Sửa";
            ViewMode();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Height = 285;
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch(ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    btDelete.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    btDelete.Enabled = true;
                    break;
                case "Lọc":
                    String vFilter = "Where (1 = 1)";
                    if(txtID.Text != "")
                    {
                        vFilter = vFilter + " and MaTien like '%" + txtID.Text + "%'";
                    }
                    if(txtName.Text != "")
                    {
                        vFilter = vFilter + " and TenLoaiTien like '%" + txtName.Text + "%'";
                    }
                    LoadData(vFilter);
                    ButtonClick = "";
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    btDelete.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!");
            }
            else
                foreach(System.Windows.Forms.DataGridViewRow dgvLoaiTienrows in dtgrvCurrencyCatalogue.SelectedRows)
                {
                    string _MaTien = dgvLoaiTienrows.Cells[0].Value.ToString().Trim();
                    string _TenLoaiTien = dgvLoaiTienrows.Cells[1].Value.ToString().Trim();

                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa '" + _MaTien + " - " + _TenLoaiTien + "' không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowidx = dgvLoaiTienrows.Index;
                            ds.Tables[0].Rows.RemoveAt(dgvLoaiTienrows.Index);
                            dtgrvCurrencyCatalogue.Refresh();

                            var result = dtgrvCurrencyCatalogue.DataSource;

                            string sql = "DELETE FROM [LoaiTien] " + " WHERE MaTien = '" + _MaTien + "'";
                            int _ok = da.ExecuteData(sql);
                            if (_ok > 0)
                            {
                                MessageBox.Show("Success!");
                            }
                            else MessageBox.Show("Failed!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    i++;
                }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            this.Height = 423;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Lọc";
            ViewMode();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            new frmReportViewer(new RptCurrency()).ShowDialog();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtName.Focus();
            }
            
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
    
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txtRate.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txtID.Focus();
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btCommit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Up)
            {
                txtName.Focus();
            }
        }

    }
}
