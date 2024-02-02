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
    public partial class CheckGrades : Form
    {
        private Connection_Class connection_Class;

        public CheckGrades(Connection_Class connection_Class)
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
            if (comboChooseLesson.Text != "")
            {
                List<string> studentID = new List<string>();
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string id_Lekcja = comboChooseLesson.SelectedValue.ToString();

                        string query = ($"SELECT id_uczen FROM Ocena WHERE id_lekcja = {id_Lekcja}");
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Ocena");
                        if (ds.Tables["Ocena"].Rows.Count == 0)
                        {
                            using (SqlCommand cmdStudentID = new SqlCommand($"SELECT id_uczen FROM Uczen WHERE id_klasa = (SELECT id_klasy FROM Lekcja WHERE id_lekcja = {id_Lekcja})", conn))
                            {
                                using (SqlDataReader reader = cmdStudentID.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string item = reader["id_uczen"].ToString();
                                        studentID.Add(item);
                                    }
                                }
                            }
                            foreach (string ID in studentID)
                            {
                                string strSelectedDate = calendarLessons.SelectionRange.Start.ToString("yyy-MM-dd");
                                string insertQuery = ($"INSERT INTO Ocena (id_lekcja, id_uczen, data, id_przedmiot) VALUES" +
                                    $"({id_Lekcja}, {ID}, '{strSelectedDate}', 1 )");

                                connection_Class.ExecuteQuery(conn, insertQuery);
                            }
                        }
                        else
                        {
                            this.Hide();
                            new ChangeGrades(connection_Class, id_Lekcja).ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
            }
            else if (comboChooseLesson.Text == "")
            {
                MessageBox.Show("Wybierz lekcję!");
            }
        }

        private void comboChooseLesson_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection_Class.OpenConnection())
            {
                try
                {
                    string strSelectedDate = calendarLessons.SelectionRange.Start.ToString("yyy-MM-dd");
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
    }
}
