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
    public partial class HoaDonPhong : Form
    {
        XuLy doituong = new XuLy();
        public HoaDonPhong()
        {
            InitializeComponent();
        }

        private void HoaDonPhong_Load(object sender, EventArgs e)
        {

            
            comboBox1.DataSource = doituong.Load_Khach();
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "ID_KHACH";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            }
          
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
         
            if (doituong.XOA_HOA_DON(label2.Text) == true)
            {
                MessageBox.Show("Thực Hiện Thành Công");
              
                dataGridView1.DataSource = doituong.Load_HoaDon_Phong(comboBox1.SelectedValue.ToString());
          

            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
           
            doituong.Load_HoaDon_Phong(comboBox1.SelectedValue.ToString()).Clear();
            dataGridView1.DataSource = doituong.Load_HoaDon_Phong(comboBox1.SelectedValue.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }


}

