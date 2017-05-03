using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLYTIETKIEM.DAL;
using QUANLYTIETKIEM.Reports;

namespace QUANLYTIETKIEM.SystemForm.GiaoDich
{
    public partial class frmTransaction : Form
    {
        DataAccess da;
        DataSet ds;
        string ButtonClick = "";
        public frmTransaction()
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
                    cbbStaff.Text = "";
                    cbbSavingsID.Text = "";
                    txtMoneyTransaction.Text = "";
                    rdbtDeposit.Checked = false;
                    rdbtWithdrawal.Checked = false;
                    txtRemainingMoney.Text = "";
                    break;
                case "Sửa":
                    txtID.Text = dtgrvTransaction.CurrentRow.Cells[0].Value.ToString();
                    cbbStaff.Text = dtgrvTransaction.CurrentRow.Cells[1].Value.ToString();
                    cbbSavingsID.Text = dtgrvTransaction.CurrentRow.Cells[2].Value.ToString();
                    dtpkDate.Text = dtgrvTransaction.CurrentRow.Cells[3].Value.ToString();
                    txtMoneyTransaction.Text = dtgrvTransaction.CurrentRow.Cells[4].Value.ToString();
                    rdbtDeposit.Checked = dtgrvTransaction.CurrentRow.Cells[5].Value.ToString() == "Gửi tiền" ? true : false;
                    txtRemainingMoney.Text = dtgrvTransaction.CurrentRow.Cells[6].Value.ToString();
                    break;
                case "":
                    this.Height = 295;
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [Giao_Dich]" + str;
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
            dtgrvTransaction.DataSource = bs;
        }

        private void CbbSavingsLoad()
        {
            string sql = "SELECT * FROM [SoTietKiem]";
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
            cbbSavingsID.DataSource = ds.Tables[0];
            cbbSavingsID.DisplayMember = "MaSo";
            cbbSavingsID.ValueMember = "SoTienGoc";
        }

        private void CbbStaffLoad()
        {
            string sql = "SELECT * FROM [NhanVien]";
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
            cbbStaff.DataSource = ds.Tables[0];
            cbbStaff.DisplayMember = "MaNV";
            cbbStaff.ValueMember = "HoTen";
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            this.Height = 295;
            ViewMode();
            LoadData();
            CbbSavingsLoad();
            CbbStaffLoad();
            txtRemainingMoney.ReadOnly = true;
        }

