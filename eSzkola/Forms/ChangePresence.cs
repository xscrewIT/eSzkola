﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSzkola
{
    public partial class ChangePresence : Form
    {
        private Connection_Class connection_Class;
        private string query;
        public ChangePresence(Connection_Class connection_Class, string query)
        {
            InitializeComponent();
            this.connection_Class = connection_Class;
            this.query = query;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnX_Click(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new CheckPresence().ShowDialog();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zmiany zostały zapisane");
            this.Hide();
        }
    }
}
