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
    public partial class ChangeGrades : Form
    {
        private Connection_Class connection_Class;
        private string id_Lekcja;
        DataSet ds = new DataSet();

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
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    for (int row = 0; row < dataGridGrades.Rows.Count - 1; row++)
                    {
                        string gradeMark = dataGridGrades.Rows[row].Cells[3].Value.ToString();
                        string gradeID = dataGridGrades.Rows[row].Cells[0].Value.ToString();

                        if (ds.Tables["Ocena"].Rows[row][3].ToString() == "")
                        {
                            string updateQuery = ($"UPDATE Ocena SET ocena = NULL WHERE id_ocena = {gradeID}");
                            connection_Class.ExecuteQuery(conn, updateQuery);
                        }
                        else
                        {
                            string updateQuery = ($"UPDATE Ocena SET ocena = {gradeMark} WHERE id_ocena = {gradeID}");
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

        private void dataGridGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtFirstName.Text = dataGridGrades.SelectedRows[0].Cells[1].Value.ToString();
                    txtLastName.Text = dataGridGrades.SelectedRows[0].Cells[2].Value.ToString();
                    comboGrade.SelectedItem = dataGridGrades.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void ChangeGrades_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string query = ($"SELECT O.id_ocena, U.imie, U.nazwisko, O.ocena FROM Ocena O INNER JOIN Uczen U ON U.id_uczen = O.id_uczen WHERE id_lekcja = {id_Lekcja}");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    da.Fill(ds, "Ocena");
                    if (ds.Tables["Ocena"].Rows.Count > 0)
                    {
                        dataGridGrades.DataSource = ds.Tables["Ocena"];
                        dataGridGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("W tym dniu użytkownik nie prowadził żadnej lekcji");
                        dataGridGrades.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void comboGrade_DropDownClosed(object sender, EventArgs e)
        {
            int i = dataGridGrades.CurrentCell.RowIndex;
            ds.Tables["Ocena"].Rows[i][3] = comboGrade.Text;
        }
    }
}
