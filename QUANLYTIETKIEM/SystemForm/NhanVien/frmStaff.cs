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

namespace QUANLYTIETKIEM.SystemForm.NhanVien
{
    public partial class frmStaff : Form
    {
        DataAccess da;
        DataSet dt = new DataSet();
        string ButtonClick = "";
        public frmStaff()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void ViewMode()
        {
            switch (ButtonClick)
            {
                case "Tìm":
                case "Thêm":
                    txtID.Text = "";
                    txtName.Text = "";
                    rdoFemale.Checked = false;
                    rdoMale.Checked = false;
                    txtChucVu.Text = "";
                    cbbChiNhanh.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                    cbbStatus.Text = "";
                    break;
                case "Sửa":
                    txtID.Text = dtgrvStaff.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dtgrvStaff.CurrentRow.Cells[1].Value.ToString();
                    rdoFemale.Checked = dtgrvStaff.CurrentRow.Cells[2].Value.ToString() == "Nữ" ? true : false;
                    dtpkBirthDay.Text = dtgrvStaff.CurrentRow.Cells[3].Value.ToString();
                    dtpkStartDate.Text = dtgrvStaff.CurrentRow.Cells[4].Value.ToString();
                    txtChucVu.Text = dtgrvStaff.CurrentRow.Cells[5].Value.ToString();
                    cbbChiNhanh.Text = dtgrvStaff.CurrentRow.Cells[6].Value.ToString();
                    txtPhoneNumber.Text = dtgrvStaff.CurrentRow.Cells[7].Value.ToString();
                    txtEmail.Text = dtgrvStaff.CurrentRow.Cells[8].Value.ToString();
                    txtAddress.Text = dtgrvStaff.CurrentRow.Cells[9].Value.ToString();
                    cbbStatus.Text = dtgrvStaff.CurrentRow.Cells[10].Value.ToString();
                    break;
                case "":
                    grbDetail.Enabled = true;
                    this.Height = 309;
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [NhanVien]" + str;
            try
            {
                dt = da.ExecuteAsDataSetSql(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt.Tables[0];
            dtgrvStaff.DataSource = bs;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            this.Height = 309;
            ViewMode();
            LoadData();
            ComboboxLoad();

        }

        private void AddNew()
        {
            try
            {
                ClassStaff st = new ClassStaff
                {
                    MaNV = txtID.Text.Trim(),
                    HoTen = txtName.Text.Trim(),
                    GioiTinh = rdoFemale.Checked ? "Nữ" : "Nam",
                    NgaySinh = dtpkBirthDay.Value,
                    NgayCongTac = dtpkStartDate.Value,
                    ChucVu = txtChucVu.Text.Trim(),
                    ChiNhanh = cbbChiNhanh.Text.Trim(),
                    SoDienThoai = txtPhoneNumber.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    TinhTrang = cbbStatus.Text.Trim()
                };

                int result = da.ExecuteData(st.ToInsertQuery(), st.ToParameters());
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
                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                ClassStaff st = new ClassStaff
                {
                    MaNV = txtID.Text.Trim(),
                    HoTen = txtName.Text.Trim(),
                    GioiTinh = rdoFemale.Checked ? "Nữ" : "Nam",
                    NgaySinh = dtpkBirthDay.Value,
                    NgayCongTac = dtpkStartDate.Value,
                    ChucVu = txtChucVu.Text.Trim(),
                    ChiNhanh = cbbChiNhanh.Text.Trim(),
                    SoDienThoai = txtPhoneNumber.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    TinhTrang = cbbStatus.Text.Trim()
                };

                int result = da.ExecuteData(st.ToUpdateQuery(), st.ToParameters());
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

        private void ComboboxLoad()
        {
            string sql = "SELECT * FROM [ChiNhanh]";
            try
            {
                dt = da.ExecuteAsDataSetSql(sql);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = dt.Tables[0];
            cbbChiNhanh.DataSource = dt.Tables[0];
            cbbChiNhanh.DisplayMember = "MaCN";
            cbbChiNhanh.ValueMember = "TenCN";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            this.Height = 506;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            this.Height = 506;
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
            this.Height = 309;
            ButtonClick = "";
            ViewMode();
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            this.Height = 506;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            ButtonClick = "Tìm";
            ViewMode();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch(ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    this.Height = 506;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    this.Height = 506;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Tìm":
                    String vFilter = "Where (1=1)";
                    if(txtID.Text != "")
                    {
                        vFilter = vFilter + " and MaNV like '%" + txtID.Text + "%'";
                    }

                    if(txtName.Text != "")
                    {
                        vFilter = vFilter + " and HoTen like '%" + txtName.Text + "%'";
                    }

                    if(txtChucVu.Text != "")
                    {
                        vFilter = vFilter + " and ChucVu like '%" + txtChucVu.Text + "%'";
                    }

                    if(cbbChiNhanh.Text != "")
                    {
                        vFilter = vFilter + " and ChiNhanh like '%" + cbbChiNhanh.Text + "%'";
                    }
                    break;
                default:
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(dt.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                foreach (System.Windows.Forms.DataGridViewRow dgvNhanVienrows in dtgrvStaff.SelectedRows)
                {
                    string _MaNV = dgvNhanVienrows.Cells[0].Value.ToString().Trim();
                    string _HoTen = dgvNhanVienrows.Cells[1].Value.ToString().Trim();

                    if(MessageBox.Show("Có chắc chắn xóa '" + _MaNV + " - " + _HoTen + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgvNhanVienrows.Index;
                            dt.Tables[0].Rows.RemoveAt(dgvNhanVienrows.Index);
                            dtgrvStaff.Refresh();

                            var result = dtgrvStaff.DataSource;

                            string sql = "DELETE FROM [NhanVien] " + "WHERE MaNV = '" + _MaNV + "'";
                            int _ok = da.ExecuteData(sql);
                            if (_ok > 0)
                            {
                                MessageBox.Show("Success!");
                            }
                            else MessageBox.Show("Failed!");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Có lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    i++;
                }
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            new frmReportViewer(new RptStaff()).ShowDialog();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (cbbStatus.SelectedIndex == i)
                {
                    break;
                }

            }
        }
    }
}
