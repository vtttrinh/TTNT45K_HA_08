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

namespace quanlydatphongkhachsan
{

    public partial class fThongTinKhachHang : Form
    {

        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fThongTinKhachHang()
        {
            InitializeComponent();
            Connection();
            fillToTable();
        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        public void fillToTable()
        {

            String sql = "SELECT * FROM KHACHHANG";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            listKhachHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["MaKhach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenKhachHang"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Email"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["SoDienThoai"].ToString());
                if (dt.Rows[i]["GioiTinh"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Nữ");
                }
                else
                {
                    lvi.SubItems.Add("Nam");
                }
                listKhachHang.Items.Add(lvi);

            }

        }

        public void FindByName(String tenKhachHang)
        {
            String sql = "SELECT * FROM KHACHHANG WHERE TenKhachHang LIKE '%" + tenKhachHang + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên khách hàng không tồn tại!", "Thông báo");
                fillToTable();
                return;
            }

            listKhachHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["MaKhach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenKhachHang"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Email"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["SoDienThoai"].ToString());
                if (dt.Rows[i]["GioiTinh"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Nữ");
                }
                else
                {
                    lvi.SubItems.Add("Nam");
                }
                listKhachHang.Items.Add(lvi);

            }

        }

        public void FindById(String maKhachHang)
        {
            String sql = "SELECT * FROM KHACHHANG WHERE MaKhach = '" + maKhachHang + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            txtMaKhach.Text = dt.Rows[0]["MaKhach"].ToString();
            txtTenKhachHang.Text = dt.Rows[0]["TenKhachHang"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();

            if (dt.Rows[0]["GioiTinh"].ToString().Equals("False"))
            {
                rdoFemale.Checked = true;
            }
            else
            {
                rdoNam.Checked = true;
            }

        }

        public bool CheckMaKhachHang(String maKhachHang)
        {
            String sql = "SELECT * FROM KHACHHANG WHERE MaKhach = '" + maKhachHang + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            if (dt.Rows.Count != 0)
            {
                return true;
            }

            return false;

        }

        public void update(String maDonDatPhong)
        {
            Connection();
            int gioiTinh = 0;
            if (rdoNam.Checked)
            {
                gioiTinh = 1;
            }
            String sql = "UPDATE KHACHHANG SET TenKhachHang = N'" + txtTenKhachHang.Text + "',DiaChi = N'" + txtDiaChi.Text + "',Email = '" + txtEmail.Text +
                "',SoDienThoai = '" + txtSoDienThoai.Text + "',GioiTinh = " + gioiTinh + " WHERE MaKhach = '" + txtMaKhach.Text + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            MessageBox.Show("Cập nhật thành công", "Thông báo");

        }

        public void delete(String maKhachHang)
        {
            Connection();
            String sql = "DELETE FROM KHACHHANG WHERE MaKhach = '" + maKhachHang + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            MessageBox.Show("Đã xóa thành công", "Thông báo");

        }

        public void clearForm()
        {
            txtMaKhach.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            rdoFemale.Checked = true;
        }

        /** 
         * Find KhachHang By MaKhach
         */
        public bool FindKhachHangByMaKhach(string maKhach)
        {
            Connection();

            String sql = "SELECT * FROM KHACHHANG WHERE MaKhach = '" + maKhach + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Data có tồn tại?
            if (dt.Rows.Count != 0)
            {
                return true;
            }

            return false;

        }

        private void listKhachHang_Click(object sender, EventArgs e)
        {
            if (listKhachHang.SelectedItems.Count >= 1)
            {
                ListViewItem item = listKhachHang.SelectedItems[0];
                FindById(item.Text);
            }
        }

        private void btTimFthongtinkhachhang_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTimKiemKhachHang.Text;

            if (tenKhachHang.Equals(""))
            {
                fillToTable();
            }
            else
            {
                FindByName(tenKhachHang);
            }
        }

        private void btThemFthongtinkhachhang_Click(object sender, EventArgs e)
        {
            fThemKhachHang fThemKhachHang = new fThemKhachHang();
            fThemKhachHang.ShowDialog();
        }

        private void btXoaFthongtinkhachhang_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKhach.Text;
            if (maKhachHang.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo");
            }
            else if (CheckMaKhachHang(maKhachHang))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    delete(maKhachHang);
                    fillToTable();
                    clearForm();
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo");
            }
        }

        private void btSuaFthongtinkhachhang_Click(object sender, EventArgs e)
        {
            string strMaKhach = txtMaKhach.Text;
            string strSoDienThoai = txtSoDienThoai.Text;
            int n;
            bool isNumeric = int.TryParse(strSoDienThoai, out n);

            // Kiểm tra rỗng
            if (strMaKhach == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo");
            }
            // Kiểm tra chuỗi max = 5
            else if (strMaKhach.Length > 5)
            {
                MessageBox.Show("Mã khách hàng phải nhỏ hơn 6 ký tự!", "Thông báo");
            }
            // Kiểm tra số điện thoại có phải là số?
            else if (!isNumeric && strSoDienThoai != "")
            {
                MessageBox.Show("Số điện thoại phải nhập số!", "Thông báo");
            }
            else if (CheckMaKhachHang(strMaKhach))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin khách hàng không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    update(strMaKhach);
                    fillToTable();
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo");
            }
        }

        private void fThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
