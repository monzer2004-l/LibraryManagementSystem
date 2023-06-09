﻿using LibraryManagementSystem2.Helpers;
using LibraryManagementSystem2.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem2
{
    public partial class Frmcategories : Form
    {
        public Frmcategories()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var repo = new CategoriesRepo();
            dgv.DataSource = repo.LoadData();


        }


        private void categories(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var repo = new CategoriesRepo();
            repo.Insert(txtname.Text,txtdescrip.Text);
            LoadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            MainForm undo = new MainForm();
            undo.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtId.Text  =dgv.SelectedRows[0].Cells[0].Value.ToString();
           txtname.Text= dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtdescrip.Text=dgv.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var repo=new CategoriesRepo();
            repo.Update(int.Parse(txtId.Text), txtname.Text,txtdescrip.Text);
            LoadData();
        }
    }
    
}
