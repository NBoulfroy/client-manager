using System;
using System.Configuration;
using System.Data.OleDb;

namespace ClassLibrary
{
    [Serializable]
    public class Link
    {
        private ConnectionStringSettings connectionStringSettings;
        private string connectionString;
        private Data data;
        private string message;

        public Link()
        {
            connectionStringSettings = ConfigurationManager.ConnectionStrings["sgbd"];
            connectionString = this.connectionStringSettings.ConnectionString;
            data = new Data();
        }

        #region Accessors

        public Data GetData() { return data; }
        public string GetMessage() { return message; }

        #endregion

        #region Methods

        /// <summary>
        /// Load data from the database.
        /// </summary>
        /// <returns></returns>
        public Data LoadData()
        {
            // Query statement
            string query = "SELECT client.client_id, client.client_lastName, client.client_firstName FROM client";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int)reader["client_id"];
                        string lastName = (string)reader["client_lastName"];
                        string firstName = (string)reader["client_firstName"];

                        Client client = new Client(id, lastName, firstName);
                        data.AddClient(client);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    // message = e.Message.ToString();
                    message = "An error is occured, please try again or contact team support.";
                }
                finally
                {
                    connection.Close();
                }
            }

            return data;
        }

        /// <summary>
        /// Add client in the database and in the memory.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string AddClient(string lastName, string firstName)
        {
            string word = FirstNameManipulation(firstName);
            // Query Statement
            string query = "INSERT INTO client (client_lastName, client_firstName) VALUES (@lastName, @firstName)";
            
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@lastName", lastName.ToUpper());
                command.Parameters.AddWithValue("@firstName", word);

                try
                {
                    // Connection to the database.
                    connection.Open();
                    // Execute the first query write previously.
                    command.ExecuteNonQuery();
                    // Last inserted identity recuperation.
                    command.CommandText = "SELECT @@IDENTITY";
                    int id = (int)command.ExecuteScalar();

                    // Client added in memory.
                    Client client = new Client(id, lastName, word);
                    data.AddClient(client);
                    message = "Client added with success.";
                }
                catch(Exception e)
                {
                    // message = e.Message.ToString();
                    message = "An error is occured, please try again or contact team support.";
                }
                finally
                {
                    connection.Close();
                }
            }

            return message;
        }

        /// <summary>
        /// Update client in the database and in the memory.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string UpdateClient(int id, string lastName, string firstName)
        {
            string word = FirstNameManipulation(firstName);
            // Query statement.
            string query = "UPDATE client SET client_lastName = @lastName, client_firstName = @firstName WHERE client_id = @id";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Command creation.
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@lastName", lastName.ToUpper());
                command.Parameters.AddWithValue("@firstName", word);

                try
                {
                    // Connection to the database.
                    connection.Open();
                    // Query execution.
                    command.ExecuteNonQuery();

                    data.UpdateClient(id, lastName, word);
                    message = "Client updated with success.";
                }
                catch(Exception e)
                {
                    message = e.Message.ToString();
                    // message = "An error is occured, please try again or contact team support.";
                }
                finally
                {
                    connection.Close();
                }
            }

            return message;
        }

        public string DeleteClient(int id)
        {
            // Query statement.
            string query = "DELETE * FROM client WHERE client.client_id = @id";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    // Connection to the database.
                    connection.Open();
                    // Query execution.
                    command.ExecuteNonQuery();

                    data.SubstractClient(id);
                    message = "Client deleted with success.";
                }
                catch (Exception e)
                {
                    // message = e.Message.ToString();
                    message = "An error is occured, please try again or contact team support.";
                }
                finally
                {
                    connection.Close();
                }
            }

            return message;
        }

        /// <summary>
        /// Return string like "Nicolas".
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        private static string FirstNameManipulation(string firstName)
        {
            string firstName_begin = firstName.Substring(0, 1).ToUpper();
            string firstName_end = firstName.Substring(1, firstName.Length - 1);
            string word = firstName_begin + firstName_end;
            return word;
        }

        #endregion
    }
}
