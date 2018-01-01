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
        private OleDbConnection connection;
        private Data data;
        private string message;

        public Link()
        {
            this.connectionStringSettings = ConfigurationManager.ConnectionStrings["access"];
            connectionString = this.connectionStringSettings.ConnectionString;
            connection = new OleDbConnection(connectionString);
            data = new Data();
        }

        #region Methods

        public Data LoadData()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("getAllClients", connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            OleDbDataReader cursor = command.ExecuteReader();

            while (cursor.Read())
            {
                int id = (int)cursor["client_id"];
                string lastName = (string)cursor["client_lastName"];
                string firstName = (string)cursor["client_firstName"];

                Client client = new Client(id, lastName, firstName);
                data.AddClient(client);
            }

            cursor.Close();
            connection.Close();

            return data;
        }

        public string AddClient(string lastName, string firstName)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("insertClient", connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("lastName", lastName.ToUpper());
            command.Parameters.AddWithValue("firstName", firstName);

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                message = "An error is occured, please try again or contact team support.";
            }
            finally
            {
                connection.Close();
                int id = data.GetClients().Count + 2;
                Client client = new Client(id, lastName.ToUpper(), firstName);
                data.AddClient(client);
                message = "Client added with success.";
            }

            return message;
        }

        public string UpdateClient(int id, string lastName, string firstName)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("updateClient", connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("lastName", lastName.ToUpper());
            command.Parameters.AddWithValue("firstName", firstName);

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                message = "An error is occured, please try again or contact team support.";
            }
            finally
            {
                connection.Close();
                data.UpdateClient(id, lastName.ToUpper(), firstName);
                message = "Client updated with success.";
            }

            return message;
        }

        public string DeleteClient(int id)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("deleteClient", connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("id", id);

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                message = "An error is occured, please try again or contact team support.";
            }
            finally
            {
                connection.Close();
                data.SubstractClient(id);
                message = "Client deleted with success.";
            }

            return message;
        }

        #endregion
    }
}
