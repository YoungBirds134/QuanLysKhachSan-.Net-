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
    public partial class Luong : Form
    {
        XuLy doituong = new XuLy();
        public Luong()
        {
            InitializeComponent();
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = doituong.Load_Luong_NhanVien();
        }
    }
}
