using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
v
namespace quanlydatphongkhachsan
{
    public partial class fThemDonDatPhong : Form
    {

        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public fThemDonDatPhong()
        {
            InitializeComponent();
        }
        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        /**
         * Thêm đơn đặt phòng vào Database
         */
        public void insert()
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();
            int intHuyDon = 0;
            if (tbHuydon.Text.Equals("Đã hủy"))
            {
                intHuyDon = 1;
            }

            String sql = "INSERT INTO DONDATPHONG (MaDonDatPhong,MaPhong,MaKhach,NgayDatPhong,NgayDen,NgayDi,HuyDon,ThoiGianThue,TienPhong,ConLai) VALUES ('" + tbMadondatphong.Text + "','" + tbMaphong.Text + "','" + tbMakhach.Text + "','" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "','" + dateTimePicker3.Value + "'," + intHuyDon +
                 ",'" + tbThoigianthue.Text + "','" + tbTienphong.Text + "','" + tbConlai.Text + "')";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            MessageBox.Show("Thêm đơn đặt phòng thành công", "Thông báo");

        }

        /**
         * Kiểm tra dữ liệu nhập vào 
         * @params Mã phòng và mã khách
         */
        private string checkData(string maPhong, string maKhach)
        {
            // Kết nối cơ sở dữ liệu (Database)
            Connection();

            String sql = "SELECT KH.MaKhach FROM KHACHHANG AS KH, PHONG AS PH WHERE PH.MaPhong = '" + maPhong + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Kiểm tra xem mã phòng có tồn tại
            if (dt.Rows.Count == 0)
            {
                return "Mã phòng không tồn tại!";
            }
            else {
                // Lặp danh sách
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Kiểm tra danh sách có chứa MaKhach
                    if (dt.Rows[i]["MaKhach"].ToString() == maKhach)
                    {
                        return "";
                    }
                }
            }

            return "Mã khách không tồn tại!";
        }

        /**
         * Check mã đơn đặt phòng
         */
        public bool CheckMa(String maDonDatPhong)
        {
            String sql = "SELECT * FROM DONDATPHONG WHERE MaDonDatPhong = '" + maDonDatPhong + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Data có tồn tại?
            if (dt.Rows.Count == 0)
            {
                return false;
            }

            return true;

        }        

        private void btThemFthemdondatphong_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm đơn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo);

            // Nếu chọn YES
            if (dialogResult == DialogResult.Yes)
            {
                string strMaDonDatPhong = tbMadondatphong.Text;
                string strMaPhong = tbMaphong.Text;
                string strMaKhach = tbMakhach.Text;
                string strError = checkData(strMaPhong, strMaKhach);

                if (CheckMa(strMaDonDatPhong) == true) 
                {
                    MessageBox.Show("Mã đơn đặt phòng đã tồn tại", "Thông báo");
                }
                // Kiểm tra thôgn báo có tồn tại?
                else if (strError == "")
                {
                    insert();
                }
                else {
                    MessageBox.Show(strError, "Thông báo");
                }
            }

        }
    }
}
