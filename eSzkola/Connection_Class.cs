using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eSzkola
{
    public class Connection_Class
    {
        private string connectionString, username, password;
        private SqlConnection connection;

        public Connection_Class(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.connectionString = ($"Data Source=SCREWIT-PC;Initial Catalog=eSzkola;User ID={username};Password={password}");
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Połączono z bazą danych.");
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas nawiązywania połączenia: {ex.Message}");
                return null;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    MessageBox.Show("Zamknięto połączenie z bazą danych.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zamykania połączenia: {ex.Message}");
            }
        }

        public void ExecuteQuery(SqlConnection connection, string query)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Zapytanie SQL zostało wykonane pomyślnie.");
                }
                else
                {
                    MessageBox.Show("Błąd: Połączenie nie jest otwarte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania zapytania SQL: {ex.Message}");
            }
        }
    }
}
            //// Przykładowy connection string
            //string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;User Id=YourUsername;Password=YourPassword;";

            //// Utwórz instancję klasy SqlConnectionManager
            //Connection_Class connection_Class = new Connection_Class(connectionString);

            //// Otwórz połączenie
            //SqlConnection connection = Connection_Class.OpenConnection();

            //// Przykładowe zapytanie SQL
            //string query = "SELECT * FROM YourTable";

            //// Wykonaj zapytanie SQL
            //connection_Class.ExecuteQuery(connection, query);

            //// Zamknij połączenie
            //connection_Class.CloseConnection(connection);
