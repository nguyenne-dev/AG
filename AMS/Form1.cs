using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AMS
{
    public partial class AMS : Form
    {
        private DataProvider dataProvider = new DataProvider();

        public AMS()
        {
            InitializeComponent();
            loaddgTaiKhoan();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblTime.Visible = true;
        }

        private void loaddgTaiKhoan()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT ma_tai_khoan as [Mã], ");
            query.Append("tai_khoan as [Tài Khoản], ");
            query.Append("mat_khau as [Mật Khẩu], ");
            query.Append("email as [Email], ");
            query.Append("so_huu as [Sở Hữu], ");
            query.Append("trang_thai as [TT] ");
            query.Append("FROM tbl_acc_sell");
            dt = dataProvider.execQuery(query.ToString());
            dgTaiKhoan.DataSource = dt;
            dgTaiKhoan.Columns["Mã"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgTaiKhoan.Columns["Mã"].Width = 70;

            dgTaiKhoan.Columns["TT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgTaiKhoan.Columns["TT"].Width = 70;

            dgTaiKhoan.Columns["Tài Khoản"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgTaiKhoan.Columns["Tài Khoản"].Width = 150;

            // Xóa các cột button cũ nếu có
            dgTaiKhoan.Columns.OfType<DataGridViewButtonColumn>()
                .Where(c => c.Name == "btnChua" || c.Name == "btnDang" || c.Name == "btnXong")
                .ToList().ForEach(c => dgTaiKhoan.Columns.Remove(c));

            // Thêm cột nút "Chưa"
            DataGridViewButtonColumn btnChua = new DataGridViewButtonColumn();
            btnChua.Name = "btnChua";
            btnChua.HeaderText = "Chưa";
            btnChua.Text = "Chưa";
            btnChua.UseColumnTextForButtonValue = true;
            btnChua.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnChua.Width = 70;
            dgTaiKhoan.Columns.Add(btnChua);

            // Thêm cột nút "Đang"
            DataGridViewButtonColumn btnDang = new DataGridViewButtonColumn();
            btnDang.Name = "btnDang";
            btnDang.HeaderText = "Đang";
            btnDang.Text = "Đang";
            btnDang.UseColumnTextForButtonValue = true;
            btnDang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnDang.Width = 70;
            dgTaiKhoan.Columns.Add(btnDang);

            // Thêm cột nút "Xong"
            DataGridViewButtonColumn btnXong = new DataGridViewButtonColumn();
            btnXong.Name = "btnXong";
            btnXong.HeaderText = "Xong";
            btnXong.Text = "Xong";
            btnXong.UseColumnTextForButtonValue = true;
            btnXong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnXong.Width = 70;
            dgTaiKhoan.Columns.Add(btnXong);
        }

        private void dgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            DataGridViewRow row = dgTaiKhoan.Rows[e.RowIndex];
            string maTK = row.Cells["Mã"].Value.ToString();

            txtMa.Text = row.Cells["Mã"].Value.ToString();
            txtTaiKhoan.Text = row.Cells["Tài Khoản"].Value.ToString();
            txtMatKhau.Text = row.Cells["Mật Khẩu"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtSoHuu.Text = row.Cells["Sở Hữu"].Value.ToString();

            string columnName = dgTaiKhoan.Columns[e.ColumnIndex].Name;

            if (columnName == "btnChua")
            {
                updateTrangThai(maTK, 0);
            }
            else if (columnName == "btnDang")
            {
                updateTrangThai(maTK, 1);
            }
            else if (columnName == "btnXong")
            {
                updateTrangThai(maTK, 2);
            }
        }

        private void updateTrangThai(string maTaiKhoan, int trangThai)
        {
            string query = $"UPDATE tbl_acc_sell SET trang_thai = {trangThai} WHERE ma_tai_khoan = N'{maTaiKhoan}'";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loaddgTaiKhoan();
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTaiKhoan.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtSoHuu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO tbl_acc_sell (ma_tai_khoan, tai_khoan, mat_khau, email, so_huu, trang_thai) VALUES " +
                           $"(N'{txtMa.Text}', N'{txtTaiKhoan.Text}', N'{txtMatKhau.Text}', N'{txtEmail.Text}', N'{txtSoHuu.Text}', 0)";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loaddgTaiKhoan();
                MessageBox.Show("Thêm thông tin thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thông tin không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTaiKhoan.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtSoHuu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"UPDATE tbl_acc_sell SET tai_khoan = N'{txtTaiKhoan.Text}', mat_khau = N'{txtMatKhau.Text}', email = N'{txtEmail.Text}', so_huu = N'{txtSoHuu.Text}' WHERE ma_tai_khoan = N'{txtMa.Text}'";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loaddgTaiKhoan();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng điền mã tài khoản để xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"DELETE FROM tbl_acc_sell WHERE ma_tai_khoan = N'{txtMa.Text}'";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loaddgTaiKhoan();
                MessageBox.Show("Xóa thông tin thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xóa thông tin không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
