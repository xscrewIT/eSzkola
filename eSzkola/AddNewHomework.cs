using System;
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
    public partial class AddNewHomework : Form
    {
        public AddNewHomework()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnX_Click(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zadanie dodane pomyślnie");
            this.Hide();
        }
    }
}
