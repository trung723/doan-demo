﻿namespace DoAn1
{
    partial class ReceiptForm
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
            this.TB_MaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBB_NhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_NgayThu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_SoTienThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBB_KhachHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_LyDoThu = new System.Windows.Forms.RichTextBox();
            this.BT_Huy = new System.Windows.Forms.Button();
            this.BT_In = new System.Windows.Forms.Button();
            this.BT_Luu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_MaPhieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CBB_NhanVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DTP_NgayThu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TB_SoTienThu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBB_KhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(364, 388);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // TB_MaPhieu
            // 
            this.TB_MaPhieu.Enabled = false;
            this.TB_MaPhieu.Location = new System.Drawing.Point(9, 44);
            this.TB_MaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.TB_MaPhieu.Name = "TB_MaPhieu";
            this.TB_MaPhieu.Size = new System.Drawing.Size(347, 23);
            this.TB_MaPhieu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã phiếu thu";
            // 
            // CBB_NhanVien
            // 
            this.CBB_NhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBB_NhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBB_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_NhanVien.FormattingEnabled = true;
            this.CBB_NhanVien.Location = new System.Drawing.Point(9, 146);
            this.CBB_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.CBB_NhanVien.Name = "CBB_NhanVien";
            this.CBB_NhanVien.Size = new System.Drawing.Size(347, 25);
            this.CBB_NhanVien.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lý do thu:";
            // 
            // DTP_NgayThu
            // 
            this.DTP_NgayThu.CustomFormat = "dd/MM/yyyy";
            this.DTP_NgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_NgayThu.Location = new System.Drawing.Point(9, 194);
            this.DTP_NgayThu.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_NgayThu.Name = "DTP_NgayThu";
            this.DTP_NgayThu.Size = new System.Drawing.Size(347, 23);
            this.DTP_NgayThu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày thu:";
            // 
            // TB_SoTienThu
            // 
            this.TB_SoTienThu.Location = new System.Drawing.Point(9, 246);
            this.TB_SoTienThu.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SoTienThu.Name = "TB_SoTienThu";
            this.TB_SoTienThu.Size = new System.Drawing.Size(347, 23);
            this.TB_SoTienThu.TabIndex = 9;
            this.TB_SoTienThu.Text = "0";
            this.TB_SoTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền thu (VND):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên thu:";
            // 
            // CBB_KhachHang
            // 
            this.CBB_KhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBB_KhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBB_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_KhachHang.FormattingEnabled = true;
            this.CBB_KhachHang.Location = new System.Drawing.Point(9, 94);
            this.CBB_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.CBB_KhachHang.Name = "CBB_KhachHang";
            this.CBB_KhachHang.Size = new System.Drawing.Size(347, 25);
            this.CBB_KhachHang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng:";
            // 
            // TB_LyDoThu
            // 
            this.TB_LyDoThu.Location = new System.Drawing.Point(30, 311);
            this.TB_LyDoThu.Margin = new System.Windows.Forms.Padding(2);
            this.TB_LyDoThu.MaxLength = 200;
            this.TB_LyDoThu.Name = "TB_LyDoThu";
            this.TB_LyDoThu.Size = new System.Drawing.Size(350, 85);
            this.TB_LyDoThu.TabIndex = 20;
            this.TB_LyDoThu.Text = "";
            // 
            // BT_Huy
            // 
            this.BT_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Huy.Location = new System.Drawing.Point(261, 403);
            this.BT_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Huy.Name = "BT_Huy";
            this.BT_Huy.Size = new System.Drawing.Size(58, 27);
            this.BT_Huy.TabIndex = 19;
            this.BT_Huy.Text = "Hủy";
            this.BT_Huy.UseVisualStyleBackColor = true;
            // 
            // BT_In
            // 
            this.BT_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_In.Location = new System.Drawing.Point(25, 403);
            this.BT_In.Margin = new System.Windows.Forms.Padding(2);
            this.BT_In.Name = "BT_In";
            this.BT_In.Size = new System.Drawing.Size(68, 27);
            this.BT_In.TabIndex = 18;
            this.BT_In.Text = "In phiếu";
            this.BT_In.UseVisualStyleBackColor = true;
            this.BT_In.Visible = false;
            // 
            // BT_Luu
            // 
            this.BT_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Luu.Location = new System.Drawing.Point(325, 403);
            this.BT_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Luu.Name = "BT_Luu";
            this.BT_Luu.Size = new System.Drawing.Size(60, 27);
            this.BT_Luu.TabIndex = 17;
            this.BT_Luu.Text = "Lưu lại";
            this.BT_Luu.UseVisualStyleBackColor = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_LyDoThu);
            this.Controls.Add(this.BT_Huy);
            this.Controls.Add(this.BT_In);
            this.Controls.Add(this.BT_Luu);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TB_MaPhieu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CBB_NhanVien;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker DTP_NgayThu;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TB_SoTienThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CBB_KhachHang;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox TB_LyDoThu;
        public System.Windows.Forms.Button BT_Huy;
        private System.Windows.Forms.Button BT_In;
        public System.Windows.Forms.Button BT_Luu;
    }
}