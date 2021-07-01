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
    public partial class fThemKhachHang : Form
    {
        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fThemKhachHang()
        {
            InitializeComponent();
            Connection();
        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        /**
         * Thêm khách hàng vào DB
         */
        public void insert()
        {
            Connection();

            // Set giới tính
            int gioiTinh = 0;
            if (rdoNam.Checked)
            {
                gioiTinh = 1;
            }

            String sql = "INSERT INTO KHACHHANG (MaKhach,TenKhachHang,DiaChi,Email,SoDienThoai,GioiTinh)" +
                " VALUES ('" + txtMaKhach.Text + "',N'" + txtTenKhachHang.Text + "',N'" + txtDiaChi.Text + "','" + txtEmail.Text + "'," +
                txtSoDienThoai.Text + "," + gioiTinh + ")";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

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

        private void btThemFthemkhachhang_Click(object sender, EventArgs e)
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
            // Kiểm tra mã khách có tồn tịa
            else if (!FindKhachHangByMaKhach(strMaKhach))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm khách hàng không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    insert();
                    this.Close();
                }

            }
            // Báo lỗi
            else
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo");
            }

        }

        private void lbGioitinh_Click(object sender, EventArgs e)
        {

        }
    }
}
