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
    public partial class Login : Form
    {
        XuLy doituong = new XuLy();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( doituong.KIEM_TRA_DANG_NHAP(txttenDangnhap.Text,txtmatKhau.Text,id_NhanVien.Text)==true )
            {
                if (id_NhanVien.Text=="admin")
                {
                    MessageBox.Show("XIN CHAO ADMIN!");
                    Main Main = new Main(id_NhanVien.Text);
                    Main.Show();
                    Hide();
                   
                }
                else
                {
                    Main main = new Main(id_NhanVien.Text);
                    main.Show();
                    Hide();
                    MessageBox.Show("XIN CHAO " + txttenDangnhap.Text + "!");
                }
            }
            else
            {
                MessageBox.Show("Ket Noi That Bai");
            }
          
            //if (DangNhap())
            //{
            //    Main Main = new Main();

            //    Main.Show();
            //    Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

      ////////////////////Ham//////////////////////////////////////////
        private bool Pass()
        {
            if (txtmatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool User()
        {
            if (txttenDangnhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool DangNhap()
        {
            if (User() && Pass())
            {
                return true;
            }
            return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
