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
using System.CodeDom;

namespace eSzkola
{
    public partial class SendMessage : Form
    {
        private Connection_Class connection_Class;
        public SendMessage(Connection_Class connection_Class)
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (comboRecipientType.Text != "" && comboRecipient.Text != "" && txtMsgSubject.Text != "" && !(txtMsgSubject.Text.StartsWith(" ")) && txtMessage.Text != "" && !(txtMessage.Text.StartsWith(" ")))
            {
                string recipientType = comboRecipientType.SelectedIndex.ToString(); //0 - uczen, 1 - rodzic
                switch (recipientType)
                {
                    case "0":
                        using (SqlConnection conn = connection_Class.OpenConnection())
                        {
                            try
                            {
                                string strMsgSubject = txtMsgSubject.Text;
                                string strMessage = txtMessage.Text;
                                string strMsgDate = DateTime.Now.ToString("yyyy-MM-dd");
                                string strIdStudent = comboRecipient.SelectedValue.ToString();
                                string strIdTeacher = "1";

                                string insertQuery = ($"INSERT INTO Wiadomosci (temat, tresc_Wiadomosci, data, id_uczen, id_nauczyciel) VALUES " +
                                    $"('{strMsgSubject}', '{strMessage}', '{strMsgDate}', {strIdStudent}, {strIdTeacher})");

                                connection_Class.ExecuteQuery(conn, insertQuery);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error: {ex}");
                            }
                        }
                        break;
                    case "1":
                        using (SqlConnection conn = connection_Class.OpenConnection())
                        {
                            try
                            {
                                string strMsgSubject = txtMsgSubject.Text;
                                string strMessage = txtMessage.Text;
                                string strMsgDate = DateTime.Now.ToString("yyyy-MM-dd");
                                string strIdParent = comboRecipient.SelectedValue.ToString();
                                string strIdTeacher = "1";

                                string insertQuery = ($"INSERT INTO Wiadomosci (temat, tresc_Wiadomosci, data, id_rodzic, id_nauczyciel) VALUES " +
                                    $"('{strMsgSubject}', '{strMessage}', '{strMsgDate}', {strIdParent}, {strIdTeacher})");

                                connection_Class.ExecuteQuery(conn, insertQuery);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error: {ex}");
                            }
                        }
                        break;
                }

                MessageBox.Show("Wiadomość wysłana pomyślnie");
                this.Hide();
            }
            else if (comboRecipientType.Text == "")
            {
                MessageBox.Show("Wybierz do kogo wysyłasz wiadomość!");
            }
            else if (comboRecipient.Text == "")
            {
                MessageBox.Show("Wybierz odbiorcę!");
            }
            else if (txtMsgSubject.Text == "")
            {
                MessageBox.Show("Podaj temat wiadomości!");
            }
            else if (txtMsgSubject.Text.StartsWith(" "))
            {
                MessageBox.Show("Temat wiadomości nie może zaczynać się od spacji! ");
                txtMsgSubject.Text = "Wpisz temat...";
            }
            else if (txtMessage.Text == "")
            {
                MessageBox.Show("Wpisz treść wiadomości!");
            }
            else if (txtMessage.Text.StartsWith(" "))
            {
                MessageBox.Show("Wiadomość nie może zaczynać się od spacji! ");
                txtMessage.Text = "Wpisz treść...";
            }
        }

        private void comboRecipient_DropDown(object sender, EventArgs e)
        {
            string recipientType = comboRecipientType.SelectedIndex.ToString(); //0 - uczen, 1 - rodzic
            switch (recipientType)
            {
                case "0":
                    using (SqlConnection conn = connection_Class.OpenConnection())
                    {
                        try
                        {
                            string query = ($"SELECT id_uczen, nr_klasy, imie, nazwisko FROM Uczen AS U INNER JOIN Klasa AS K ON K.id_klasa = U.id_klasa");
                            SqlDataAdapter da = new SqlDataAdapter(query, conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Odbiorca");
                            if (ds.Tables["Odbiorca"].Rows.Count > 0)
                            {
                                ds.Tables[0].Columns.Add("Recipient", typeof(string), "nr_klasy + ' ' + imie + ' ' + nazwisko");
                                comboRecipient.DataSource = ds.Tables["Odbiorca"];
                                comboRecipient.DisplayMember = "Recipient";
                                comboRecipient.ValueMember = "id_uczen";
                            }
                            else
                            {
                                MessageBox.Show("Brak odbiorców w wybranym zbiorze");
                                comboRecipient.DataSource = null;
                                comboRecipient.Items.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex}");
                        }
                    }
                    break;
                case "1":
                    using (SqlConnection conn = connection_Class.OpenConnection())
                    {
                        try
                        {
                            string query = ($"SELECT R.id_rodzic AS id_rodzic, K.nr_klasy AS nr_klasy, R.imie AS imie, R.nazwisko AS nazwisko FROM Rodzic R ") +
                                ($"INNER JOIN Uczen U ON U.id_rodzic = R.id_rodzic INNER JOIN Klasa K ON K.id_klasa = U.id_klasa");
                            SqlDataAdapter da = new SqlDataAdapter(query, conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Odbiorca");
                            if (ds.Tables["Odbiorca"].Rows.Count > 0)
                            {
                                ds.Tables[0].Columns.Add("Recipient", typeof(string), "nr_klasy + ' ' + imie + ' ' + nazwisko");
                                comboRecipient.DataSource = ds.Tables["Odbiorca"];
                                comboRecipient.DisplayMember = "Recipient";
                                comboRecipient.ValueMember = "id_rodzic";
                            }
                            else
                            {
                                MessageBox.Show("Brak odbiorców w wybranym zbiorze");
                                comboRecipient.DataSource = null;
                                comboRecipient.Items.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex}");
                        }
                    }
                    break;
            }
        }
    }
}
