using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN
{
   public class BangThuePhong
    {
        int id_bang_thue_phong { get; set; }
        string id_Phong { get; set; }
        string id_Khach { get; set; }
        string Ngaydat { get; set; }
        string Check_in { get; set; }
        string Check_out { get; set; }
        int SoNgUOio { get; set; }
        int id_trangThai { get; set; }
        double TienCoc { get; set; }



        public BangThuePhong() { }

        public BangThuePhong(int id,string phong,string khach,string ngaydat, string checkin, string checkout,int songuoi,int trangthai,double coc) {
            id_bang_thue_phong = id;
            id_Phong = phong;
            id_Khach = khach;
            Ngaydat = ngaydat;
            Check_in = checkin;
            Check_out = checkout;
            SoNgUOio = songuoi;
            id_trangThai = trangthai;
            TienCoc = coc;
        }

        public double TinhTien(string tenloaiphong) {
            DateTime ngayin = DateTime.Parse(Check_in);
            DateTime ngayout = DateTime.Parse(Check_in);
            TimeSpan Time = ngayout - ngayin;
            int TongSoNgay = Time.Days;
            if (tenloaiphong == "PHÒNG ĐƠN")
            {
                return (TongSoNgay *300000) - TienCoc;
            }
            else if (tenloaiphong == "PHÒNG ĐÔI")
            {
                return (TongSoNgay * 500000) - TienCoc;
            }
            else
            {
                return (TongSoNgay * 12000000) - TienCoc;
            }
           
        }
    }
}
