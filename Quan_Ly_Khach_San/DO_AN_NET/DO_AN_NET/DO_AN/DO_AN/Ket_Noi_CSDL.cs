using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Ket_Noi_CSDL : Form
    {
        XuLy kn = new XuLy();
        public Ket_Noi_CSDL()
        {
            InitializeComponent();
        }

        private void Ket_Noi_CSDL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kn.KT_KetNoiSQL(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text)==true)
            {
                MessageBox.Show("Kết Nối CSDL Thành Công");
                Login g = new Login();
                g.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }
    }
}
