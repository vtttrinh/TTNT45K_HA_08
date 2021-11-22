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
using quanlydatphongkhachsan.Properties;

namespace quanlydatphongkhachsan
{
    public partial class ThongKe : Form
    {
        SqlConnection conn;
        String constring = Settings.Default["QUANLYDATPHONGKHACHSAN1ConnectionString"].ToString();
        string sortCustomer = "DESC";

        public ThongKe()
        {
            InitializeComponent();

            cbbTime0.SelectedIndex = 0;
            cbbTime1.SelectedIndex = 0;
            cboTimeKH.SelectedIndex = 0;
            cboTypeKH.SelectedIndex = 0;
            cboTopKH.SelectedIndex = 3;

        }

        public void Connection()
        {
            //thực hiện kết nối với sql
            conn = new SqlConnection(constring);
        }

        public void getData(string date1, string date2, int cancelRoom)
        {
            Connection();

            string huyPhong = "";
            if (cancelRoom == 1)
            {
                huyPhong = "AND HuyDon = 1";
            }
            else if (cancelRoom == 2)
            {
                huyPhong = "AND HuyDon = 0";
            }

            String sql = "" +
                "SELECT MaDonDatPhong, TenPhong, TenKhachHang, NgayDatPhong, NgayDen, NgayDi, ThoiGianThue, TienPhong, HuyDon " +
                "  FROM DONDATPHONG " +
                "  JOIN KhachHang ON KhachHang.MaKhach = DONDATPHONG.MaKhach " +
                "  JOIN PHONG ON Phong.MaPhong = DONDATPHONG.MaPhong " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '" + date2 + "') " + huyPhong + " " +
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
            listDonDatHang.FullRowSelect = true;
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

        public void getSumData(string date1, string date2)
        {
            Connection();

            String sql = "" +
                "SELECT SUM(TienPhong) TongTienPhong, SUM(ThoiGianThue) TongThoiGian,HuyDon                   " +
                "  FROM DONDATPHONG                                                                           " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '" + date2 + "') AND HuyDon = 0                  " +
                " GROUP BY HuyDon                                                                             ";
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
            listDonDatHang.Columns.Add("Từ ngày", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Đến ngày", 150, HorizontalAlignment.Left);
            listDonDatHang.Items.Clear();
            listDonDatHang.FullRowSelect = true;

            if (dt.Rows.Count == 0) { 
                ListViewItem lviNull = new ListViewItem("Không có dữ liệu.");                
                listDonDatHang.Items.Add(lviNull);
                return;
            }
            // Đổ dữ liệu ở đây từng hàng
            ListViewItem lvi = new ListViewItem(dt.Rows[0]["TongTienPhong"].ToString());
            lvi.SubItems.Add(dt.Rows[0]["TongThoiGian"].ToString());
            lvi.SubItems.Add("Chưa hủy");
            lvi.SubItems.Add(dtpTime2.Value.ToString("dd/MM/yyyy"));
            lvi.SubItems.Add(dtpTime3.Value.ToString("dd/MM/yyyy"));

            listDonDatHang.Items.Add(lvi);
        }

        public void getSumDataAll(string date1, string date2)
        {
            Connection();

            String sql = "" +
                "SELECT SUM(TienPhong) TongTienPhong, SUM(ThoiGianThue) TongThoiGian,HuyDon                   " +
                "  FROM DONDATPHONG                                                                           " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '" + date2 + "')                                 " +
                " GROUP BY HuyDon                                                                             ";
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
            listDonDatHang.Columns.Add("Tổng tiền đặt cọc", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Hủy phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Từ ngày", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Đến ngày", 150, HorizontalAlignment.Left);
            listDonDatHang.Items.Clear();
            listDonDatHang.FullRowSelect = true;

