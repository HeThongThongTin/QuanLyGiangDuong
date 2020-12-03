namespace QuanLyGiangDuong
{
    partial class NhatKySuDungGD
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView_NKSDGD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThoiGian1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThoiGian2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NKSDGD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhật Ký Sử Dụng Giảng Đường";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(1023, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kế hoạch bổ sung";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Nhật Ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tìm Kiếm";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sang",
            "Chieu"});
            this.comboBox2.Location = new System.Drawing.Point(12, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // dataGridView_NKSDGD
            // 
            this.dataGridView_NKSDGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NKSDGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Phong,
            this.Sang,
            this.ThoiGian1,
            this.Chieu,
            this.ThoiGian2,
            this.MucDich,
            this.GhiChu});
            this.dataGridView_NKSDGD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_NKSDGD.Location = new System.Drawing.Point(0, 208);
            this.dataGridView_NKSDGD.Name = "dataGridView_NKSDGD";
            this.dataGridView_NKSDGD.RowHeadersWidth = 51;
            this.dataGridView_NKSDGD.RowTemplate.Height = 24;
            this.dataGridView_NKSDGD.Size = new System.Drawing.Size(1273, 570);
            this.dataGridView_NKSDGD.TabIndex = 11;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // Phong
            // 
            this.Phong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phong.HeaderText = "Tên Phòng";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            // 
            // Sang
            // 
            this.Sang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sang.HeaderText = "Sáng";
            this.Sang.MinimumWidth = 6;
            this.Sang.Name = "Sang";
            this.Sang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ThoiGian1
            // 
            this.ThoiGian1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGian1.HeaderText = "Thời Gian";
            this.ThoiGian1.MinimumWidth = 6;
            this.ThoiGian1.Name = "ThoiGian1";
            // 
            // Chieu
            // 
            this.Chieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chieu.HeaderText = "Chiều";
            this.Chieu.MinimumWidth = 6;
            this.Chieu.Name = "Chieu";
            this.Chieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ThoiGian2
            // 
            this.ThoiGian2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGian2.HeaderText = "Thời Gian";
            this.ThoiGian2.MinimumWidth = 6;
            this.ThoiGian2.Name = "ThoiGian2";
            // 
            // MucDich
            // 
            this.MucDich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MucDich.HeaderText = "Mục Đích";
            this.MucDich.MinimumWidth = 6;
            this.MucDich.Name = "MucDich";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thứ 2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1023, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 69);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cán bộ : Nguyễn Mạnh Cường";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chức vụ : Học viên";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Location = new System.Drawing.Point(168, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Xem";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NhatKySuDungGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 778);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_NKSDGD);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "NhatKySuDungGD";
            this.Text = "Nhật ký sử dụng giảng đường";
            this.Load += new System.EventHandler(this.NhatKySuDungGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NKSDGD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView_NKSDGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}