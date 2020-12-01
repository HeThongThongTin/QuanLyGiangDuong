namespace QuanLyGiangDuong
{
    partial class MuonTTBhoctap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadet_sign_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadet_sign_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MƯỢN TRANG THIẾT BỊ HỌC TẬP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.cadetname,
            this.phone,
            this.classname,
            this.room,
            this.shift,
            this.equipment,
            this.cadet_sign_borrow,
            this.cadet_sign_return,
            this.modify,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(13, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1390, 403);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "MƯỢN TTB";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.HeaderText = "Ngày/tháng";
            this.date.Name = "date";
            // 
            // cadetname
            // 
            this.cadetname.HeaderText = "Họ và tên học viên";
            this.cadetname.Name = "cadetname";
            this.cadetname.Width = 160;
            // 
            // phone
            // 
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            this.phone.Width = 120;
            // 
            // classname
            // 
            this.classname.HeaderText = "Lớp";
            this.classname.Name = "classname";
            // 
            // room
            // 
            this.room.HeaderText = "Phòng học";
            this.room.Name = "room";
            this.room.Width = 110;
            // 
            // shift
            // 
            this.shift.HeaderText = "Kíp học";
            this.shift.Name = "shift";
            // 
            // equipment
            // 
            this.equipment.HeaderText = "Tên trang thiết bị";
            this.equipment.Name = "equipment";
            this.equipment.Width = 150;
            // 
            // cadet_sign_borrow
            // 
            this.cadet_sign_borrow.HeaderText = "Học viên (Ký mượn TTB)";
            this.cadet_sign_borrow.Name = "cadet_sign_borrow";
            // 
            // cadet_sign_return
            // 
            this.cadet_sign_return.HeaderText = "Học viên (Ký trả TTB)";
            this.cadet_sign_return.Name = "cadet_sign_return";
            // 
            // modify
            // 
            this.modify.HeaderText = "Sửa";
            this.modify.Name = "modify";
            this.modify.Text = "Sửa";
            this.modify.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Xóa";
            this.delete.Name = "delete";
            this.delete.Text = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1246, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "TÌM KIẾM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MuonTTBhoctap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MuonTTBhoctap";
            this.Text = "MuonTTBhoctap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadetname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadet_sign_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadet_sign_return;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}