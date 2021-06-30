namespace DO_AN
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picNV = new System.Windows.Forms.PictureBox();
            this.linklbInsertPic = new System.Windows.Forms.LinkLabel();
            this.dTPicker_NSinh = new System.Windows.Forms.DateTimePicker();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txtDThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.dTPicker_NVaoLam = new System.Windows.Forms.DateTimePicker();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.grpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picNV);
            this.groupBox1.Controls.Add(this.linklbInsertPic);
            this.groupBox1.Controls.Add(this.dTPicker_NSinh);
            this.groupBox1.Controls.Add(this.optNam);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDChi);
            this.groupBox1.Controls.Add(this.txtDThoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.optNu);
            this.groupBox1.Controls.Add(this.dTPicker_NVaoLam);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 318);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // picNV
            // 
            this.picNV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picNV.Location = new System.Drawing.Point(341, 47);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(187, 181);
            this.picNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNV.TabIndex = 15;
            this.picNV.TabStop = false;
            // 
            // linklbInsertPic
            // 
            this.linklbInsertPic.Location = new System.Drawing.Point(360, 248);
            this.linklbInsertPic.Name = "linklbInsertPic";
            this.linklbInsertPic.Size = new System.Drawing.Size(112, 16);
            this.linklbInsertPic.TabIndex = 14;
            this.linklbInsertPic.TabStop = true;
            this.linklbInsertPic.Text = "Chèn hình nhân viên";
            this.linklbInsertPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbInsertPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbInsertPic_LinkClicked);
            // 
            // dTPicker_NSinh
            // 
            this.dTPicker_NSinh.CustomFormat = "\"mm dd yyyy\"";
            this.dTPicker_NSinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NSinh.Location = new System.Drawing.Point(120, 112);
            this.dTPicker_NSinh.Name = "dTPicker_NSinh";
            this.dTPicker_NSinh.Size = new System.Drawing.Size(128, 20);
            this.dTPicker_NSinh.TabIndex = 5;
            // 
            // optNam
            // 
            this.optNam.Checked = true;
            this.optNam.Location = new System.Drawing.Point(120, 144);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(64, 24);
            this.optNam.TabIndex = 6;
            this.optNam.TabStop = true;
            this.optNam.Text = "Nam";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(120, 16);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(128, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(120, 48);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(192, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDChi
            // 
            this.txtDChi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDChi.Location = new System.Drawing.Point(120, 176);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(192, 20);
            this.txtDChi.TabIndex = 8;
            // 
            // txtDThoai
            // 
            this.txtDThoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDThoai.Location = new System.Drawing.Point(120, 208);
            this.txtDThoai.Name = "txtDThoai";
            this.txtDThoai.Size = new System.Drawing.Size(128, 20);
            this.txtDThoai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày vào làm:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giới tính:";
            // 
            // optNu
            // 
            this.optNu.Location = new System.Drawing.Point(232, 144);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(56, 24);
            this.optNu.TabIndex = 7;
            this.optNu.Text = "Nữ";
            // 
            // dTPicker_NVaoLam
            // 
            this.dTPicker_NVaoLam.CustomFormat = "\"mm dd yyyy\"";
            this.dTPicker_NVaoLam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NVaoLam.Location = new System.Drawing.Point(120, 240);
            this.dTPicker_NVaoLam.Name = "dTPicker_NVaoLam";
            this.dTPicker_NVaoLam.Size = new System.Drawing.Size(128, 20);
            this.dTPicker_NVaoLam.TabIndex = 10;
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(615, 19);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size = new System.Drawing.Size(88, 272);
            this.grpFunction.TabIndex = 8;
            this.grpFunction.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Location = new System.Drawing.Point(8, 112);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(72, 23);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Thoát";
            // 
            // cmdDelete
            // 
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDelete.Location = new System.Drawing.Point(8, 80);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(72, 23);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEdit.Location = new System.Drawing.Point(8, 48);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(72, 23);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Sửa";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(8, 16);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(72, 23);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 226);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.grpFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linklbInsertPic;
        private System.Windows.Forms.DateTimePicker dTPicker_NSinh;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txtDThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.DateTimePicker dTPicker_NVaoLam;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}