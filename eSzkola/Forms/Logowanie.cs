using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace eSzkola
{
    public partial class Logowanie : Form
    {
        private Connection_Class connection_Class;

        public Logowanie()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUserName.Text;
            password = txtUserPassword.Text;
            try
            {
                connection_Class = new Connection_Class(username, password);

                SqlConnection connection = connection_Class.OpenConnection();
                if (connection == null) 
                {
                    MessageBox.Show("Niepoprawne dane logowania, spróbuj jeszcze raz!");
                    txtUserPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Po³¹czono z baz¹ danych.");
                    Dashboard dashboard = new Dashboard(connection_Class);
                    dashboard.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }
    }
}
