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

namespace QUANLYTIETKIEM.SystemForm.Chinhanh
{
    public partial class frmChiNhanh : Form
    {
        private DataAccess da;
        DataSet dt = new DataSet();
        string ButtonClick = "";

        public frmChiNhanh()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void ViewMode()
        {
            switch(ButtonClick)
            {
                case "Tìm":
                case "Thêm":
                    txtID.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPhoneNumber.Text = "";
                    txtLeader.Text = "";
                    this.Height = 397;
                    break;
                case "Sửa":
                    this.Height = 397;
                    txtID.Text = dtgrvOffice.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dtgrvOffice.CurrentRow.Cells[1].Value.ToString();
                    txtAddress.Text = dtgrvOffice.CurrentRow.Cells[2].Value.ToString();
                    txtPhoneNumber.Text = dtgrvOffice.CurrentRow.Cells[3].Value.ToString();
                    txtLeader.Text = dtgrvOffice.CurrentRow.Cells[4].Value.ToString();
                    break;
                case "":
                    this.Height = 286;
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [ChiNhanh]" + str;
            try
            {
                dt = da.ExecuteAsDataSetSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt.Tables[0];
            dtgrvOffice.DataSource = bsource;
        }

        private void AddNew()
        {
            try
            {
                ClassChiNhanh cn = new ClassChiNhanh
                {
                    MaCN = txtID.Text.Trim(),
                    TenCN = txtName.Text.Trim(),
                    DiaDiem = txtAddress.Text.Trim(),
                    SoDienThoai = txtPhoneNumber.Text.Trim(),
                    TruongCN = txtLeader.Text.Trim()
                };

                int result = da.ExecuteData(cn.ToInsertQuery(), cn.ToParameters());
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
                MessageBox.Show("Lỗi! " + ex.Message, "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                ClassChiNhanh cn = new ClassChiNhanh
                {
                    MaCN = txtID.Text,
                    TenCN = txtName.Text,
                    DiaDiem = txtAddress.Text,
                    SoDienThoai = txtPhoneNumber.Text,
                    TruongCN = txtLeader.Text
                };

                int result = da.ExecuteData(cn.ToUpdateQuery(), cn.ToParameters());
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
                MessageBox.Show("Lỗi! " + ex.Message, "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            this.Height = 286;
            ViewMode();
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFilter.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch(ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    grbDetail.Enabled = true;
                    this.Height = 397;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    grbDetail.Enabled = true;
                    this.Height = 397;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Tìm":
                    string vFilter = " Where (1=1)";
                    if(txtID.Text != "")
                    {
                        vFilter = vFilter + "and MaCN like '%" + txtID.Text + "%'";
                    }
                    if(txtName.Text != "")
                    {
                        vFilter = vFilter + "and TenCN lke '%" + txtName.Text + "%'";
                    }
                    if(txtAddress.Text != "")
                    {
                        vFilter = vFilter + "and DiaDiem like '%" + txtAddress.Text + "%'";
                    }
                    if(txtLeader.Text != "")
                    {
                        vFilter = vFilter + "and TruongCN like '%" + txtLeader.Text + "%'";
                    }
                    LoadData(vFilter);
                    ButtonClick = "";
                    ViewMode();
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFilter.Enabled = true;
                    txtPhoneNumber.Enabled = false;

                    break;
                default:
                    break;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = false;
            this.Height = 286;
            btAdd.Enabled = true;
            btDelete.Enabled = true;
            btEdit.Enabled = true;
            btFilter.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFilter.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Sửa";
            ViewMode();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dt.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvChiNhanhrows in dtgrvOffice.SelectedRows)
                {
                    string _MaCN = dgvChiNhanhrows.Cells[0].Value.ToString().Trim();
                    string _TenCN = dgvChiNhanhrows.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaCN + " - " + _TenCN + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgvChiNhanhrows.Index;
                            dt.Tables[0].Rows.RemoveAt(dgvChiNhanhrows.Index);
                            dtgrvOffice.Refresh();

                            var result = dtgrvOffice.DataSource;

                            string sql = "DELETE FROM [DANHSACHKHOA] " +
                                         "WHERE MaKhoa ='" + _MaCN + "'";
                            int _ok = da.ExecuteData(sql);
                            if (_ok > 0)
                            {
                                MessageBox.Show("Success!");
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    i++;
                }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            new frmReportViewer(new RptChiNhanh()).ShowDialog();
        }

        private void btFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
