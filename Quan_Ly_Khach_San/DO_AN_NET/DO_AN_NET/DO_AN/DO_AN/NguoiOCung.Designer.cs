namespace DO_AN
{
    partial class NguoiOCung
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox_1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button22);
            this.panel9.Controls.Add(this.label35);
            this.panel9.Controls.Add(this.comboBox_1);
            this.panel9.Location = new System.Drawing.Point(63, 36);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(366, 76);
            this.panel9.TabIndex = 7;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(188, 36);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 5;
            this.button22.Text = "Tìm Kiếm";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 39);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 13);
            this.label35.TabIndex = 4;
            this.label35.Text = "Phòng:";
            // 
            // comboBox_1
            // 
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new System.Drawing.Point(50, 39);
            this.comboBox_1.Name = "comboBox_1";
            this.comboBox_1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_KHACH";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CMND";
            this.Column7.HeaderText = "CMND/PASSPORT";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "QuocTich";
            this.Column8.HeaderText = "Quốc Tịch";
            this.Column8.Name = "Column8";
            // 
            // NguoiOCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NguoiOCung";
            this.Text = "NguoiOCung";
            this.Load += new System.EventHandler(this.NguoiOCung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBox_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}