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
    public partial class ChangeGrades : Form
    {
        private Connection_Class connection_Class;
        private string id_Lekcja;

        public ChangeGrades(Connection_Class connection_Class, string id_Lekcja)
        {
            InitializeComponent();
            this.connection_Class = connection_Class;
            this.id_Lekcja = id_Lekcja;
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
            MessageBox.Show("Zmiany zapisane pomyślnie");
            this.Hide();
        }
    }
}
