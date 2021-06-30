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
    public partial class Tao_Tai_Khoan : Form
    {
        XuLy doituong = new XuLy();
        public Tao_Tai_Khoan()
        {
            InitializeComponent();
        }

        private void Tao_Tai_Khoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = doituong.Load_User();
            comboBox1.DataSource = doituong.Load_NhanVien();
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "ID";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doituong.TaoTaiKhoan(comboBox1.SelectedValue.ToString(), textBox2.Text, textBox1.Text) == true)
            {
                MessageBox.Show("Tạo Tài Khoản Thành Công");

            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (doituong.XoaTaiKhoan(comboBox1.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Xoá Tài Khoản Thành Công");

            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!= null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
