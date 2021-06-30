using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DO_AN
{
    public class XuLy:Ket_Noi_SQL
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QL_KHACHSAN;User ID=sa;Password=sa2012");
        DataSet data = new DataSet();
        
        DataSet Login = new DataSet();
        DataSet BangThue = new DataSet();
        DataSet HoaDon = new DataSet();
        SqlDataAdapter da_BangThuePhong, da_BangThuePhong_2, da_Them_Hoa_Don, da_Xoa_HOADON;
        SqlDataAdapter da_Them_Dich_Vu, da_PhongVatTu, da_NguoiOCung;
        SqlDataAdapter da_Khach, da_DV, da_CSVC, da_NV, da_User, da_NguoiOCungg;
       
        public XuLy()
        {
            
            Load_Login();
            Load_BangThuePhong();
            Load_SuDungDichVu();
            Load_PhongVatTu();
            Load_HoaDonThu();
            Load_BangThuePhong_2();
            Load_NguoiOCung();
            Load_Xoa_HOADON();
            Load_HoaDonThu();
            Load_Khach();
            Load_NhanVien();
            Load_User();
            Load_NguoiOCung();
        }

        public bool AllowDBNull { get; set; }
        //-----------
        //public bool KTKN()
        //{


        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();

        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        throw;
        //    }
        //}
        //==========
        public double Tinh_Tien_Phong(string a, string c_in, string c_out, string coc)
        {
            DateTime ngayin = DateTime.Parse(c_in);
            DateTime ngayout = DateTime.Parse(c_out);
            TimeSpan Time = ngayout - ngayin;
            int TongSoNgay = Time.Days;
            if (a == "PHONG001")
            {
                return (TongSoNgay * 300000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG002")
            {
                return (TongSoNgay * 300000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG003")
            {
                return (TongSoNgay * 500000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG004")
            {
                return (TongSoNgay * 500000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG005")
            {
                return (TongSoNgay * 500000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG006")
            {
                return (TongSoNgay * 500000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG007")
            {
                return (TongSoNgay * 1200000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG008")
            {
                return (TongSoNgay * 1200000) - double.Parse(coc.ToString());
            }
            else if (a == "PHONG009")
            {
                return (TongSoNgay * 1200000) - double.Parse(coc.ToString());
            }
            else
            {
                return (TongSoNgay * 1200000) - double.Parse(coc.ToString());
            }
          
        }
        //-------------------------------------------
        public DataTable Load_Login()
        {
            string caulenh = "Select * from Users";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(Login, "Login");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = Login.Tables["Login"].Columns[0];
            Login.Tables["Login"].PrimaryKey = khoachinh;
            return Login.Tables["Login"];
        }

        public bool KIEM_TRA_DANG_NHAP(string ten, string pass, string idnv)
        {
            DataRow dr = Login.Tables["Login"].Rows.Find(ten);
            if (dr == null)
            {
                return false;
            }
            else
            {
                if (dr["Pass"].ToString() != pass && dr["IDNhanVien"].ToString() != idnv)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        //------------------TIM CO SO VAT CHAT----------------------------
        public bool Them_Co_So_Vat_Chat(string id_Phong, string id_CSVC)
        {
            try
            {

                //int a1 = Int32.Parse(id.ToString());
                string caulenh = "select IDPhong,IDCoSoVatChat from PhongVatTu";
                da_PhongVatTu = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["PhongVatTu"].NewRow();
                //dr["ID"] = a1 + 0;
                dr["IDPhong"] = id_Phong;
                dr["IDCoSoVatChat"] = id_CSVC;
                data.Tables["PhongVatTu"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_PhongVatTu);
                da_PhongVatTu.Update(data, "PhongVatTu");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Xoa_CSVC(string id)
        {
            try
            {



                DataRow dr = data.Tables["CoSoVatChat"].Rows.Find(id);

                dr.Delete();

                SqlCommandBuilder cb = new SqlCommandBuilder(da_CSVC);
                da_CSVC.Update(data, "CoSoVatChat");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Them_Co_So_Vat_Chat_2(string id_CSVC,string ten)
        {
            try
            {

              
                
                DataRow dr = data.Tables["CoSoVatChat"].NewRow();

                dr["ID_CO_SO_VAT_CHAT"] = id_CSVC;
                dr["Ten"] = ten;
                data.Tables["CoSoVatChat"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_CSVC);
                da_CSVC.Update(data, "CoSoVatChat");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Sua_Co_So_Vat_Chat_2(string id_CSVC, string ten)
        {
            try
            {



                DataRow dr = data.Tables["CoSoVatChat"].Rows.Find(id_CSVC);

                if (dr!=null)
                {
                    dr["Ten"] = ten;
                }
       
                SqlCommandBuilder cb = new SqlCommandBuilder(da_CSVC);
                da_CSVC.Update(data, "CoSoVatChat");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        //\\\\\\\\\\\\\\
        public bool Them_Khach(string id,string ten,string ns,string gt,string email, string sdt, string cmnd,string qt,string ghichu)
        {
            try
            {

               
              
                DataRow dr = data.Tables["Khach"].NewRow();

                dr["ID_KHACH"] = id;
                dr["Ten"] = ten;
                dr["NgaySinh"] = ns;
                dr["GioiTinh"] = gt;
                dr["Email"] = email;
                dr["SDT"] = sdt;
                dr["CMND"] = cmnd;
                dr["QuocTich"] = qt;
                if (ghichu== null)
                {
                    ghichu = " ";
                }
                else
                {
                    dr["GhiChu"] = ghichu;
                }
               
                data.Tables["Khach"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_Khach);
                da_Khach.Update(data, "Khach");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Xoa_Khach(string id)
        {
            try
            {



                DataRow dr = data.Tables["Khach"].Rows.Find(id);


                dr.Delete();
                SqlCommandBuilder cb = new SqlCommandBuilder(da_Khach);
                da_Khach.Update(data, "Khach");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Sua_Khach(string id, string ten, string ns, string gt, string email, string sdt, string cmnd, string qt, string ghichu)
        {
            try
            {



                DataRow dr = data.Tables["Khach"].Rows.Find(id);
                if (dr!=null)
                {
                   
                    dr["Ten"] = ten;
                    dr["NgaySinh"] = ns;
                    dr["GioiTinh"] = gt;
                    dr["Email"] = email;
                    dr["SDT"] = sdt;
                    dr["CMND"] = cmnd;
                    dr["QuocTich"] = qt;
                    if (ghichu == null)
                    {
                        ghichu = " ";
                    }
                    else
                    {
                        dr["GhiChu"] = ghichu;
                    }

                }
               
               
                SqlCommandBuilder cb = new SqlCommandBuilder(da_Khach);
                da_Khach.Update(data, "Khach");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    ///    \\\\\\//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_BTP"></param>
        /// <param name="idkahch"></param>
        /// <returns></returns>
        public bool Them_Nguoi_O_Cung(string id_BTP, string idkahch)
        {
            //try
            //{

                int a1 = Int32.Parse(id_BTP.ToString());
                string caulenh = "Select IDBangThuePhong,IDNguoiOCung From NguoiOCung";
                da_NguoiOCungg = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["NguoiOCung"].NewRow();

                dr["IDBangThuePhong"] = a1;
                dr["IDNguoiOCung"] = idkahch;
                data.Tables["NguoiOCung"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_NguoiOCungg);
                da_NguoiOCungg.Update(data, "NguoiOCung");
                return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //    throw;
            //}
        }
        //---KT_CHECK IN---
        public bool Check_In(string ma, string ngay)
        {
            try
            {
                string caulenh = "Select * From BangThuePhong";
                da_BangThuePhong = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["BangThuePhong"].Rows.Find(ma);
                if (dr != null)
                {
                    dr["CheckIn"] = ngay;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(da_BangThuePhong);
                da_BangThuePhong.Update(data, "BangThuePhong");

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Check_OUT(string ma, string ngay)
        {
            try
            {
                string caulenh = "Select * From BangThuePhong";
                da_BangThuePhong = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["BangThuePhong"].Rows.Find(ma);
                if (dr != null)
                {
                    dr["CheckOut"] = ngay;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(da_BangThuePhong);
                da_BangThuePhong.Update(data, "BangThuePhong");


                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Dat_Phong(string phong, string khach, string ngay_dat, string songuoi, string trangthai, string tiencoc)
        {
            try
            {
                string caulenh = "select IDPhong,IDKhacHang,NgayDat,SoLuongNguoiLon,IDTrangThai,TienCoc from BangThuePhong";
                da_BangThuePhong_2 = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["BangThuePhong_2"].NewRow();
                //int a = Int32.Parse(id.ToString());


                //dr["ID_BANG_THUE_PHONG"] = a+0;
                dr["IDPhong"] = phong;
                dr["IDKhacHang"] = khach;
                dr["NgayDat"] = ngay_dat;
                dr["SoLuongNguoiLon"] = songuoi;
                dr["IDTrangThai"] = trangthai;
                dr["TienCoc"] = tiencoc;

                data.Tables["BangThuePhong_2"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_BangThuePhong_2);
                da_BangThuePhong_2.Update(data, "BangThuePhong_2");


                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


        }
        //===========THEM HOA DON===
        public bool Them_Hoa_Don(string idnhanvien, string idkhach, string lydo, string ngaylap, double tongtien)
        {
            //try
            //{


            string caulenh = "select IDNhanVien,IDKhachHang,LyDo,NgayLapHoaDon,TongTien from HoaDonThu";
            da_Them_Hoa_Don = new SqlDataAdapter(caulenh, conn);
            DataRow dr = data.Tables["HoaDonThu"].NewRow();
            dr["IDNhanVien"] = idnhanvien;
            dr["IDKhachHang"] = idkhach;
            dr["LyDo"] = lydo;
            dr["NgayLapHoaDon"] = ngaylap;
            dr["TongTien"] = tongtien;
            data.Tables["HoaDonThu"].Rows.Add(dr);
            SqlCommandBuilder cb = new SqlCommandBuilder(da_Them_Hoa_Don);
            da_Them_Hoa_Don.Update(data, "HoaDonThu");
            return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //    throw;
            //}
        }
        //===========
        public bool Them_Dich_Vu(string id_BangThuePhong, string id_DichVu)
        {
            try
            {
                int a = int.Parse(id_BangThuePhong);
                int b = int.Parse(id_DichVu);

                string caulenh = "select IDBangThuePhong,IDDichVu from SuDungDichVu";
                da_Them_Dich_Vu = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["SuDungDichVu"].NewRow();

                dr["IDBangThuePhong"] = a;
                dr["IDDichVu"] = b;
                data.Tables["SuDungDichVu"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_Them_Dich_Vu);
                da_Them_Dich_Vu.Update(data, "SuDungDichVu");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        /// <summary>
        /// ////////
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Xoa_Dich_Vu(string id)
        {
            try
            {
                

                
                DataRow dr = data.Tables["DichVu"].Rows.Find(id);

                dr.Delete();
              
                SqlCommandBuilder cb = new SqlCommandBuilder(da_DV);
                da_DV.Update(data, "DichVu");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Them_Dich_Vu_DV(string id_DichVu,string ten,string gia)
        {
            try
            {
              
                int b = int.Parse(id_DichVu);

                
                DataRow dr = data.Tables["DichVu"].NewRow();

                
                dr["ID_Dich_Vu"] = b;
                dr["Ten"] =ten;
                dr["Gia"] = gia;
                data.Tables["DichVu"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_DV);
                da_DV.Update(data, "DichVu");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Sua_Dich_Vu_DV(string id_DichVu, string ten, string gia)
        {
            try
            {

                int b = int.Parse(id_DichVu);


                DataRow dr = data.Tables["DichVu"].Rows.Find(b);
                if (dr!=null)
                {
                    dr["Ten"] = ten;
                    dr["Gia"] = gia;
                }

              
                
             
                SqlCommandBuilder cb = new SqlCommandBuilder(da_DV);
                da_DV.Update(data, "DichVu");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        //------------------NHAN_VIEN-----------------------
        public bool Xoa_Nhan_Vien(string id)
        {
            try
            {



                DataRow dr = data.Tables["NhanVien"].Rows.Find(id);

                dr.Delete();

                SqlCommandBuilder cb = new SqlCommandBuilder(da_NV);
                da_NV.Update(data, "NhanVien");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Them_Nhan_Vien(string id,string ten,string ns,string gt,string dc,string sdt,string nvl,string Hinh) {
            DataRow dr = data.Tables["NhanVien"].NewRow();
          
            dr["ID"] = id;
            dr["Ten"] = ten;
            dr["NgaySinh"] = ns;
            dr["GioiTinh"] = gt;
            dr["DiaChi"] = dc;
            dr["SDT"] = sdt;
            dr["NgayVaoLam"] = nvl;
            if (Hinh==null)
            {
                Hinh = " ";
            }
      
            dr["Hinh"] = Hinh;
            data.Tables["NhanVien"].Rows.Add(dr);
            SqlCommandBuilder cb = new SqlCommandBuilder(da_NV);
            da_NV.Update(data,"NhanVien");
            return true;
        
        }
        public bool Sua_Nhan_Vien(string id, string ten, string ns, string gt, string dc, string sdt, string nvl, string Hinh)
        {
            DataRow dr = data.Tables["NhanVien"].Rows.Find(id);
            if (dr!=null)
            {
                dr["Ten"] = ten;
                dr["NgaySinh"] = ns;
                dr["GioiTinh"] = gt;
                dr["DiaChi"] = dc;
                dr["SDT"] = sdt;
                dr["NgayVaoLam"] = nvl;
                if (Hinh == null)
                {
                    Hinh = " ";
                }
                dr["Hinh"] = Hinh; 
            }
    
            
 
            SqlCommandBuilder cb = new SqlCommandBuilder(da_NV);
            da_NV.Update(data, "NhanVien");
            return true;

        }
        //-------
        public bool DoiMatKhau(string id, string pass, string user)
        {
            try
            {
                DataRow dr = data.Tables["User"].Rows.Find(id);
                if (dr!=null)
                {
                    dr["ID"] = user;
                    dr["Pass"] = pass;

                }
                SqlCommandBuilder cb = new SqlCommandBuilder(da_User);
                da_User.Update(data, "User");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool TaoTaiKhoan(string id, string pass, string user)
        {
            try
            {
                DataRow dr = data.Tables["User"].NewRow();
                if (dr != null)
                {
                    dr["IDNHANVIEN"] = id;
                    dr["ID"] = user;
                    dr["Pass"] = pass;

                }
                data.Tables["User"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da_User);
                da_User.Update(data, "User");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool XoaTaiKhoan(string id)
        {
            try
            {
                DataRow dr = data.Tables["User"].Rows.Find(id);
                if (dr != null)
                {
                    dr.Delete();

                }
                SqlCommandBuilder cb = new SqlCommandBuilder(da_User);
                da_User.Update(data, "User");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        //----------------
        public DataTable Load_NhanVien()
        {
            string caulenh = "Select n.ID,n.Ten,n.NgaySinh,n.GioiTinh,n.DiaChi,n.SDT,n.NgayVaoLam,n.Hinh From NhanVien as n";
           da_NV = new SqlDataAdapter(caulenh, conn);
            da_NV.Fill(data, "NhanVien");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["NhanVien"].Columns[0];
            data.Tables["NhanVien"].PrimaryKey = khoachinh;
            return data.Tables["NhanVien"];
        }
        
        // -----------------
        public DataTable Load_User()
        {
            string caulenh = "select * from   users as u ";
            da_User = new SqlDataAdapter(caulenh, conn);
            da_User.Fill(data, "User");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["User"].Columns[2];
            data.Tables["User"].PrimaryKey = khoachinh;
            return data.Tables["User"];
        }
        //---------Luong--------
        public DataTable Load_Luong()
        {
            string caulenh = "select * from  Luong";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Luong");
            return data.Tables["Luong"];
        }
        public DataTable Load_Luong_NhanVien()
        {
            string caulenh = "select * from BangLuong as b, NhanVien as n where b.IDNhanVien=n.ID";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Luong_NhanVien");
            return data.Tables["Luong_NhanVien"];
        }
        //-------------------------------------------------------
        /// <summary>
        /// ///
        /// </summary>
        /// <returns></returns>
        public DataTable Load_Phong()
        {
            string caulenh = "Select * From Phong";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Phong");
            return data.Tables["Phong"];
        }
        public DataTable Load_LoaiPhong()
        {
            string caulenh = "Select * From LoaiPhong";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "LoaiPhong");
            return data.Tables["LoaiPhong"];
        }
        public DataTable Load_BangThuePhong()
        {
            string caulenh = "Select * From BangThuePhong";
            SqlDataAdapter da_BangThuePhong = new SqlDataAdapter(caulenh, conn);
            da_BangThuePhong.Fill(data, "BangThuePhong");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["BangThuePhong"].Columns[0];
            data.Tables["BangThuePhong"].PrimaryKey = khoachinh;
            return data.Tables["BangThuePhong"];
        }
        public DataTable Load_BangThuePhong_2()
        {
            string caulenh = "select IDPhong,IDKhacHang,NgayDat,SoLuongNguoiLon,IDTrangThai,TienCoc from BangThuePhong";
            SqlDataAdapter da_BangThuePhong_2 = new SqlDataAdapter(caulenh, conn);
            da_BangThuePhong_2.Fill(data, "BangThuePhong_2");



            return data.Tables["BangThuePhong_2"];
        }
        public DataTable Load_TrangThaiThuePhong()
        {
            string caulenh = "Select * From TrangThaiThuePhong";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "TrangThaiThuePhong");
            return data.Tables["TrangThaiThuePhong"];
        }
        /// <summary>
        /// 
        public DataTable Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue()
        {
            string caulenh = "select b.ID_BANG_THUE_PHONG, p.TenPhong,l.TenLoaiPhong,k.Ten,b.NgayDat,b.CheckIn,b.CheckOut,b.TienCoc,t.Ten from KhachHang as k,LoaiPhong as l, Phong as p, BangThuePhong as b , TrangThaiThuePhong as t where k.ID_KHACH=b.IDKhacHang and l.ID_LOAI_PHONG=p.IDLoai and b.IDPhong=p.ID_PHONG and t.ID_TRANG_THAI_THUE_PHONG=b.IDTrangThai";
            SqlDataAdapter da_Phong_LoaiPhong_BangThuePhong_TrangThaiThue = new SqlDataAdapter(caulenh, conn);
            da_Phong_LoaiPhong_BangThuePhong_TrangThaiThue.Fill(data, "Phong_LoaiPhong_BangThuePhong");
            return data.Tables["Phong_LoaiPhong_BangThuePhong"];
        }
        //-----------------
        public DataTable Load_Phong_LoaiPhong_PhongVatTu_CoSoVatChat(string a)
        {
            string caulenh = "select distinct p.TenPhong,l.TenLoaiPhong,l.GIA,l.SoGiuong from LoaiPhong as l,Phong as p, PhongVatTu as pvt, CoSoVatChat as c where l.ID_LOAI_PHONG=p.IDLoai and p.ID_PHONG=pvt.IDPhong and c.ID_CO_SO_VAT_CHAT=pvt.IDCoSoVatChat and IDPhong like N'%" + a.Trim() + "%'";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Phong_LoaiPhong_PhongVatTu_CoSoVatChat");
            return data.Tables["Phong_LoaiPhong_PhongVatTu_CoSoVatChat"];
        }

        public DataTable Load_Phong_LoaiPhong()
        {
            string caulenh = "select distinct p.TenPhong,l.TenLoaiPhong,l.GIA,l.SoGiuong from LoaiPhong as l,Phong as p, PhongVatTu as pvt, CoSoVatChat as c where l.ID_LOAI_PHONG=p.IDLoai and p.ID_PHONG=pvt.IDPhong and c.ID_CO_SO_VAT_CHAT=pvt.IDCoSoVatChat";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Phong_LoaiPhong");
            return data.Tables["Phong_LoaiPhong"];
        }
        /// </summary>
        /// <returns></returns>
        public DataTable Load_Khach()
        {
            string caulenh = "Select * From KhachHang";
            da_Khach = new SqlDataAdapter(caulenh, conn);
            da_Khach.Fill(data, "Khach");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["Khach"].Columns[0];
            data.Tables["Khach"].PrimaryKey = khoachinh;
            return data.Tables["Khach"];
        }
        //--------------------------------
        public DataTable Load_CoSoVatChat()
        {
            string caulenh = "select * from CoSoVatChat";
            da_CSVC = new SqlDataAdapter(caulenh, conn);
            da_CSVC.Fill(data, "CoSoVatChat");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["CoSoVatChat"].Columns[0];
            data.Tables["CoSoVatChat"].PrimaryKey = khoachinh;
            return data.Tables["CoSoVatChat"];
        }
        public DataTable Load_PhongVatTu()
        {
            string caulenh = "select * from PhongVatTu";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "PhongVatTu");
            return data.Tables["PhongVatTu"];
        }
        public DataTable Load_Phong_CoSoVatChat(string a)
        {
            string caulenh = "select pvt.ID,p.TenPhong,c.Ten from Phong as p, CoSoVatChat as c, PhongVatTu as pvt where p.ID_PHONG=pvt.IDPhong and c.ID_CO_SO_VAT_CHAT=pvt.IDCoSoVatChat and IDPhong like N'%" + a.Trim() + "%'";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Phong_CoSoVatChat");

            return data.Tables["Phong_CoSoVatChat"];
        }
        //---------
       
        public DataTable Load_NguoiOCung()
        {
            string caulenh = "Select * From NguoiOCung";
           da_NguoiOCung= new SqlDataAdapter(caulenh, conn);
            da_NguoiOCung.Fill(data, "NguoiOCung");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["NguoiOCung"].Columns[2];
            data.Tables["NguoiOCung"].PrimaryKey = khoachinh;
            return data.Tables["NguoiOCung"];
        }

        /// <summary>
          public bool Xoa_NOC(string id) {

            try
            {
                DataRow dr = data.Tables["NguoiOCung"].Rows.Find(id);
                dr.Delete();
                SqlCommandBuilder cb = new SqlCommandBuilder(da_NguoiOCung);
                da_NguoiOCung.Update(data, "NguoiOCung");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public DataTable Load_NguoiOCung_Phong(string a)
        {
            string caulenh = "select * from KhachHang as k, BangThuePhong as b , NguoiOCung as n ,Phong as p where p.ID_Phong = b.IDPHONG and k.ID_KHACH=n.IDNguoiOCung and b.ID_BANG_THUE_PHONG=n.IDBangThuePhong  and IDPhong like N'%" + a.Trim() + "%'";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "NguoiOCung_Phong");
            return data.Tables["NguoiOCung_Phong"];
        }
        public DataTable Load_DichVu()
        {
            string caulenh = "Select * From DichVu";
            da_DV = new SqlDataAdapter(caulenh, conn);
            da_DV.Fill(data, "DichVu");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["DichVu"].Columns[0];
            data.Tables["DichVu"].PrimaryKey = khoachinh;
            return data.Tables["DichVu"];
        }
        public DataTable Load_SuDungDichVu()
        {
            string caulenh = "Select * From SuDungDichVu";
            SqlDataAdapter da_DV = new SqlDataAdapter(caulenh, conn);
            da_DV.Fill(data, "SuDungDichVu");
            return data.Tables["SuDungDichVu"];
        }


        public DataTable Load_BangThuePhong_Phong()
        {
            string caulenh = "select b.ID_BANG_THUE_PHONG,p.TenPhong from BangThuePhong as b, Phong as p where b.IDPhong=p.ID_PHONG";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "BangThuePhong_Phong");
            return data.Tables["BangThuePhong_Phong"];
        }
        // -----------------------------------
        public DataTable Load_HoaDon_TongHop()
        {
            string caulenh = "select  h.ID_HoaDonThu,k.Ten,p.TenPhong,h.NgayLapHoaDon,h.LyDo,h.TongTien  from NguoiOCung as noc,BangThuePhong as b, KhachHang as k, HoaDonThu as h,Phong as p  where  k.ID_KHACH=h.IDKhachHang and p.ID_PHONG=b.IDPhong and noc.IDBangThuePhong=b.ID_BANG_THUE_PHONG and noc.IDNguoiOCung =k.ID_KHACH";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "HoaDon_TongHop");
            return data.Tables["HoaDon_TongHop"];
        }

        //======
        public DataTable Load_HoaDon_Phong(string a)
        {
            string caulenh = "select * from HoaDonThu as h, KhachHang as k where h.IDKhachHang=k.ID_KHACH and h.IDKhachHang like N'%" + a.Trim() + "%'";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "HoaDon_Phong");
            return data.Tables["HoaDon_Phong"];
        }
        //===============
        public DataTable Load_HoaDonThu()
        {
            string caulenh = "Select * From HoaDonThu";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "HoaDonThu");
            return data.Tables["HoaDonThu"];
        }
        //--------------
        public DataTable Load_DichVu_Phong(string a)
        {
            string caulenh = "select ID_SU_DUNG_DICH_VU,p.TenPhong,d.Ten,d.Gia from DichVu as d, SuDungDichVu as s, BangThuePhong as b , Phong as p where d.ID_DICH_VU=s.IDDichVu and s.IDBangThuePhong=b.ID_BANG_THUE_PHONG and p.ID_PHONG = b.IDPhong and IDPhong like N'%" + a.Trim() + "%'";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "DichVu_Phong");
            return data.Tables["DichVu_Phong"];
        }
        /// <summary>
        /// ////
        public DataTable Load_KHACH_DICHVU(string a)
        {
            string caulenh = "select ID_KHACH,k.Ten from KhachHang as k, BangThuePhong as b , NguoiOCung as n where k.ID_KHACH=n.IDNguoiOCung and b.ID_BANG_THUE_PHONG=n.IDBangThuePhong and IDPhong like N'%" + a.Trim() + "%'";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "KHACH_DICHVU");
            return data.Tables["KHACH_DICHVU"];
        }
        /// </summary>
        //-------
        
     
        public DataTable Load_Xoa_HOADON()
        {
            string caulenh = "select * from HoaDonThu as h  ";
            SqlDataAdapter da_Phong = new SqlDataAdapter(caulenh, conn);
            da_Phong.Fill(data, "Xoa_HOADON");
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = data.Tables["Xoa_HOADON"].Columns[0];
            data.Tables["Xoa_HOADON"].PrimaryKey = khoachinh;
            return data.Tables["Xoa_HOADON"];
        }
        public bool XOA_HOA_DON(string ma)
        {
            try
            {
                string caulenh = "select * from HoaDonThu as h";
                da_Xoa_HOADON = new SqlDataAdapter(caulenh, conn);
                DataRow dr = data.Tables["Xoa_HOADON"].Rows.Find(ma);
                dr.Delete();
                //SqlCommandBuilder cb = new SqlCommandBuilder(da_Xoa_HOADON);
                da_Xoa_HOADON.Update(data, "Xoa_HOADON");


                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
