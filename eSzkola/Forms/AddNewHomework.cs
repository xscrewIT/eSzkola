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
    public partial class AddNewHomework : Form
    {
        private Connection_Class connection_Class;

        public AddNewHomework(Connection_Class connection_Class)
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
            if (comboChooseLesson.Text != "" && txtHomeworkDescription.Text != "" && !(txtHomeworkDescription.Text.StartsWith(" ")))
            {
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string strSchoolLessonID = comboChooseLesson.SelectedValue.ToString();
                        string strHomeworkDescription = txtHomeworkDescription.Text;
                        string strHomeworkDeadlineDate = calendarHomeworkDeadline.SelectionRange.Start.ToString("yyyy-MM-dd ");

                        string insertQuery = ($"INSERT INTO Zadanie_domowe (opis_zadania, data_wykonania, id_lekcja) VALUES" +
                            $"('{strHomeworkDescription}', '{strHomeworkDeadlineDate}', {strSchoolLessonID})");
                        connection_Class.ExecuteQuery(conn, insertQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
                MessageBox.Show("Zadanie domowe zapisane pomyślnie");
                this.Hide();
            }
            else if (comboChooseLesson.Text == "")
            {
                MessageBox.Show("Wybierz lekcję!");
            }
            else if (txtHomeworkDescription.Text == "")
            {
                MessageBox.Show("Podaj opis wymagań zadania");
                txtHomeworkDescription.Text = "Wpisz treść...";
            }
            else if (txtHomeworkDescription.Text.StartsWith(" "))
            {
                MessageBox.Show("Opis wymagań nie może zaczynać się od spacji! ");
                txtHomeworkDescription.Text = "Wpisz poprawny opis...";
            }
        }

        private void comboChooseLesson_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string strSelectedDate = calendarHomeworkDeadline.SelectionRange.Start.ToString("yyy-MM-dd");
                    string query = ($"SELECT id_lekcja, temat FROM Lekcja WHERE CONVERT(char(10),data_lekcji,120) LIKE '{strSelectedDate}%' AND id_nauczyciel = 1");
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Lekcja");
                    if (ds.Tables["Lekcja"].Rows.Count > 0)
                    {
                        comboChooseLesson.DataSource = ds.Tables["Lekcja"];
                        comboChooseLesson.DisplayMember = "temat";
                        comboChooseLesson.ValueMember = "id_lekcja";
                    }
                    else
                    {
                        MessageBox.Show("W tym dniu użytkownik nie prowadził żadnej lekcji");
                        comboChooseLesson.DataSource = null;
                        comboChooseLesson.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }

        private void AddNewHomework_Load(object sender, EventArgs e)
        {
            calendarHomeworkDeadline.MinDate = DateTime.Now;
        }
    }
}
