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

namespace QUANLYTIETKIEM.SystemForm.KyHan
{
    public partial class frmTerm : Form
    {
        DataAccess da;
        DataSet ds;
        string ButtonClick = "";

        public frmTerm()
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
                    txtTerm.Text = "";
                    txtInterestRate.Text = "";
                    cbbCurrency.Text = "";
                    cbbHTtralai.Text = "";
                    break;
                case "Sửa":
                    txtID.Text = dtgrvTerm.CurrentRow.Cells[0].Value.ToString();
                    txtTerm.Text = dtgrvTerm.CurrentRow.Cells[1].Value.ToString();
                    cbbCurrency.Text = dtgrvTerm.CurrentRow.Cells[2].Value.ToString();
                    txtInterestRate.Text = dtgrvTerm.CurrentRow.Cells[3].Value.ToString();                    
                    cbbHTtralai.Text = dtgrvTerm.CurrentRow.Cells[4].Value.ToString();
                    break;
                case "":
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [DMKyHan]" + str;
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
            dtgrvTerm.DataSource = bs;
        }

        private void ComboboxLoad()
        {
            string sql = "SELECT * FROM [LoaiTien]";
            try
            {
                ds = da.ExecuteAsDataSetSql(sql);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            cbbCurrency.DataSource = ds.Tables[0];
            cbbCurrency.DisplayMember = "MaTien";
            cbbCurrency.ValueMember = "TenLoaiTien";
        }

        private void AddNew()
        {
            try
            {
                ClassTerm kh = new ClassTerm
                {
                    MaKyHan = txtID.Text.ToString().Trim(),
                    TenKyHan = txtTerm.Text.ToString().Trim(),
                    LoaiTien = cbbCurrency.Text.ToString().Trim(),
                    LaiSuat = float.Parse(txtInterestRate.Text.ToString()),
                    HinhThucTraLai = cbbHTtralai.Text.ToString().Trim()
                };
                int result = da.ExecuteData(kh.ToInsertQuery(), kh.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success!");
                    ButtonClick = "";
                    ViewMode();
                    LoadData();
                }
                else MessageBox.Show("Failed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                ClassTerm kh = new ClassTerm
                {
                    MaKyHan = txtID.Text.ToString().Trim(),
                    TenKyHan = txtTerm.Text.ToString().Trim(),
                    LoaiTien = cbbCurrency.Text.ToString().Trim(),
                    LaiSuat = float.Parse(txtInterestRate.Text.ToString().Trim()),
                    HinhThucTraLai = cbbHTtralai.Text.ToString().Trim()
                };
                int result = da.ExecuteData(kh.ToUpdateQuery(), kh.ToParameters());
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
            this.Height = 455;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void frmTerm_Load(object sender, EventArgs e)
        {
            this.Height = 316;
            ViewMode();
            LoadData();
            ComboboxLoad();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.Height = 455;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Sửa";
            ViewMode();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch (ButtonClick)
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
                    if (txtID.Text != "")
                    {
                        vFilter = vFilter + " and MaTien like '%" + txtID.Text + "%'";
                    }
                    if (txtTerm.Text != "")
                    {
                        vFilter = vFilter + " and TenLoaiTien like '%" + txtTerm.Text + "%'";
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Height = 316;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!");
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvKyHanrows in dtgrvTerm.SelectedRows)
                {
                    string _MaKyHan = dgvKyHanrows.Cells[0].Value.ToString().Trim();
                    string _TenKyHan = dgvKyHanrows.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa '" + _MaKyHan + " - " + _TenKyHan + "' không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowidx = dgvKyHanrows.Index;
                            ds.Tables[0].Rows.RemoveAt(dgvKyHanrows.Index);
                            dtgrvTerm.Refresh();

                            var result = dtgrvTerm.DataSource;

                            string sql = "DELETE FROM [KyHan] " + " WHERE MaTien = '" + _MaKyHan + "'";
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
            this.Height = 455;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Lọc";
            ViewMode();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            new frmReportViewer(new RptTerm()).ShowDialog();
        }

        private void cbbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtNameCurrency.Text = cbbCurrency.SelectedValue.ToString();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtTerm.Focus();
            }

            if(e.KeyCode == Keys.Down)
            {
                cbbCurrency.Focus();
            }
        }

        private void txtTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbCurrency.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                txtID.Focus();
            }
        }

        private void cbbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtInterestRate.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                txtTerm.Focus();
            }

            if(e.KeyCode == Keys.Up)
            {
                txtID.Focus();
            }
        }

        private void txtInterestRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                cbbHTtralai.Focus();
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                cbbCurrency.Focus();
            }
        }

        private void cbbHTtralai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCommit_Click(sender, e);
            }

            if (e.KeyCode == Keys.Left)
            {
                txtInterestRate.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                cbbCurrency.Focus();
            }
        }
        
    }
}
