using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Main : Form
    {
        string giaTriDangNhap;
        XuLy doituong = new XuLy();
        BangThuePhong btp = new BangThuePhong();
        public Main()
        {
            InitializeComponent();
        }
        public Main(string gt):this() {
        giaTriDangNhap=gt;
        }
        Login login = new Login();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (giaTriDangNhap == "admin")
            {
                gvKhachhang.DataSource = doituong.Load_Khach();

                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
            }
            else
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }

            dataGridView3.DataSource = doituong.Load_CoSoVatChat();
            dataGridView4.DataSource = doituong.Load_DichVu();
           dataGridView_quanLyPhong.DataSource= doituong.Load_Phong_LoaiPhong_PhongVatTu_CoSoVatChat(comboBox1.Text);
            dataGridView_QuanLyThuePhong.DataSource = doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue();
            dataGridView1.DataSource = doituong.Load_BangThuePhong();
            comboBox_Phong.DataSource = doituong.Load_Phong();
            comboBox_Phong.DisplayMember = "TenPhong";
            comboBox_Phong.ValueMember = "ID_Phong";
            comboBox_Khach.DataSource = doituong.Load_Khach();
            comboBox_Khach.DisplayMember = "Ten";
            comboBox_Khach.ValueMember = "ID_KHACH";
            comboBox_TrangThai.DataSource = doituong.Load_TrangThaiThuePhong();
            comboBox_TrangThai.DisplayMember = "Ten";
            comboBox_TrangThai.ValueMember = "ID_TRANG_THAI_THUE_PHONG";

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = dataGridView4;

            comboBox_DichVu_DichVu.DataSource = dataGridView4.DataSource;
            comboBox_DichVu_DichVu.DisplayMember = "Ten";
            comboBox_DichVu_DichVu.ValueMember = "ID_DICH_VU";
            comboBox_Phong_DichVu.DataSource = doituong.Load_BangThuePhong_Phong();
            comboBox_Phong_DichVu.DisplayMember = "TenPhong";
            comboBox_Phong_DichVu.ValueMember = "ID_BANG_THUE_PHONG";
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = dataGridView_QuanLyThuePhong;
            comboBox_Phong_NOC.DataSource = dataGridView_QuanLyThuePhong.DataSource;
           
            comboBox_Phong_NOC.DisplayMember = "TenPhong";
            comboBox_Phong_NOC.ValueMember = "ID_BANG_THUE_PHONG";




            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = comboBox_Khach;
            comboBox_Khach_NOC.DataSource = comboBox_Khach.DataSource;
            comboBox_Khach_NOC.DisplayMember = "Ten";
            comboBox_Khach_NOC.ValueMember = "ID_KHACH";

            var bindingSource7 = new BindingSource();
            bindingSource7.DataSource = comboBox_Phong;
            comboBox_Phong_DICH_VU.DataSource = comboBox_Phong.DataSource;

            comboBox_Phong_DICH_VU.DisplayMember = "TenPhong";
            comboBox_Phong_DICH_VU.ValueMember = "ID_Phong";
          



             var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = comboBox_Phong;
            comboBox_Phong_CSVC.DataSource = comboBox_Phong.DataSource;
           
            comboBox_Phong_CSVC.DisplayMember = "TenPhong";
            comboBox_Phong_CSVC.ValueMember = "ID_Phong";

            var bindingSource8 = new BindingSource();
            bindingSource8.DataSource = comboBox_Phong;
            comboBox1.DataSource = comboBox_Phong.DataSource;

            comboBox1.DisplayMember = "TenPhong";
            comboBox1.ValueMember = "ID_Phong";


            var bindingSource5 = new BindingSource();
            bindingSource5.DataSource = comboBox_Phong;
            comboBox_Phong_Co_SO_VATCHAT.DataSource = comboBox_Phong.DataSource;

            comboBox_Phong_Co_SO_VATCHAT.DisplayMember = "TenPhong";
            comboBox_Phong_Co_SO_VATCHAT.ValueMember = "ID_Phong";


            var bindingSource6 = new BindingSource();
            bindingSource6.DataSource = dataGridView3;

            comboBoxCO_SO_VAT_CHTA.DataSource = dataGridView3.DataSource;
            comboBoxCO_SO_VAT_CHTA.DisplayMember = "Ten";
            comboBoxCO_SO_VAT_CHTA.ValueMember = "ID_CO_SO_VAT_CHAT";

            var bindingSource11 = new BindingSource();
            bindingSource11.DataSource = comboBox3;
            comboBox3.DataSource = comboBox_Khach.DataSource;
            comboBox3.DisplayMember = "Ten";
            comboBox3.ValueMember = "ID_KHACH";


            //===============


        }

      
       //////////////////////HAM////////////////////////////
       

       

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doi_Mat_Khau ql = new Doi_Mat_Khau();
            ql.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong l = new Luong();
            l.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;
            int giay = DateTime.Now.Second;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            Time_Now.Text = "Bây giờ là :  " + gio + " : " + phut + " : " + giay + " Ngày " + day + " Tháng " + month + " Năm " + year;
    
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue().Clear();
            if (doituong.Check_In(textBox_ID.Text,dateTimePicker_CheckIn.Value.ToShortDateString())==true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
                doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue();
                doituong.Load_BangThuePhong();
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void button_CheckOut_Click(object sender, EventArgs e)
        {
            doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue().Clear();
            if (doituong.Check_OUT(textBox_ID.Text, dateTimePicker_checkOut.Value.ToShortDateString()) == true)
            {

                if (doituong.Them_Hoa_Don(giaTriDangNhap.ToString(), comboBox_Khach.SelectedValue.ToString(), null, DateTime.Now.ToShortDateString(),doituong.Tinh_Tien_Phong(comboBox_Phong.SelectedValue.ToString(),dateTimePicker_CheckIn.Value.ToShortDateString(),dateTimePicker_checkOut.Value.ToShortDateString(),textBox_TienCoc.Text )))
                {
                    MessageBox.Show("Thực Hiện Thành Công");
                }
                doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue();
                doituong.Load_BangThuePhong();
                doituong.Load_HoaDon_Phong(comboBox_Khach.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue().Clear();
            doituong.Load_BangThuePhong_Phong().Clear();
            if (doituong.Dat_Phong( comboBox_Phong.SelectedValue.ToString(), comboBox_Khach.SelectedValue.ToString(), dateTimePicker_NgayDat.Value.ToShortDateString(), text_songuoi.Text, comboBox_TrangThai.SelectedValue.ToString(), textBox_TienCoc.Text) == true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
                doituong.Load_Phong_LoaiPhong_BangThuePhong_TrangThaiThue();
                doituong.Load_BangThuePhong_Phong();
                doituong.Load_BangThuePhong();
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            doituong.Load_HoaDon_TongHop().Clear();
            doituong.Load_DichVu_Phong(comboBox_Phong_DICH_VU.SelectedValue.ToString()).Clear();
            if (doituong.Them_Dich_Vu(comboBox_Phong_DichVu.SelectedValue.ToString(), comboBox_DichVu_DichVu.SelectedValue.ToString()) == true)
            {

                if (doituong.Them_Hoa_Don(giaTriDangNhap.ToString(), comboBox_KhachHang_DichVu.SelectedValue.ToString(), textBox8.Text, DateTime.Now.ToShortDateString(), Tinh_Tien_Phong()))
                {
                     MessageBox.Show("Thực Hiện Thành Công");
                }
                doituong.Load_HoaDon_TongHop();
                doituong.Load_DichVu_Phong(comboBox_Phong_DICH_VU.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            doituong.Load_Phong_CoSoVatChat(comboBox_Phong_CSVC.SelectedValue.ToString()).Clear();
                dataGridView_Co_So_vat_chat_Phong.DataSource = doituong.Load_Phong_CoSoVatChat(comboBox_Phong_CSVC.SelectedValue.ToString());
           
        }

        private void button21_Click(object sender, EventArgs e)
        {

            doituong.Load_Phong_CoSoVatChat(comboBox_Phong_CSVC.SelectedValue.ToString()).Clear();
            if (doituong.Them_Co_So_Vat_Chat(comboBox_Phong_CSVC.SelectedValue.ToString(),comboBoxCO_SO_VAT_CHTA.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
              doituong.Load_Phong_CoSoVatChat(comboBox_Phong_CSVC.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            doituong.Load_DichVu_Phong(comboBox_Phong_DICH_VU.SelectedValue.ToString()).Clear();
            dataGridView_DichVu_bangThuePhong.DataSource = doituong.Load_DichVu_Phong(comboBox_Phong_DICH_VU.SelectedValue.ToString());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doituong.Load_Phong_LoaiPhong_PhongVatTu_CoSoVatChat(comboBox1.SelectedValue.ToString()).Clear();
            dataGridView_quanLyPhong.DataSource = doituong.Load_Phong_LoaiPhong_PhongVatTu_CoSoVatChat(comboBox1.SelectedValue.ToString());
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
doituong.Load_Phong_LoaiPhong().Clear();
            dataGridView_quanLyPhong.DataSource = doituong.Load_Phong_LoaiPhong();
        }

      

       //====
        public double Tinh_Tien_Phong(){
            int a = 1;
            return a;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //if (comboBox_KhachHang_DichVu.Text== comboBox_Phong_DICH_VU.SelectedValue.ToString())
            //{
            doituong.Load_KHACH_DICHVU(comboBox_KhachHang_DichVu.Text).Clear();
                comboBox_KhachHang_DichVu.DataSource = doituong.Load_KHACH_DICHVU(comboBox_Phong_DICH_VU.SelectedValue.ToString());
                comboBox_KhachHang_DichVu.DisplayMember = "Ten";
                comboBox_KhachHang_DichVu.ValueMember = "ID_Khach";
                MessageBox.Show("Thực Hiện Thành Công");
            //}
        }

        private void button24_Click(object sender, EventArgs e)
        {
            HoaDonPhong hdp = new HoaDonPhong();
            hdp.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (doituong.Them_Nguoi_O_Cung(comboBox_Phong_NOC.SelectedValue.ToString(),comboBox_Khach_NOC.SelectedValue.ToString())== true)
            {

               
                    MessageBox.Show("Thực Hiện Thành Công");
             
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            NguoiOCung noc = new NguoiOCung();
            noc.Show();
        }

        private void dataGridView_quanLyPhong_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView_quanLyPhong.CurrentRow != null)
            //{
            //    textBox_ID.Text = dataGridView_quanLyPhong.CurrentRow.Cells[0].Value.ToString().Trim();
            //    comboBox_Phong.Text = dataGridView_quanLyPhong.CurrentRow.Cells[1].Value.ToString().Trim();
            //    textBox_LOAI_PHONG.Text = dataGridView_quanLyPhong.CurrentRow.Cells[2].Value.ToString().Trim();
            //    comboBox_Khach.Text = dataGridView_quanLyPhong.CurrentRow.Cells[3].Value.ToString().Trim();
            //    //dateTimePicker_NgayDat.Text = dataGridView_quanLyPhong.CurrentRow.Cells[4].Value.ToString().Trim();
            //    //dateTimePicker_CheckIn.Text = dataGridView_quanLyPhong.CurrentRow.Cells[5].Value.ToString().Trim();
            //    //dateTimePicker_checkOut.Text = dataGridView_quanLyPhong.CurrentRow.Cells[6].Value.ToString().Trim();
            //    //textBox_TienCoc.Text = dataGridView_quanLyPhong.CurrentRow.Cells[7].Value.ToString().Trim();
            //    //comboBox_TrangThai.Text = dataGridView_quanLyPhong.CurrentRow.Cells[8].Value.ToString().Trim();
            //}
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox_Phong.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               
                comboBox_Khach.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker_NgayDat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker_CheckIn.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker_checkOut.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                text_songuoi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                comboBox_TrangThai.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox_TienCoc.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
              
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
     
            Hoa_Don_Thue_Phong hdtp = new Hoa_Don_Thue_Phong(comboBox_Khach.SelectedValue.ToString());
            hdtp.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rdNam.Checked)
	{
		  if (doituong.Them_Khach(txtMkh.Text,txtTenkh.Text,dateTimePicker1.Value.ToShortDateString(),rdNam.Text,textBox9.Text,txtSodt.Text,txtCmnd.Text,textBox12.Text,txtGhichu.Text)==true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
          else
          {
              MessageBox.Show("That Bai");
          }
    }
            else if(rdNu.Checked)
            {
                if (doituong.Them_Khach(txtMkh.Text, txtTenkh.Text, dateTimePicker1.Value.ToShortDateString(), rdNu.Text, textBox9.Text, txtSodt.Text, txtCmnd.Text, textBox12.Text, txtGhichu.Text) == true)
                {
                    MessageBox.Show("Thực Hiện Thành Công");
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (doituong.Xoa_Khach(txtMkh.Text)==true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            {
                if (doituong.Sua_Khach(txtMkh.Text, txtTenkh.Text, dateTimePicker1.Value.ToShortDateString(), rdNam.Text, textBox9.Text, txtSodt.Text, txtCmnd.Text, textBox12.Text, txtGhichu.Text) == true)
                {
                    MessageBox.Show("Thực Hiện Thành Công");
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
            else if (rdNu.Checked)
            {
                if (doituong.Sua_Khach(txtMkh.Text, txtTenkh.Text, dateTimePicker1.Value.ToShortDateString(), rdNu.Text, textBox9.Text, txtSodt.Text, txtCmnd.Text, textBox12.Text, txtGhichu.Text) == true)
                {
                    MessageBox.Show("Thực Hiện Thành Công");
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
        }

        private void gvKhachhang_SelectionChanged(object sender, EventArgs e)
        {
            if (gvKhachhang.CurrentRow!= null)
            {
                txtMkh.Text = gvKhachhang.CurrentRow.Cells[0].Value.ToString();
                txtTenkh.Text = gvKhachhang.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = gvKhachhang.CurrentRow.Cells[2].Value.ToString();
                if (gvKhachhang.CurrentRow.Cells[3].Value.ToString().Trim() == "NAM"&& gvKhachhang.CurrentRow.Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                textBox9.Text = gvKhachhang.CurrentRow.Cells[4].Value.ToString();
                txtSodt.Text = gvKhachhang.CurrentRow.Cells[5].Value.ToString();
                txtCmnd.Text = gvKhachhang.CurrentRow.Cells[6].Value.ToString();
                textBox12.Text = gvKhachhang.CurrentRow.Cells[7].Value.ToString();
                txtGhichu.Text = gvKhachhang.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (doituong.Them_Dich_Vu_DV(textBox13.Text,textBox10.Text,textBox11.Text) == true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (doituong.Xoa_Dich_Vu(textBox13.Text)==true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (doituong.Sua_Dich_Vu_DV(textBox13.Text, textBox10.Text, textBox11.Text) == true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow!=null)
            {
                textBox13.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                textBox10.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                textBox11.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Hoa_Don_Dich_Vu đvd = new Hoa_Don_Dich_Vu();
            đvd.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (doituong.Them_Co_So_Vat_Chat_2(textBox1.Text,textBox7.Text)== true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (doituong.Xoa_CSVC(textBox1.Text)== true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (doituong.Sua_Co_So_Vat_Chat_2(textBox1.Text, textBox7.Text) == true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow!=null)
            {
                textBox1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                textBox7.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doi_Mat_Khau q = new Doi_Mat_Khau();
            q.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tao_Tai_Khoan t = new Tao_Tai_Khoan();
            t.Show();
        }
        }

      
       
       
    }

