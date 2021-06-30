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
    public partial class NguoiOCung : Form
    {
        XuLy doituong = new XuLy();
        public NguoiOCung()
        {
            InitializeComponent();
        }

        private void NguoiOCung_Load(object sender, EventArgs e)
        {
           
            comboBox_1.DataSource = doituong.Load_Phong();
            comboBox_1.DisplayMember = "TenPhong";
            comboBox_1.ValueMember = "ID_Phong";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            doituong.Load_NguoiOCung_Phong(comboBox_1.SelectedValue.ToString()).Clear();
            dataGridView1.DataSource = doituong.Load_NguoiOCung_Phong(comboBox_1.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (doituong.Xoa_NOC(label1.Text)== true)
            {


                MessageBox.Show("Thực Hiện Thành Công");
     
            }
            else
            {
                MessageBox.Show("Thực Hiện Thất Bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
