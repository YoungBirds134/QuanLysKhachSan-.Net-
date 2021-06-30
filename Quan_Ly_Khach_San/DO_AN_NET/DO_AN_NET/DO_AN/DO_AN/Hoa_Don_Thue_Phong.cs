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
    public partial class Hoa_Don_Thue_Phong : Form
    {
        XuLy dt = new XuLy();
        string gt_khach;
        public Hoa_Don_Thue_Phong()
        {
            InitializeComponent();
        }
        Main m = new Main();
       public Hoa_Don_Thue_Phong(string gt):this() {
       gt_khach=gt;
        }
        private void Hoa_Don_Thue_Phong_Load(object sender, EventArgs e)
        {
            HoaDonThuePhong rp = new HoaDonThuePhong();
            rp.SetDataSource(dt.Load_HoaDon_Phong(gt_khach));
            crystalReportViewer1.ReportSource = rp;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Hoa_Don_Thue_Phong_FormClosed(object sender, FormClosedEventArgs e)
        {
            gt_khach = " ";
        }
    }
}
