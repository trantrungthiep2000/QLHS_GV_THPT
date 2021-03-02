﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_GV_THPT.GUI
{
    public partial class frmHocSinh : Form
    {
        BindingSource hocSinhList = new BindingSource();
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void LoadFirstTime()
        {
            dgvHocSinh.DataSource = hocSinhList;
            LoadListHocSinh();
            LoadComboboxLopHoc();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void LoadListHocSinh()
        {
            hocSinhList.DataSource = HocSinhDAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            dgvHocSinh.Columns["IDHocSinh"].HeaderText = "ID Học sinh";
            dgvHocSinh.Columns["TenHocSinh"].HeaderText = "Tên học sinh";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns["IdLopHoc"].HeaderText = "Lớp học";
        }

        private void BindingDataToFrom()
        {
            txtIdHocSinh.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "IDHocSinh", true, DataSourceUpdateMode.Never));
            txtTenHocSinh.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "TenHocSinh", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            cboIdLopHoc.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "IdLopHoc", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dgvHocSinh.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ";
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ" : "Nam";
            rdbNu.DataBindings.Add(fmaleBinding);
            rdbNu.CheckedChanged += (s, args) => rdbNam.Checked = !rdbNu.Checked;
        }
        private void LoadComboboxLopHoc()
        {
            cboIdLopHoc.DataSource = HocSinhDAO.Instance.GetListLopHoc();
            cboIdLopHoc.DisplayMember = "IdLopHoc";
        }
        private void MakeNull()
        {
            txtIdHocSinh.Text = "";
            txtTenHocSinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtTimKiem.Text = "";
            LoadComboboxLopHoc();
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            MakeNull();
        }
    }
}
