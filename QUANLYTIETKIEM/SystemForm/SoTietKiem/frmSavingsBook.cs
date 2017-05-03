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

namespace QUANLYTIETKIEM.SystemForm.SoTietKiem
{
    public partial class frmSavingsBook : Form
    {
        DataAccess da;
        DataSet ds;
        string ButtonClick = "";
        public frmSavingsBook()
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
                    cbbCustomerID.Text = "";
                    cbbDue.Text = "";
                    txtOriginalMoney.Text = "";
                    txtBalance.Text = "";
                    break;
                case "Sửa":
                    txtID.Text = dtgrvSavingsBook.CurrentRow.Cells[0].Value.ToString();
                    cbbCustomerID.Text = dtgrvSavingsBook.CurrentRow.Cells[1].Value.ToString();
                    cbbDue.Text = dtgrvSavingsBook.CurrentRow.Cells[2].Value.ToString();
                    txtOriginalMoney.Text = dtgrvSavingsBook.CurrentRow.Cells[3].Value.ToString();
                    dtpkOpenDate.Text = dtgrvSavingsBook.CurrentRow.Cells[4].Value.ToString();
                    dtpkMatureDate.Text = dtgrvSavingsBook.CurrentRow.Cells[5].Value.ToString();
                    txtBalance.Text = dtgrvSavingsBook.CurrentRow.Cells[6].Value.ToString();
                    break;
                case "":
                    this.Height = 284;
                    break;
                default:
                    break;
            }
        }

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [SoTietKiem]" + str;
            try
            {
                ds = da.ExecuteAsDataSetSql(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dtgrvSavingsBook.DataSource = bs;
        }

        private void ComboboxCustomer()
        {
            string sql = "SELECT * FROM [DMKhachHang]";
            try
            {
                ds = da.ExecuteAsDataSetSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            cbbCustomerID.DataSource = ds.Tables[0];
            cbbCustomerID.DisplayMember = "MaKH";
            cbbCustomerID.ValueMember = "HoTen";
        }

        private void ComboboxTerm()
        {
            string sql = "SELECT * FROM [DMKyHan]";
            try
            {
                ds = da.ExecuteAsDataSetSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!" + ex.Message, " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            cbbDue.DataSource = ds.Tables[0];
            cbbDue.DisplayMember = "MaKyHan";
            cbbDue.ValueMember = "LaiSuat";
        }

        private void frmSavingsBook_Load(object sender, EventArgs e)
        {
            this.Height = 284;
            ViewMode();
            LoadData();
            ComboboxTerm();
            ComboboxCustomer();
            txtBalance.ReadOnly = true;
            txtInterest.ReadOnly = true;
        }

        private void cbbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtName.Text = cbbCustomerID.SelectedValue.ToString();
        }

        private void AddNew()
        {
            try
            {
                ClassSavings tk = new ClassSavings
                {
                    MaSo = txtID.Text.ToString().Trim(),
                    MaKH = cbbCustomerID.Text.ToString().Trim(),
                    KyHan = cbbDue.Text.ToString().Trim(),
                    SoTienGoc = float.Parse(txtOriginalMoney.Text.ToString().Trim()),
                    NgayMoSo = dtpkOpenDate.Value,
                    NgayDenHan = dtpkMatureDate.Value,
                    SoDu = float.Parse(txtBalance.Text.ToString().Trim())
                };
                int result = da.ExecuteData(tk.ToInsertQuery(), tk.ToParameters());
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
                MessageBox.Show("Lỗi! " + ex.Message, "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                ClassSavings tk = new ClassSavings
                {
                    MaSo = txtID.Text.ToString().Trim(),
                    MaKH = cbbCustomerID.Text.ToString().Trim(),
                    KyHan = cbbDue.Text.ToString().Trim(),
                    SoTienGoc = float.Parse(txtOriginalMoney.Text.ToString().Trim()),
                    NgayMoSo = dtpkOpenDate.Value,
                    NgayDenHan = dtpkMatureDate.Value,
                    SoDu = float.Parse(txtBalance.Text.ToString().Trim())
                };
                int result = da.ExecuteData(tk.ToUpdateQuery(), tk.ToParameters());
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
                MessageBox.Show("Lỗi! " + ex.Message, "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.Height = 447;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Thêm";
            ViewMode();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.Height = 447;
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
                foreach (System.Windows.Forms.DataGridViewRow dgvSoTietKiemrows in dtgrvSavingsBook.SelectedRows)
                {
                    string _MaSo = dgvSoTietKiemrows.Cells[0].Value.ToString().Trim();
                    string _MaKH = dgvSoTietKiemrows.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Bạn có muốn xóa '" + _MaSo + " - " + _MaKH + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowid = dgvSoTietKiemrows.Index;
                            ds.Tables[0].Rows.RemoveAt(dgvSoTietKiemrows.Index);
                            dtgrvSavingsBook.Refresh();

                            var result = dtgrvSavingsBook.DataSource;

                            string sql = "DELETE FROM [SoTietKiem]" + "WHERE MaSo '" + _MaSo + "'";
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
            this.Height = 447;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btFilter.Enabled = false;
            ButtonClick = "Lọc";
            ViewMode();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch (ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    this.Height = 447;
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btDelete.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    this.Height = 447;
                    btAdd.Enabled = true;
                    btEdit.Enabled = true;
                    btDelete.Enabled = true;
                    btFilter.Enabled = true;
                    break;
                case "Lọc":
                    String f = "Where (1 = 1)";
                    if (txtID.Text != "")
                    {
                        f = f + " and MaKH like '%" + txtID.Text + "%'";
                    }

                    if (cbbCustomerID.SelectedText != "")
                    {
                        f = f + " and HoTen like '%" + cbbCustomerID.Text + "%'";
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
            this.Height = 284;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
            btFilter.Enabled = true;
            btDelete.Enabled = true;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                txtOriginalMoney.Focus();
            }

            if(e.KeyCode == Keys.Down)
            {
                txtID.Focus();
            }
        }

        private void txtOriginalMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right)
            {
                txtID.Focus();
            }

            if(e.KeyCode == Keys.Down)
            {
                cbbDue.Focus();
            }

            if(e.KeyCode == Keys.Left)
            {
                txtID.Focus();
            }
        }

        private void cbbCustomerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                cbbDue.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                txtOriginalMoney.Focus();
            }

            if(e.KeyCode == Keys.Up)
            {
                txtID.Focus();
            }
        }

        private void cbbTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                dtpkOpenDate.Focus();
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                cbbCustomerID.Focus();
            }
        }

        private void dtpkOpenDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpkMatureDate.Focus();                                            
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                cbbDue.Focus();
            }
        }

        private void dtpkMatureDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCommit_Click(sender, e);
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                dtpkOpenDate.Focus();
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            //txtBalance.Text = (float.Parse(txtOriginalMoney.Text) * float.Parse(txtInterest.Text) * Convert.ToInt32(cbbDue.Text)).ToString();
        }

        private void cbbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {          
            this.txtInterest.Text = cbbDue.SelectedValue.ToString();
            if (txtOriginalMoney.Text != "" & txtInterest.Text != "" & cbbDue.Text != "")
            {
                txtBalance.Text = (float.Parse(txtOriginalMoney.Text) + float.Parse(txtOriginalMoney.Text) * float.Parse(txtInterest.Text) * Convert.ToInt32(cbbDue.Text)).ToString();
            }

        }

        private void dtpkMatureDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpkOpenDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbbDue.DisplayMember.ToString() != "")
            {
                int i = 0;
                i = Convert.ToInt32(cbbDue.Text.ToString());
                DateTime date = Convert.ToDateTime(dtpkOpenDate.Text);
                date.AddMonths(i);
                dtpkMatureDate.Text = date.AddMonths(i).ToString();
            }                

        }


    }
}
