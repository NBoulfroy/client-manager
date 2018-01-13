using System;
using System.Configuration;
using System.Data.OleDb;
using ClassLibrary;

namespace DatabaseLibrary
{
    [Serializable]
    public class Access : Database
    {
        private ConnectionStringSettings connectionStringSettings;
        private string connectionString;
        string file;
        string extension;
        private string message;
        private Data data;

        public Access(string connectionStringSettings = "sgbd", string file = "database", string extension = ".mdb")
        {
            this.connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionStringSettings];
            connectionString = this.connectionStringSettings.ConnectionString;
            this.file = file;
            this.extension = extension;
            data = new Data();
        }

        #region Accessors

        public string GetFile() { return file; }
        public string GetExtension() { return extension; }
        public Data GetData() { return data; }
        public string GetMessage() { return message; }

        #endregion

        #region Property

        public string Message { get { return message; } }

        #endregion

        #region Methods

        /// <summary>
        /// Load data from the database.
        /// </summary>
        /// <returns></returns>
        public Data LoadData()
        {
            // Query statement.
            string query = "SELECT customer_id, customer_lastName, customer_firstName FROM customer";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection)
                {
                    CommandType = System.Data.CommandType.Text
                };

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int)reader["customer_id"];
                        string lastName = (string)reader["customer_lastName"];
                        string firstName = (string)reader["customer_firstName"];

                        Customer customer = new Customer(id, lastName, firstName);
                        data.AddCustomer(customer);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    message = e.Message.ToString();
                    // message = "An error is occured, please try again or contact team support.";
                }
                finally
                {
                    connection.Close();
                }
            }

            return data;
        }

        /// <summary>
        /// Add customer in the database and in the memory.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string AddCustomer(string lastName, string firstName)
        {
            // String manipulations.
            string surname = LastNameManipulation(lastName);
            string name = FirstNameManipulation(firstName);
            // Query Statement
            string query = "INSERT INTO customer (customer_lastName, customer_firstName) VALUES (@lastName, @firstName)";

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            OleDbCommand command = new OleDbCommand(query, connection)
            {
                CommandType = System.Data.CommandType.Text
            };
            command.Parameters.AddWithValue("@lastName", surname);
            command.Parameters.AddWithValue("@firstName", name);

            try
            {
                // Connection to the database.
                connection.Open();
                // Execute the first query write previously.
                command.ExecuteNonQuery();
                // Last inserted identity recuperation.
                command.CommandText = "SELECT @@IDENTITY";
                int id = (int)command.ExecuteScalar();

                // Customer added in memory.
                Customer customer = new Customer(id, surname, name);
                data.AddCustomer(customer);
                message = "Customer added with success.";
            }
            catch (Exception e)
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

        /// <summary>
        /// Update customer in the database and in the memory.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string UpdateCustomer(int id, string lastName, string firstName)
        {
            // String manipulations.
            string surname = LastNameManipulation(lastName);
            string name = FirstNameManipulation(firstName);
            // Query statement.
            string query = "UPDATE customer SET customer_lastName = @lastName, customer_firstName = @firstName WHERE customer_id = @id";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Command creation.
                OleDbCommand command = new OleDbCommand(query, connection)
                {
                    CommandType = System.Data.CommandType.Text
                };
                command.Parameters.AddWithValue("@lastName", surname);
                command.Parameters.AddWithValue("@firstName", name);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    // Connection to the database.
                    connection.Open();
                    // Query execution.
                    command.ExecuteNonQuery();

                    data.UpdateCustomer(id, surname, name);
                    message = "Customer updated with success.";
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

        /// <summary>
        /// Delete customer in the database and in the memory by his identity.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteCustomer(int id)
        {
            // Query statement.
            string query = "DELETE * FROM customer WHERE customer.customer_id = @id";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection)
                {
                    CommandType = System.Data.CommandType.Text
                };
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    // Connection to the database.
                    connection.Open();
                    // Query execution.
                    command.ExecuteNonQuery();

                    data.RemoveCustomer(id);
                    message = "Customer deleted with success.";
                }
                catch (Exception e)
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

        #endregion
    }
}
