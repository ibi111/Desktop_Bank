﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_bank
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Addaccount add = new Addaccount();
            add.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAccount d = new DeleteAccount();
            d.Show();

        }
    }
}
