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
    public partial class IncomingEvents : Form
    {
        private Connection_Class connection_Class;
        public IncomingEvents(Connection_Class connection_Class)
        {
            InitializeComponent();
            this.connection_Class = connection_Class;
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
            this.Hide();
        }

        private void IncomingEvents_Load(object sender, EventArgs e)
        {
            dataGridIncomingHomework.AllowUserToDeleteRows = false;
            dataGridIncomingHomework.AllowUserToAddRows = false;

            dataGridIncomingTest.AllowUserToDeleteRows = false;
            dataGridIncomingTest.AllowUserToAddRows = false;

            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string query = ($"SELECT data_wykonania, opis_zadania FROM Zadanie_domowe WHERE data_wykonania >= CONVERT(varchar, CONVERT(date, getDate())) ORDER BY data_wykonania");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Zadanie");
                    if (ds.Tables["Zadanie"].Rows.Count > 0)
                    {
                        dataGridIncomingHomework.DataSource = ds.Tables["Zadanie"];
                        dataGridIncomingHomework.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Brak nadchodzących zadań domowych");
                        dataGridIncomingHomework.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }

            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string query = ($"SELECT data_egzaminu, rodzaj_testu, opis FROM Test WHERE data_egzaminu >= CONVERT(varchar, CONVERT(date, getDate())) ORDER BY data_egzaminu");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Test");
                    if (ds.Tables["Test"].Rows.Count > 0)
                    {
                        dataGridIncomingTest.DataSource = ds.Tables["Test"];
                        dataGridIncomingTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Brak nadchodzących egzaminów");
                        dataGridIncomingTest.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }
    }
}
