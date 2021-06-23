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
    public partial class fLogin : Form
    {
        //khai báo biến kết nối
        public SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fLogin()
        {
            InitializeComponent();
        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        public Boolean login()
        {
            Connection();

            // Kiểm tra xem có người dùng nào không
            String sql = "SELECT * FROM NGUOIDUNG WHERE TaiKhoan = '" + TB_user.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem sql có tồn tại bảng nào không?
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo");
                return false;
            }
            // Kiểm tra password
            else if (dt.Rows[0]["MatKhau"].ToString().Equals(TB_pass.Text)) 
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                return true;
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo");
                return false;
            }


        }
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if (login())
            {
                fGiaodienchinh f = new fGiaodienchinh();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
