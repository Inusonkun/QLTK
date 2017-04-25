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

namespace QUANLYTIETKIEM.SystemForm.KhachHang
{
    public partial class frmCustomers : Form
    {
        DataAccess da;
        DataSet ds;
        string ButtonClick = "";
        public frmCustomers()
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
                    txtIDCustomers.Text = "";
                    txtName.Text = "";
                    rdbtFemale.Checked = false;
                    rdbtMale.Checked = false;
                    txtIdNo.Text = "";
                    txtPlaceofissue.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    break;
                case "Sửa":
                    txtIDCustomers.Text = dtgrvCustomers.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dtgrvCustomers.CurrentRow.Cells[1].Value.ToString();
                    rdbtFemale.Checked = dtgrvCustomers.CurrentRow.Cells[2].Value.ToString() == "Nữ" ? true : false;
                    dtpkBday.Text = dtgrvCustomers.CurrentRow.Cells[3].Value.ToString();
                    txtIdNo.Text = dtgrvCustomers.CurrentRow.Cells[4].Value.ToString();
                    dtpkDateofissue.Text = dtgrvCustomers.CurrentRow.Cells[5].Value.ToString();
                    txtPlaceofissue.Text = dtgrvCustomers.CurrentRow.Cells[6].Value.ToString();
                    txtAddress.Text = dtgrvCustomers.CurrentRow.Cells[7].Value.ToString();
                    txtPhone.Text = dtgrvCustomers.CurrentRow.Cells[8].Value.ToString();
                    txtEmail.Text = dtgrvCustomers.CurrentRow.Cells[9].Value.ToString();
                    break;
                case "":
                    this.Height = 290;
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [DMKhachHang]" + str;
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
            dtgrvCustomers.DataSource = bs;
        }        

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.Height = 290;
            ViewMode();
            LoadData();
        }

        private void AddNew()
        {
            try
            {
                ClassCustomers kh = new ClassCustomers
                {
                    MaKH = txtIDCustomers.Text.Trim(),
                    HoTen = txtName.Text.Trim(),
                    GioiTinh = rdbtFemale.Checked ? "Nữ" : "Nam",
                    NgaySinh = dtpkBday.Value,
                    CMND = txtIdNo.Text.Trim(),
                    NgayCap = dtpkDateofissue.Value,
                    NoiCap = txtPlaceofissue.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    SoDienThoai = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
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
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                ClassCustomers kh = new ClassCustomers
                {
                    MaKH = txtIDCustomers.Text.Trim(),
                    HoTen = txtName.Text.Trim(),
                    GioiTinh = rdbtFemale.Checked ? "Nữ" : "Nam",
                    NgaySinh = dtpkBday.Value,
                    CMND = txtIdNo.Text.Trim(),
                    NgayCap = dtpkDateofissue.Value,
                    NoiCap = txtPlaceofissue.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    SoDienThoai = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
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
                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.Height = 483;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.Height = 483;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Sửa";
            ViewMode();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach(System.Windows.Forms.DataGridViewRow dgvDMKhachHangrows in dtgrvCustomers.SelectedRows)
                {
                    string _MaKH = dgvDMKhachHangrows.Cells[0].Value.ToString().Trim();
                    string _HoTen = dgvDMKhachHangrows.Cells[1].Value.ToString().Trim();

                    if(MessageBox.Show("Bạn có muốn xóa '" + _MaKH + " - " + _HoTen + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowid = dgvDMKhachHangrows.Index;
                            ds.Tables[0].Rows.RemoveAt(dgvDMKhachHangrows.Index);
                            dtgrvCustomers.Refresh();

                            var result = dtgrvCustomers.DataSource;

                            string sql = "DELETE FROM [DMKhachHang]" + "WHERE MaKH '" + _MaKH + "'";
                            int _ok = da.ExecuteData(sql);
                            if (_ok > 0)
                        {
                            MessageBox.Show("Success!");
                        }
                        else MessageBox.Show("Failed!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    i++;
                }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            this.Height = 483;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Lọc";
            ViewMode();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch(ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    this.Height = 483;
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btDelete.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    this.Height = 483;
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btDelete.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Lọc":
                    String f = "Where (1 = 1)";
                    if(txtIDCustomers.Text != "")
                    {
                        f = f + " and MaKH like '%" + txtIDCustomers.Text + "%'";
                    }

                    if (txtName.Text != "")
                    {
                        f = f + " and HoTen like '%" + txtName.Text + "%'";
                    }

                    LoadData(f);
                    ViewMode();
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btDelete.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Height = 290;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
            btFilter.Enabled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                txtName.Focus();
            }

            if(e.KeyCode == Keys.Down)
            {
                dtpkBday.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                dtpkBday.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                txtIdNo.Focus();
            }

            if(e.KeyCode == Keys.Left)
            {
                txtIDCustomers.Focus();
            }
        }

        private void dtpkBday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                txtIdNo.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                dtpkDateofissue.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                txtName.Focus();
            }

            if(e.KeyCode == Keys.Up)
            {
                txtIDCustomers.Focus();
            }
        }

        private void txtIdNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                dtpkDateofissue.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                txtPlaceofissue.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                dtpkBday.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtName.Focus();
            }
        }

        private void dtpkDateofissue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                txtPlaceofissue.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                txtAddress.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                txtIdNo.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                dtpkBday.Focus();
            }
        }

        private void txtPlaceofissue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                txtAddress.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                dtpkDateofissue.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtIdNo.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                txtPhone.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                txtPlaceofissue.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                dtpkDateofissue.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                txtEmail.Focus();
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                txtAddress.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCommit_Click(sender, e);
            }

            if (e.KeyCode == Keys.Left )
            {
                txtPhone.Focus();
            }

            if(e.KeyCode == Keys.Up)
            {
                txtAddress.Focus();
            }
        }

    }
}
