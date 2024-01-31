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
    public partial class CreateLesson : Form
    {
        public CreateLesson()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new Dashboard(connection_Class, username).Show();
            // dashboard = new Dashboard(connection_Class, username);
            //dashboard.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new Dashboard(connection_Class, username).Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(username);
            MessageBox.Show("Lekcja utworzona pomyślnie");
            this.Hide();
        }
    }
}
