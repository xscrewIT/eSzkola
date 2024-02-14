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
using System.Collections;

namespace eSzkola
{
    public partial class CheckPresence : Form
    {
        private Connection_Class connection_Class;

        public CheckPresence(Connection_Class connection_Class)
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
            if (comboChooseLesson.Text != "")
            {
                List<string> studentID = new List<string>();
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string id_Lekcja = comboChooseLesson.SelectedValue.ToString();

                        string query = ($"SELECT id_uczen FROM Obecnosc WHERE id_lekcji = {id_Lekcja}");
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Obecnosc");
                        if (ds.Tables["Obecnosc"].Rows.Count == 0)
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
                                string insertQuery = ($"INSERT INTO Obecnosc (data, id_uczen, id_lekcji) " +
                                    $"VALUES ('{strSelectedDate}', {ID}, {id_Lekcja})");

                                connection_Class.ExecuteQuery(conn, insertQuery);
                            }
                        }
                        else
                        {
                            this.Hide();
                            new ChangePresence(connection_Class, id_Lekcja).ShowDialog();
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
                    string username = connection_Class.Username;
                    SqlCommand cmdTeacherID = new SqlCommand($"SELECT id_nauczyciel FROM Nauczyciel WHERE username = '{username}'", conn);
                    string strTeacherID = cmdTeacherID.ExecuteScalar().ToString();

                    string strSelectedDate = calendarLessons.SelectionRange.Start.ToString("yyy-MM-dd");
                    string query = ($"SELECT id_lekcja, temat FROM Lekcja WHERE CONVERT(char(10),data_lekcji,120) LIKE '{strSelectedDate}%' AND id_nauczyciel = {strTeacherID}");
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

        private void calendarLessons_DateChanged(object sender, DateRangeEventArgs e)
        {
            comboChooseLesson.DataSource = null;
            comboChooseLesson.Items.Clear();
        }
    }
}