            if (dt.Rows.Count != 0)
            {
               
            
            // Đổ dữ liệu ở đây từng hàng
            ListViewItem lvi = new ListViewItem(dt.Rows[0]["TongTienPhong"].ToString());
            lvi.SubItems.Add(dt.Rows[0]["TongThoiGian"].ToString());
            lvi.SubItems.Add("");
            lvi.SubItems.Add("Chưa hủy");
            lvi.SubItems.Add(dtpTime2.Value.ToString("dd/MM/yyyy"));
            lvi.SubItems.Add(dtpTime3.Value.ToString("dd/MM/yyyy"));

            listDonDatHang.Items.Add(lvi);
            }
            String sql2 = "" +
                "SELECT SUM(DatCoc) TongTienDatCoc                                                            " +
                "  FROM DONDATPHONG                                                                           " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '" + date2 + "') AND HuyDon = 1                  " +
                " GROUP BY HuyDon                                                                             ";
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);

            conn.Open();
            da2.Fill(dt2);
            da2.Dispose();
            conn.Close();

            if (dt2.Rows.Count != 0)
            {
                
            // Đổ dữ liệu ở đây từng hàng
            ListViewItem lvi2 = new ListViewItem("");
            lvi2.SubItems.Add("");
            lvi2.SubItems.Add(dt2.Rows[0]["TongTienDatCoc"].ToString());
            lvi2.SubItems.Add("Đã hủy");
            lvi2.SubItems.Add(dtpTime2.Value.ToString("dd/MM/yyyy"));
            lvi2.SubItems.Add(dtpTime3.Value.ToString("dd/MM/yyyy"));

            listDonDatHang.Items.Add(lvi2); 
            }
        }

        public void getSumDataHuyPhong(string date1, string date2)
        {
            Connection();

            String sql = "" +
                "SELECT SUM(DatCoc) TongTienDatCoc, HuyDon                                                    " +
                "  FROM DONDATPHONG                                                                           " +
                " WHERE (NgayDen BETWEEN '" + date1 + "' AND '" + date2 + "') AND HuyDon = 1                  " +
                " GROUP BY HuyDon                                                                             ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Set to details view.
            listDonDatHang.View = View.Details;
            listDonDatHang.Columns.Clear();
            listDonDatHang.Columns.Add("Tổng tiền đặt cọc", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Hủy phòng", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Từ ngày", 150, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Đến ngày", 150, HorizontalAlignment.Left);
            listDonDatHang.Items.Clear();
            listDonDatHang.FullRowSelect = true;

            if (dt.Rows.Count == 0)
            {
                ListViewItem lviNull = new ListViewItem("Không có dữ liệu.");
                listDonDatHang.Items.Add(lviNull);
                return;
            }
            // Đổ dữ liệu ở đây từng hàng
            ListViewItem lvi = new ListViewItem(dt.Rows[0]["TongTienDatCoc"].ToString());
            lvi.SubItems.Add("Đã hủy");
            lvi.SubItems.Add(dtpTime2.Value.ToString("dd/MM/yyyy"));
            lvi.SubItems.Add(dtpTime3.Value.ToString("dd/MM/yyyy"));

            listDonDatHang.Items.Add(lvi);
        }

        

        public void getRoom()
        {
            Connection();
            String sql = "" +
                " SELECT                                                        " +
                " 	     TOP 5 PHONG.TenPhong,                                  " +
                " 	     LOAIPHONG.LoaiPhong,                                   " +
                " 	     COUNT(DONDATPHONG.MaPhong) TongSoPhong                 " +
                "   FROM DONDATPHONG                                            " +
                "   JOIN PHONG ON PHONG.MaPhong = DONDATPHONG.MaPhong           " +
                "   JOIN LOAIPHONG ON LOAIPHONG.MaLoaiPhong = PHONG.MaLoaiPhong " +
                "  WHERE DONDATPHONG.HuyDon = 0                                 " +
                "  GROUP BY PHONG.TenPhong, LOAIPHONG.LoaiPhong                 " +
                "  ORDER BY TongSoPhong DESC                                    ";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Set to details view.
            listDonDatHang.View = View.Details;
            listDonDatHang.Columns.Clear();
            listDonDatHang.Columns.Add("Tên phòng", 200, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Loại phòng", 200, HorizontalAlignment.Left);
            listDonDatHang.Columns.Add("Tổng số phòng", 150, HorizontalAlignment.Left);

            listDonDatHang.Items.Clear();
            listDonDatHang.FullRowSelect = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Đổ dữ liệu ở đây từng hàng
                ListViewItem lvi = new ListViewItem(dt.Rows[i]["TenPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["LoaiPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TongSoPhong"].ToString());

                listDonDatHang.Items.Add(lvi);
            }
        }

        public void getKhachHangByTime(string date1, string date2, int cancelRoom, string typeSort, string typeLimit)
        {

            Connection();

            string huyPhong = "";
            if (cancelRoom == 1) { 
            huyPhong = "AND DD.HuyDon = 1";
            }
            else if (cancelRoom == 2) {
                huyPhong = "AND DD.HuyDon = 0"; 
            }

            String sql = "";
            sql += " SELECT                                                             ";
            sql += "	    " + typeLimit + " KH.TenKhachHang,                          ";
            sql += "	    COUNT(DD.MaKhach) TongSoPhong,                              ";
            sql += "		KH.GioiTinh,                                                ";
            sql += " 	    SUM(DD.TienPhong) TongSoTien,                               ";
            sql += " 	    SUM(DD.ThoiGianThue) TongThoiGian                           ";
            sql += "   FROM DONDATPHONG DD                                              ";
            sql += "   JOIN KHACHHANG KH ON KH.MaKhach = DD.MaKhach                     ";
            sql += "  WHERE (DD.NgayDi BETWEEN '" + date1 + "' AND '" + date2 + "')     ";
            sql += "        " + huyPhong + "                                            ";
            sql += "  GROUP BY KH.TenKhachHang, KH.GioiTinh                             ";
            sql += "  ORDER BY " + typeSort + " " + sortCustomer + "                    ";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            conn.Open();
            da.Fill(dt);
            da.Dispose();
            conn.Close();

            // Set to details view.
            listKhachHang.View = View.Details;
            listKhachHang.Columns.Clear();
            listKhachHang.Columns.Add("STT", 50, HorizontalAlignment.Left);
            listKhachHang.Columns.Add("Tên khách hàng", 150, HorizontalAlignment.Left);
            listKhachHang.Columns.Add("Giới tính", 100, HorizontalAlignment.Left);
            listKhachHang.Columns.Add("Tổng số phòng thuê", 150, HorizontalAlignment.Left);
            listKhachHang.Columns.Add("Tổng tiền tiền thuê", 150, HorizontalAlignment.Left);
            listKhachHang.Columns.Add("Tổng thời gian thuê", 200, HorizontalAlignment.Left);

            listKhachHang.Items.Clear();
            listKhachHang.FullRowSelect = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Đổ dữ liệu ở đây từng hàng
                ListViewItem lvi = new ListViewItem(i + 1 + "");
                lvi.SubItems.Add(dt.Rows[i]["TenKhachHang"].ToString());
                if (dt.Rows[i]["GioiTinh"].ToString().Equals("True"))
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(dt.Rows[i]["TongSoPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TongSoTien"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TongThoiGian"].ToString());

                listKhachHang.Items.Add(lvi);
            }
        }

        /**
         * 
         * Lấy ngày trong tháng, năm
         * 
         * @param DateTimePicker date
         * 
         */
        private int GetDayOfMonth(DateTimePicker date)
        {
            // This duj date = "06/28/2020"

            // Lấy năm trong date (ngày tháng năm)
            int intYear = int.Parse(date.Value.ToString("yyyy"));

            // Lấy tháng trong date (ngày tháng năm)
            int intMonth = int.Parse(date.Value.ToString("MM"));

            // Lấy ngày trong tháng và năm và return lại
            return DateTime.DaysInMonth(intYear, intMonth);

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
            int dayInMonth = GetDayOfMonth(dtpTime3);


            if (intSelectTime == 2)
            {
                strDate0 = dtpTime0.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime1.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime0.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime1.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime0.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime1.Value.ToString("yyyy-MM-dd");
            }

            if (ckbHuyPhong0.Checked.ToString() == "True" && cbbKhongHuyPhong.Checked.ToString() == "False")
            {
                intCancelRoom = 1;
            }
            else if (ckbHuyPhong0.Checked.ToString() == "False" && cbbKhongHuyPhong.Checked.ToString() == "True")
            {
                intCancelRoom = 2;
            }

            getData(strDate0, strDate1, intCancelRoom);
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cbbTime1.SelectedIndex;
            int dayInMonth = GetDayOfMonth(dtpTime3);

            if (intSelectTime == 2)
            {
                strDate0 = dtpTime2.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime3.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime2.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime3.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime2.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime3.Value.ToString("yyyy-MM-dd");
            }


            if (ckbHuyPhong1.Checked.ToString() == "True" && cbbKhongHuyPhongTime.Checked.ToString() == "False")
            {
                getSumDataHuyPhong(strDate0, strDate1);
            }
            else if (ckbHuyPhong1.Checked.ToString() == "False" && cbbKhongHuyPhongTime.Checked.ToString() == "True")
            {
                getSumData(strDate0, strDate1);
            }
            else {
                getSumDataAll(strDate0, strDate1);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            getRoom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortCustomer = "DESC";
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cboTimeKH.SelectedIndex;
            int intCancelRoom = 0;
            int dayInMonth = GetDayOfMonth(dtpTime5);
            string typeSort = "TongSoPhong";
            string typeLimit = "";

            if (intSelectTime == 2)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime5.Value.ToString("yyyy-MM-dd");
            }

            if (ckbCancelRoomKH.Checked.ToString() == "False" && ckbChuaHuy.Checked.ToString() == "True")
            {
                intCancelRoom = 2;
            }
            else if (ckbCancelRoomKH.Checked.ToString() == "True" && ckbChuaHuy.Checked.ToString() == "False")
            {
                intCancelRoom = 1;
            }

            if (cboTypeKH.SelectedIndex == 1)
            {
                typeSort = "TongSoTien";
            }
            else if (cboTypeKH.SelectedIndex == 2)
            {
                typeSort = "TongThoiGian";
            }

            if (cboTopKH.SelectedIndex == 0)
            {
                typeLimit = "TOP 5";
            }
            else if (cboTopKH.SelectedIndex == 1)
            {
                typeLimit = "TOP 10";
            }
            else if (cboTopKH.SelectedIndex == 2)
            {
                typeLimit = "TOP 20";
            }

            getKhachHangByTime(strDate0, strDate1, intCancelRoom, typeSort, typeLimit);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sortCustomer = "ASC";
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cboTimeKH.SelectedIndex;
            int intCancelRoom = 0;
            int dayInMonth = GetDayOfMonth(dtpTime5);
            string typeSort = "TongSoPhong";
            string typeLimit = "";

            if (intSelectTime == 2)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime5.Value.ToString("yyyy-MM-dd");
            }

            if (ckbCancelRoomKH.Checked.ToString() == "False" && ckbChuaHuy.Checked.ToString() == "True")
            {
                intCancelRoom = 2;
            }
            else if (ckbCancelRoomKH.Checked.ToString() == "True" && ckbChuaHuy.Checked.ToString() == "False")
            {
                intCancelRoom = 1;
            }

            if (cboTypeKH.SelectedIndex == 1)
            {
                typeSort = "TongSoTien";
            }
            else if (cboTypeKH.SelectedIndex == 2)
            {
                typeSort = "TongThoiGian";
            }

            if (cboTopKH.SelectedIndex == 0)
            {
                typeLimit = "TOP 5";
            }
            else if (cboTopKH.SelectedIndex == 1)
            {
                typeLimit = "TOP 10";
            }
            else if (cboTopKH.SelectedIndex == 2)
            {
                typeLimit = "TOP 20";
            }

            getKhachHangByTime(strDate0, strDate1, intCancelRoom, typeSort, typeLimit);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sortCustomer = "DESC";
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cboTimeKH.SelectedIndex;
            int intCancelRoom = 0;
            int dayInMonth = GetDayOfMonth(dtpTime5);
            string typeSort = "TongSoPhong";
            string typeLimit = "";

            if (intSelectTime == 2)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime5.Value.ToString("yyyy-MM-dd");
            }

            if (ckbCancelRoomKH.Checked.ToString() == "False" && ckbChuaHuy.Checked.ToString() == "True")
            {
                intCancelRoom = 2;
            }
            else if (ckbCancelRoomKH.Checked.ToString() == "True" && ckbChuaHuy.Checked.ToString() == "False")
            {
                intCancelRoom = 1;
            }

            if (cboTypeKH.SelectedIndex == 1)
            {
                typeSort = "TongSoTien";
            }
            else if (cboTypeKH.SelectedIndex == 2)
            {
                typeSort = "TongThoiGian";
            }

            if (cboTopKH.SelectedIndex == 0)
            {
                typeLimit = "TOP 5";
            }
            else if (cboTopKH.SelectedIndex == 1)
            {
                typeLimit = "TOP 10";
            }
            else if (cboTopKH.SelectedIndex == 2)
            {
                typeLimit = "TOP 20";
            }

            getKhachHangByTime(strDate0, strDate1, intCancelRoom, typeSort, typeLimit);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sortCustomer = "DESC";
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cboTimeKH.SelectedIndex;
            int intCancelRoom = 0;
            int dayInMonth = GetDayOfMonth(dtpTime5);
            string typeSort = "TongSoPhong";
            string typeLimit = "";

            if (intSelectTime == 2)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime5.Value.ToString("yyyy-MM-dd");
            }

            if (ckbCancelRoomKH.Checked.ToString() == "False" && ckbChuaHuy.Checked.ToString() == "True")
            {
                intCancelRoom = 2;
            }
            else if (ckbCancelRoomKH.Checked.ToString() == "True" && ckbChuaHuy.Checked.ToString() == "False")
            {
                intCancelRoom = 1;
            }

            if (cboTypeKH.SelectedIndex == 1)
            {
                typeSort = "TongSoTien";
            }
            else if (cboTypeKH.SelectedIndex == 2)
            {
                typeSort = "TongThoiGian";
            }

            if (cboTopKH.SelectedIndex == 0)
            {
                typeLimit = "TOP 5";
            }
            else if (cboTopKH.SelectedIndex == 1)
            {
                typeLimit = "TOP 10";
            }
            else if (cboTopKH.SelectedIndex == 2)
            {
                typeLimit = "TOP 20";
            }

            getKhachHangByTime(strDate0, strDate1, intCancelRoom, typeSort, typeLimit);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sortCustomer = "DESC";
            string strDate0 = "";
            string strDate1 = "";
            int intSelectTime = cboTimeKH.SelectedIndex;
            int intCancelRoom = 1;
            int dayInMonth = GetDayOfMonth(dtpTime5);
            string typeSort = "TongSoPhong";
            string typeLimit = "";

            if (intSelectTime == 2)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-01-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-12-" + dayInMonth));
            }
            else if (intSelectTime == 1)
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-01");
                strDate1 = dtpTime5.Value.ToString(("yyyy-MM-" + dayInMonth));
            }
            else
            {
                strDate0 = dtpTime4.Value.ToString("yyyy-MM-dd");
                strDate1 = dtpTime5.Value.ToString("yyyy-MM-dd");
            }

            if (ckbCancelRoomKH.Checked.ToString() == "False")
            {
                intCancelRoom = 0;
            }

            if (cboTypeKH.SelectedIndex == 1)
            {
                typeSort = "TongSoTien";
            }
            else if (cboTypeKH.SelectedIndex == 2)
            {
                typeSort = "TongThoiGian";
            }

            if (cboTopKH.SelectedIndex == 0)
            {
                typeLimit = "TOP 5";
            }
            else if (cboTopKH.SelectedIndex == 1)
            {
                typeLimit = "TOP 10";
            }
            else if (cboTopKH.SelectedIndex == 2)
            {
                typeLimit = "TOP 20";
            }

            getKhachHangByTime(strDate0, strDate1, intCancelRoom, typeSort, typeLimit);
        }
    }
}
