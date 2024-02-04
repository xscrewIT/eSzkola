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
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace eSzkola
{
    public partial class ChangePresence : Form
    {
        private Connection_Class connection_Class;
        private string id_Lekcja;
        DataSet ds = new DataSet();

        public ChangePresence(Connection_Class connection_Class, string id_Lekcja)
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
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    for (int row = 0; row < dataGridPresence.Rows.Count - 1; row++)
                    {
                        string presenceOption = dataGridPresence.Rows[row].Cells[3].Value.ToString();
                        string presenceNotes = dataGridPresence.Rows[row].Cells[4].Value.ToString();
                        string presenceID = dataGridPresence.Rows[row].Cells[0].Value.ToString();

                        if (ds.Tables["Obecnosc"].Rows[row][4].ToString() == "")
                        {
                            string updateQuery = ($"UPDATE Obecnosc SET obecnosc = '{presenceOption}', uwagi = NULL WHERE id_obecnosc = {presenceID}");
                            connection_Class.ExecuteQuery(conn, updateQuery);
                        }
                        else
                        {
                            string updateQuery = ($"UPDATE Obecnosc SET obecnosc = '{presenceOption}', uwagi = '{presenceNotes}' WHERE id_obecnosc = {presenceID}");
                            connection_Class.ExecuteQuery(conn, updateQuery);
                        }
                    }
                    MessageBox.Show("Zmiany zostały zapisane");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void ChangePresence_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string query = ($"SELECT O.id_obecnosc, U.imie, U.nazwisko, O.obecnosc, O.uwagi  FROM Obecnosc O INNER JOIN Uczen U ON U.id_uczen = O.id_uczen WHERE id_lekcji = {id_Lekcja}");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    da.Fill(ds, "Obecnosc");
                    if (ds.Tables["Obecnosc"].Rows.Count > 0)
                    {
                        dataGridPresence.DataSource = ds.Tables["Obecnosc"];
                        dataGridPresence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("W tym dniu użytkownik nie prowadził żadnej lekcji");
                        dataGridPresence.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void dataGridPresence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtFirstName.Text = dataGridPresence.SelectedRows[0].Cells[1].Value.ToString();
                    txtLastName.Text = dataGridPresence.SelectedRows[0].Cells[2].Value.ToString();
                    comboPresence.SelectedItem = dataGridPresence.SelectedRows[0].Cells[3].Value.ToString();
                    txtAddNote.Text = dataGridPresence.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void comboPresence_DropDownClosed(object sender, EventArgs e)
        {
            int i = dataGridPresence.CurrentCell.RowIndex;
            ds.Tables["Obecnosc"].Rows[i][3] = comboPresence.Text;
        }

        private void txtAddNote_Leave(object sender, EventArgs e)
        {
            int i = dataGridPresence.CurrentCell.RowIndex;
            ds.Tables["Obecnosc"].Rows[i][4] = txtAddNote.Text;
        }

        private void txtAddNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-,.!?\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
