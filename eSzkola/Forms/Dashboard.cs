using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eSzkola
{
    public partial class Dashboard : Form
    {
        private Connection_Class connection_Class;

        public Dashboard(Connection_Class connection_Class)
        {
            InitializeComponent();
            this.connection_Class = connection_Class;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string username = connection_Class.Username;
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    SqlCommand cmdFirstName = new SqlCommand($"SELECT imie FROM Nauczyciel WHERE username = '{username}'", conn);
                    SqlCommand cmdLastName = new SqlCommand($"SELECT nazwisko FROM Nauczyciel WHERE username = '{username}'", conn);
                    string FirstName = cmdFirstName.ExecuteScalar().ToString();
                    string LastName = cmdLastName.ExecuteScalar().ToString();

                    lblGreetings.Text = ($"Witaj, {FirstName} {LastName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
            lblCurrentDate.Text = DateTime.Today.ToString("dd/MM/yyy");
            
            lblUserName.Text = username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            connection_Class.CloseConnection();
            Application.Exit();
        }

        private void btnX_Click(object sender, FormClosingEventArgs e)
        {
            connection_Class.CloseConnection();
            Application.Exit();
        }

        private void btnCreateLesson_Click(object sender, EventArgs e)
        {
            CreateLesson createLesson = new CreateLesson(connection_Class);
            createLesson.ShowDialog();
        }

        private void btnCheckPresence_Click(object sender, EventArgs e)
        {
            new CheckPresence(connection_Class).ShowDialog();
        }

        private void btnCheckGrades_Click(object sender, EventArgs e)
        {
            new CheckGrades(connection_Class).ShowDialog();
        }

        private void btnInsertNote_Click(object sender, EventArgs e)
        {
            new AddBehaviourNote(connection_Class).ShowDialog();
        }

        private void btnCreateHomeWork_Click(object sender, EventArgs e)
        {
            new AddNewHomework(connection_Class).ShowDialog();
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            new AddNewTest(connection_Class).ShowDialog();
        }

        private void btnIncommingEvents_Click(object sender, EventArgs e)
        {
            new IncomingEvents(connection_Class).ShowDialog();
        }

        private void btnSentMessage_Click(object sender, EventArgs e)
        {
            new SendMessage(connection_Class).ShowDialog();
        }
    }
}

