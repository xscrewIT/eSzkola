using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace eSzkola
{
    public partial class CreateLesson : Form
    {

        private Connection_Class connection_Class;

        public CreateLesson(Connection_Class connection_Class)
        {
            InitializeComponent();
            this.connection_Class = connection_Class;
        }

        private void btnX_Click(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9]");
            if (comboSchoolSubjects.Text != "" && comboClass.Text != "" && txtSubject.Text != "" && !(txtSubject.Text.StartsWith(" ")))
            {
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string username = connection_Class.Username;
                        SqlCommand cmdSchoolSubjectID = new SqlCommand($"SELECT id_przedmiot FROM Nauczyciel WHERE username = '{username}'", conn);
                        string strSchoolSubjectID = cmdSchoolSubjectID.ExecuteScalar().ToString();

                        SqlCommand cmdTeacherID = new SqlCommand($"SELECT id_nauczyciel FROM Nauczyciel WHERE username = '{username}'", conn);
                        string strTeacherID = cmdTeacherID.ExecuteScalar().ToString();

                        string strSchoolSubject = comboSchoolSubjects.Text;
                        string strSchoolLessonSubject = txtSubject.Text;
                        string strSchoolLessonDate = calendarCreateLesson.SelectionRange.Start.ToString("yyyy-MM-dd " + DateTime.Now.ToString("HH:mm:ss"));

                        string strClassID = comboClass.SelectedValue.ToString();

                        SqlCommand cmdClassroomID = new SqlCommand($"SELECT id_sala FROM Sala S " +
                            $"INNER JOIN Rodzaj_sali RS ON RS.id_typ_Rodzaj_sali = S.id_typ_sali " +
                            $"INNER JOIN Przedmiot P ON P.id_Rodzaj_sali = S.id_typ_sali " +
                            $"INNER JOIN Nauczyciel N ON N.id_przedmiot = P.id_przedmiot WHERE N.username = '{username}'", conn);
                        string strClassroomID = cmdClassroomID.ExecuteScalar().ToString();

                        string insertQuery = ($"INSERT INTO Lekcja (data_lekcji, id_klasy, id_przedmiotu, temat, id_nauczyciel, id_sala) " +
                            $"VALUES ('{strSchoolLessonDate}', {strClassID}, {strSchoolSubjectID}, '{strSchoolLessonSubject}', {strTeacherID}, {strClassroomID})");
                        connection_Class.ExecuteQuery(conn, insertQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
                MessageBox.Show("Lekcja utworzona pomyślnie");
                this.Hide();
            }
            else if (comboSchoolSubjects.Text == "")
            {
                MessageBox.Show("Wybierz przedmiot!");
            }
            else if (comboClass.Text == "")
            {
                MessageBox.Show("Wybierz klasę!");
            }
            else if (txtSubject.Text == "")
            {
                MessageBox.Show("Wpisz temat ");
            }
            else if (txtSubject.Text.StartsWith(" "))
            {
                MessageBox.Show("Temat nie może zaczynać się od spacji! ");
                txtSubject.Text = "Wpisz temat...";
            }
        }

        private void comboSchoolSubjects_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string username = connection_Class.Username;
                    SqlCommand cmdSchoolSubjectID = new SqlCommand($"SELECT id_przedmiot FROM Nauczyciel WHERE username = '{username}'", conn);
                    string strSchoolSubjectID = cmdSchoolSubjectID.ExecuteScalar().ToString();

                    string query = ($"SELECT nazwa_przedmiotu FROM Przedmiot WHERE id_przedmiot = {strSchoolSubjectID}");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Przedmiot");
                    comboSchoolSubjects.DataSource = ds.Tables["Przedmiot"];
                    comboSchoolSubjects.DisplayMember = "Nazwa Przedmiotu";
                    comboSchoolSubjects.ValueMember = "nazwa_przedmiotu";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void comboClass_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string query = "SELECT id_klasa, nr_klasy FROM Klasa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Klasa");
                    comboClass.DataSource = ds.Tables["Klasa"];
                    comboClass.DisplayMember = "nr_klasy";
                    comboClass.ValueMember = "id_klasa";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-,.!?\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
