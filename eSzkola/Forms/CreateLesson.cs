using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if(comboSchoolSubjects.Text != "" && comboClass.Text != "" && txtSubject.Text != "" && !(txtSubject.Text.StartsWith(" ")))
            {
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string strSchoolSubject = comboSchoolSubjects.Text;
                        string strSchoolClass = comboClass.Text;
                        string strSchoolLessonSubject = txtSubject.Text;
                        string strSchoolLessonDate = calendarCreateLesson.SelectionRange.Start.ToString("yyyy-MM-dd " + DateTime.Now.ToString("HH:mm:ss"));
                        SqlCommand cmdClassID = new SqlCommand($"SELECT id_klasa FROM Klasa WHERE nr_klasy = '{strSchoolClass}'", conn);
                        string strClassID = cmdClassID.ExecuteScalar().ToString();
                        string insertQuery = ($"INSERT INTO Lekcja (data_lekcji, id_klasy, id_przedmiotu, temat, id_nauczyciel, id_sala) " +
                            $"VALUES ('{strSchoolLessonDate}', {strClassID}, 1, '{strSchoolLessonSubject}', 1, 1)");
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
            else if(comboSchoolSubjects.Text == "")
            {
                MessageBox.Show("Wybierz przedmiot!");
            }
            else if(comboClass.Text == "")
            {
                MessageBox.Show("Wybierz klasę!");
            }
            else if(txtSubject.Text == "")
            {
                MessageBox.Show("Wpisz temat ");
            }
            else if(txtSubject.Text.StartsWith(" "))
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
                    string query = "SELECT nazwa_przedmiotu FROM Przedmiot WHERE id_przedmiot = (SELECT id_nauczyciel FROM Nauczyciel WHERE id_przedmiot = 1)";
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
                    string query = "SELECT nr_klasy FROM Klasa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Klasa");
                    comboClass.DataSource = ds.Tables["Klasa"];
                    comboClass.DisplayMember = "Numer klasy";
                    comboClass.ValueMember = "nr_klasy";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }
    }
}