        private void AddNew()
        {
            try
            {
                ClassTransaction gd = new ClassTransaction
                {
                    SoGiaoDich = int.Parse(txtID.Text.Trim()),
                    NhanVien = cbbStaff.Text.Trim(),
                    SoTK = cbbSavingsID.Text.Trim(),
                    NgayGiaoDich = dtpkDate.Value,
                    SoTienGD = float.Parse(txtMoneyTransaction.Text.Trim()),
                    TinhChat = rdbtDeposit.Checked ? "Gửi tiền" : "Rút tiền",
                    SoTienConLai = float.Parse(txtRemainingMoney.Text.Trim())
                };
                int result = da.ExecuteData(gd.ToInsertQuery(), gd.ToParameters());
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
                ClassTransaction gd = new ClassTransaction
                {
                    SoGiaoDich = int.Parse(txtID.Text.Trim()),
                    NhanVien = cbbStaff.Text.Trim(),
                    SoTK = cbbSavingsID.Text.Trim(),
                    NgayGiaoDich = dtpkDate.Value,
                    SoTienGD = float.Parse(txtMoneyTransaction.Text.Trim()),
                    TinhChat = rdbtDeposit.Checked ? "Gửi tiền" : "Rút tiền",
                    SoTienConLai = float.Parse(txtRemainingMoney.Text.Trim())
                };
                int result = da.ExecuteData(gd.ToUpdateQuery(), gd.ToParameters());
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Height = 295;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
            btFilter.Enabled = true;
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch(ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    this.Height = 507;
                    btAdd.Enabled = false;
                    btEdit.Enabled = false;
                    btDelete.Enabled = false;
                    btFilter.Enabled = false;
                    break;
                case "Sửa":
                    EditData();
                    this.Height = 507;
                    btAdd.Enabled = false;
                    btEdit.Enabled = false;
                    btDelete.Enabled = false;
                    btFilter.Enabled = false;
                    break;
                case "Lọc":
                    String f = "Where (1 = 1)";
                    if(txtID.Text != "")
                    {
                        f = f + " and SoGiaoDich like '%" + txtID.Text + "%'";
                    }

                    if (cbbSavingsID.Text != "")
                    {
                        f = f + " and SoTK like '%" + cbbSavingsID.Text + "%'";
                    }

                    if (cbbStaff.Text != "")
                    {
                        f = f + " and NhanVien like '%" + cbbStaff.Text + "%'";
                    }
                    break;
                default:
                    break;
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            this.Height = 507;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Lọc";
            ViewMode();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.Height = 507;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.Height = 507;
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
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvGiao_Dichrows in dtgrvTransaction.SelectedRows)
                {
                    string _SoGiaoDich = dgvGiao_Dichrows.Cells[0].Value.ToString().Trim();
                    string _SoTK = dgvGiao_Dichrows.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Bạn có muốn xóa '" + _SoGiaoDich + " - " + _SoTK + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowid = dgvGiao_Dichrows.Index;
                            ds.Tables[0].Rows.RemoveAt(dgvGiao_Dichrows.Index);
                            dtgrvTransaction.Refresh();

                            var result = dtgrvTransaction.DataSource;

                            string sql = "DELETE FROM [Giao_Dich]" + "WHERE SoGiaoDich '" + _SoGiaoDich + "'";
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

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                cbbStaff.Focus();
            }

            if(e.KeyCode == Keys.Down)
            {
                cbbSavingsID.Focus();
            }
        }

        private void cbbStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                cbbSavingsID.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                dtpkDate.Focus();
            }

            if(e.KeyCode == Keys.Left)
            {
                txtID.Focus();
            }
        }

        private void cbbSavingsID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                 dtpkDate.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtID.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                cbbStaff.Focus();
            }
        }

        private void dtpkDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                txtMoneyTransaction.Focus();
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                cbbSavingsID.Focus();
            }
        }

        private void txtMoneyTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rdbtDeposit.Checked == true || rdbtWithdrawal.Checked == true)
                {
                    btCommit_Click(sender, e);
                }
                else MessageBox.Show("Bạn chưa chọn hình thức giao dịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                dtpkDate.Focus();
            }
        }

        private void cbbSavingsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtOriginal.Text = cbbSavingsID.SelectedValue.ToString();

            string sql = "SELECT SoDu FROM SoTietKiem INNER JOIN Giao_Dich ON SoTietKiem.MaSo = Giao_Dich.SoTK" + " WHERE SoTietKiem.MaSo = '" + cbbSavingsID.DisplayMember.ToString() + "' AND Giao_Dich.SoGiaoDich = '" + txtID.Text.ToString() + "'";
            try
            {
                ds = da.ExecuteAsDataSetSql(sql);
            }
            catch
            {               
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtBalance.Text = bs[0].ToString();
            }
        }

        private void cbbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtName.Text = cbbStaff.SelectedValue.ToString();
            
        }

        private void txtRemainingMoney_TextChanged(object sender, EventArgs e)
        {
            
            if(rdbtDeposit.Checked == true)
            {
                if(txtMoneyTransaction.Text == "" || txtBalance.Text == "")
                {
                    return;
                }
                else
                {
                    txtRemainingMoney.Text = (float.Parse(txtMoneyTransaction.Text) + float.Parse(txtBalance.Text)).ToString();
                }
            }
            else if(rdbtWithdrawal.Checked == true)
            {
                if (txtMoneyTransaction.Text == "" || txtBalance.Text == "")
                {
                    return;
                }
                else
                {
                    txtRemainingMoney.Text = (float.Parse(txtMoneyTransaction.Text) - float.Parse(txtBalance.Text)).ToString();
                }
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer rpf = new frmReportViewer("RptTransaction.rpt");
            rpf.ShowDialog();

        }
    }
}
