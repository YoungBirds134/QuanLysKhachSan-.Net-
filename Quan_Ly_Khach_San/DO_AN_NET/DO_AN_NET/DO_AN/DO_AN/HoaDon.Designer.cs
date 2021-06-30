namespace DO_AN
{
    partial class HoaDon
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
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(12, 160);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(634, 191);
            this.dataGridView_HoaDon.TabIndex = 0;
            this.dataGridView_HoaDon.SelectionChanged += new System.EventHandler(this.dataGridView_HoaDon_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_HoaDonThu";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ten";
            this.Column1.HeaderText = "Tên Khách Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenPhong";
            this.Column2.HeaderText = "Phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayLapHoaDon";
            this.Column3.HeaderText = "Ngày Lập Hóa Đơn";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LyDo";
            this.Column5.HeaderText = "Lý Do";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongTien";
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.Name = "Column4";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 532);
            this.Controls.Add(this.dataGridView_HoaDon);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}