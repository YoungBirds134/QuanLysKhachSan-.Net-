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
    public partial class Doi_Mat_Khau : Form
    {
        XuLy doituong = new XuLy();
        public Doi_Mat_Khau()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = doituong.Load_User();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (doituong.DoiMatKhau(label2.Text,textBox1.Text,textBox2.Text)==true)
            {
                MessageBox.Show("Đổi Mật Khẩu Thành Công");
        
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                label2.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
