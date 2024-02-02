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

namespace eSzkola
{
    public partial class Dashboard : Form
    {
        private Connection_Class connection_Class;
        private string username;

        public Dashboard(Connection_Class connection_Class, string username)
        {
            InitializeComponent();
            this.connection_Class = connection_Class;
            this.username = username;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Today.ToString("dd/MM/yyy");
            lblGreetings.Text = ($"Witaj, {username.ToUpper()}");
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
            new SendMessage().ShowDialog();
        }

        private void btnPresenceRaports_Click(object sender, EventArgs e)
        {
            new PresenceRaports().ShowDialog();
        }
    }
}

