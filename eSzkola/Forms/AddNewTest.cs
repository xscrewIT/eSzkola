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
    public partial class AddNewTest : Form
    {
        private Connection_Class connection_Class;

        public AddNewTest(Connection_Class connection_Class)
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
            if (comboChooseClass.Text != "" && comboTestType.Text != "" && txtTestDescription.Text != "" && !(txtTestDescription.Text.StartsWith(" ")))
            {
                using (SqlConnection conn = connection_Class.OpenConnection())
                {
                    try
                    {
                        string strSchoolClass = comboChooseClass.SelectedValue.ToString();
                        string strTestType = comboTestType.Text;
                        string strTestDescription = txtTestDescription.Text;
                        string strTestDate = calendarTestDate.SelectionRange.Start.ToString("yyyy-MM-dd");

                        string insertQuery = ($"INSERT INTO Test (rodzaj_testu, opis, data_egzaminu, id_klasa) VALUES " +
                            $"('{strTestType}', '{strTestDescription}', '{strTestDate}', {strSchoolClass})");
                        connection_Class.ExecuteQuery(conn, insertQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
                MessageBox.Show("Test zapisany pomyślnie");
                this.Hide();
            }
            else if (comboChooseClass.Text == "")
            {
                MessageBox.Show("Wybierz klasę!");
            }
            else if (comboTestType.Text == "")
            {
                MessageBox.Show("Wybierz rodzaj testu!");
            }
            else if (txtTestDescription.Text == "")
            {
                MessageBox.Show("Podaj zakres materiału!");
            }
            else if (txtTestDescription.Text.StartsWith(" "))
            {
                MessageBox.Show("Zakres materiału nie może zaczynać się od spacji! ");
                txtTestDescription.Text = "Podaj zakres...";
            }
        }

        private void AddNewTest_Load(object sender, EventArgs e)
        {
            calendarTestDate.MinDate = DateTime.Now;
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

        private void txtTestDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyZzŹźŻż,-:.!?\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
