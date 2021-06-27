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
    public partial class ThongKe : Form
    {
        SqlConnection conn;
        String constring = "Data Source=ADMIN;Initial Catalog=QUANLYDATPHONGKHACHSAN1;Integrated Security=True";

        public ThongKe()
        {
            InitializeComponent();

            cbbTime0.SelectedIndex = 0;
            cbbTime1.SelectedIndex = 0;
            
        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        public void getData(string date1, string date2, int cancelRoom)
        {
            Connection();
            String sql = "" +
                "SELECT MaDonDatPhong, TenPhong, TenKhachHang, NgayDatPhong, NgayDen, NgayDi, ThoiGianThue, TienPhong, HuyDon " +
                "  FROM DONDATPHONG " +
                "  JOIN KhachHang ON KhachHang.MaKhach = DONDATPHONG.MaKhach " +
                "  JOIN PHONG ON Phong.MaPhong = DONDATPHONG.MaPhong " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '"+ date2 +"') AND HuyDon = " + cancelRoom + " " +
                " GROUP BY MaDonDatPhong, TenPhong, TenKhachHang, NgayDatPhong, NgayDen, NgayDi, ThoiGianThue, TienPhong, HuyDon";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Set to details view.
            listDonDatHang.View = View.Details;
            listDonDatHang.Columns.Clear();
            listDonDatHang.Columns.Add("STT", 50, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Mã đơn đặt phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Tên phòng", 120, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Tên khách hàng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Ngày đặt phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Ngày đến", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Ngày đi", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Ngày thuê phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Tiền phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Hủy phòng", 150, HorizontalAlignment.Left);

            listDonDatHang.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Đổ dữ liệu ở đây từng hàng
                ListViewItem lvi = new ListViewItem(i + 1 + "");
                DateTime oDate1 = Convert.ToDateTime(dt.Rows[i]["NgayDatPhong"]);
                DateTime oDate2 = Convert.ToDateTime(dt.Rows[i]["NgayDen"]);
                DateTime oDate3 = Convert.ToDateTime(dt.Rows[i]["NgayDi"]);

                lvi.SubItems.Add(dt.Rows[i]["MaDonDatPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenKhachHang"].ToString());
                lvi.SubItems.Add(oDate1.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(oDate2.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(oDate3.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(dt.Rows[i]["ThoiGianThue"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TienPhong"].ToString());
                if (dt.Rows[i]["HuyDon"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Không");
                }
                else
                {
                    lvi.SubItems.Add("Đã hủy");
                }

                listDonDatHang.Items.Add(lvi);
            }
        }

        public void getSumData(string date1, string date2, int cancelRoom)
        {
            Connection();
            String sql = "" +
                "SELECT SUM(TienPhong) TongTienPhong, SUM(ThoiGianThue) TongThoiGian,HuyDon " +
                "  FROM DONDATPHONG " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '" + date2 + "') AND HuyDon = " + cancelRoom + " " +
                " GROUP BY HuyDon";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Set to details view.
            listDonDatHang.View = View.Details;
            listDonDatHang.Columns.Clear();
            listDonDatHang.Columns.Add("Tổng tiền phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Tổng thời gian thuê", 200, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Hủy phòng", 150, HorizontalAlignment.Left);

            listDonDatHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Đổ dữ liệu ở đây từng hàng
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["TongTienPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TongThoiGian"].ToString());
                if (dt.Rows[i]["HuyDon"].ToString().Equals("False"))
                {
                    lvi.SubItems.Add("Không");
                }
                else
                {
                    lvi.SubItems.Add("Đã hủy");
                }

                listDonDatHang.Items.Add(lvi);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTime_Click(object sender, EventArgs e)
        {
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cbbTime0.SelectedIndex;
            int intCancelRoom = 0;


            if (intSelectTime == 2)
            {
                strDate0 = dtpTime0.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime1.Value.ToString("yyyy-12-31");
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime0.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime1.Value.ToString("yyyy-MM-28");
            }
            else
            {
                strDate0 = dtpTime0.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime1.Value.ToString("yyyy-MM-dd");
            }

            if (ckbHuyPhong0.Checked.ToString() == "False")
            {
                intCancelRoom = 0;
            }
            else {
                intCancelRoom = 1;
            }

            getData(strDate0, strDate1, intCancelRoom);
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cbbTime1.SelectedIndex;
            int intCancelRoom = 1;


            if (intSelectTime == 2)
            {
                strDate0 = dtpTime2.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime3.Value.ToString("yyyy-12-31");
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime2.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime3.Value.ToString("yyyy-MM-28");
            }
            else
            {
                strDate0 = dtpTime2.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime3.Value.ToString("yyyy-MM-31");
            }

            if (ckbHuyPhong0.Checked.ToString() == "False")
            {
                intCancelRoom = 0;
            }
            else
            {
                intCancelRoom = 1;
            }

            getSumData(strDate0, strDate1, intCancelRoom);
        }
    }
}
