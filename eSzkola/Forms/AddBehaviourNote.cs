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
using System.Text.RegularExpressions;

namespace eSzkola
{
    public partial class AddBehaviourNote : Form
    {
        private Connection_Class connection_Class;

        public AddBehaviourNote(Connection_Class connection_Class)
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
            if (comboChooseClass.Text != "" && comboChooseStudent.Text != "" && txtBehaviourNote.Text != "" && !(txtBehaviourNote.Text.StartsWith(" ")))
            {
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string username = connection_Class.Username;
                        SqlCommand cmdTeacherID = new SqlCommand($"SELECT id_nauczyciel FROM Nauczyciel WHERE username = '{username}'", conn);
                        string strTeacherID = cmdTeacherID.ExecuteScalar().ToString();

                        string strSchoolClass = comboChooseClass.Text;
                        string strStudentID = comboChooseStudent.SelectedValue.ToString();
                        string strNoteDate = calendarAddNoteDate.SelectionRange.Start.ToString("yyyy-MM-dd " + DateTime.Now.ToString("HH:mm:ss"));
                        string strNote = txtBehaviourNote.Text;

                        string insertQuery = ($"INSERT INTO Uwagi (uwaga, data, id_nauczyciel, id_uczen) VALUES" +
                            $"('{strNote}', '{strNoteDate}', {strTeacherID}, {strStudentID})");
                        connection_Class.ExecuteQuery(conn, insertQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
                MessageBox.Show("Uwaga zapisana pomyślnie");
                this.Hide();
            }
            else if (comboChooseClass.Text == "")
            {
                MessageBox.Show("Wybierz klasę!");
            }
            else if (comboChooseStudent.Text == "")
            {
                MessageBox.Show("Wybierz ucznia!");
            }
            else if (txtBehaviourNote.Text == "")
            {
                MessageBox.Show("Wpisz treść uwagi");
                txtBehaviourNote.Text = "Wpisz treść...";
            }
            else if (txtBehaviourNote.Text.StartsWith(" "))
            {
                MessageBox.Show("Uwaga nie może zaczynać się od spacji! ");
                txtBehaviourNote.Text = "Wpisz poprawną treść...";
            }
        }

        private void comboChooseClass_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string query = "SELECT id_klasa, nr_klasy FROM Klasa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Klasa");
                    comboChooseClass.DataSource = ds.Tables["Klasa"];
                    comboChooseClass.DisplayMember = "nr_klasy";
                    comboChooseClass.ValueMember = "id_klasa";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void comboChooseStudent_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string id_Klasa = comboChooseClass.SelectedValue.ToString();
                    string query = ($"SELECT id_uczen, imie, nazwisko FROM Uczen WHERE id_klasa = {id_Klasa}");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Uczen");
                    ds.Tables[0].Columns.Add("FullName", typeof(string), "imie + ' ' + nazwisko");
                    comboChooseStudent.DataSource = ds.Tables["Uczen"];
                    comboChooseStudent.DisplayMember = "FullName";
                    comboChooseStudent.ValueMember = "id_uczen";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void txtBehaviourNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyZzŹźŻż,-:.!?\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
