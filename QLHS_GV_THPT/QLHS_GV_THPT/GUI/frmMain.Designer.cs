﻿namespace QLHS_GV_THPT.GUI
{
    partial class frmMain
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
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(100, 374);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(202, 151);
            this.btnGiaoVien.TabIndex = 4;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Location = new System.Drawing.Point(100, 195);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(202, 151);
            this.btnHocSinh.TabIndex = 1;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Location = new System.Drawing.Point(354, 374);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(202, 151);
            this.btnLopHoc.TabIndex = 5;
            this.btnLopHoc.Text = "Lớp học";
            this.btnLopHoc.UseVisualStyleBackColor = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Location = new System.Drawing.Point(354, 195);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(202, 151);
            this.btnMonHoc.TabIndex = 2;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(598, 195);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(202, 151);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phần mềm quản lý học sinh";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Location = new System.Drawing.Point(598, 374);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(202, 151);
            this.btnHuongDan.TabIndex = 6;
            this.btnHuongDan.Text = "Hướng Dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 578);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMonHoc);
            this.Controls.Add(this.btnLopHoc);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnGiaoVien);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh THPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuongDan;
    }
}