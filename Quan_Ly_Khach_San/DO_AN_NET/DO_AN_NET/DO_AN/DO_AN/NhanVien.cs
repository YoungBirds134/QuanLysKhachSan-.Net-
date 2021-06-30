using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class NhanVien : Form
    {
        XuLy doituong = new XuLy();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = doituong.Load_NhanVien();
            label1.Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                dTPicker_NSinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim() == "NAM" && dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim() == "Nam")
                {
                    optNam.Checked = true;
                }
                else
                {
                    optNu.Checked = true;
                }
                txtDChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDThoai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dTPicker_NVaoLam.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                picNV.Image = null;
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim() != "")
                {
                    string path = Application.StartupPath + @"\HINH\" + dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim() + ".jpg";
                    string path2 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    if (File.Exists(path))
                    {
                        picNV.Image = Image.FromFile(path);

                    }
                    else
                    {
                        picNV.Image = Image.FromFile(path2);
                    }

                }
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (doituong.Xoa_Nhan_Vien(txtMaNV.Text) == true)
            {
                MessageBox.Show("Thực hiện thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void linklbInsertPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //đường dẫn file text được lưu vào label1
                label1.Text = openFileDialog1.FileName;
                //sử dụng textbox1 để hiển thị file text vừa đọc
         
                picNV.Image = Image.FromFile(label1.Text);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (optNam.Checked)
            {
                if (doituong.Them_Nhan_Vien(txtMaNV.Text, txtTenNV.Text, dTPicker_NSinh.Value.ToShortDateString(), optNam.Text, txtDChi.Text, txtDThoai.Text, dTPicker_NVaoLam.Value.ToShortDateString(), label1.Text) == true)
                {
                    MessageBox.Show("Thực hiện thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (doituong.Them_Nhan_Vien(txtMaNV.Text, txtTenNV.Text, dTPicker_NSinh.Value.ToShortDateString(), optNu.Text, txtDChi.Text, txtDThoai.Text, dTPicker_NVaoLam.Value.ToShortDateString(), label1.Text) == true)
                {
                    MessageBox.Show("Thực hiện thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (optNam.Checked)
            {
                if (doituong.Sua_Nhan_Vien(txtMaNV.Text, txtTenNV.Text, dTPicker_NSinh.Value.ToShortDateString(), optNam.Text, txtDChi.Text, txtDThoai.Text, dTPicker_NVaoLam.Value.ToShortDateString(), label1.Text) == true)
                {
                    MessageBox.Show("Thực hiện thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (doituong.Sua_Nhan_Vien(txtMaNV.Text, txtTenNV.Text, dTPicker_NSinh.Value.ToShortDateString(), optNu.Text, txtDChi.Text, txtDThoai.Text, dTPicker_NVaoLam.Value.ToShortDateString(), label1.Text) == true)
                {
                    MessageBox.Show("Thực hiện thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }


        }

       

       
    }
}
