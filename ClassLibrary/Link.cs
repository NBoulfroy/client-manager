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
            string query = "SELECT customer.customer_id, customer.customer_lastName, customer.customer_firstName FROM customer";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
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
        public string AddCustomer(string lastName, string firstName)
        {
            string word = FirstNameManipulation(firstName);
            // Query Statement
            string query = "INSERT INTO customer (customer_lastName, customer_firstName) VALUES (@lastName, @firstName)";
            
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

                    // Customer added in memory.
                    Customer customer = new Customer(id, lastName, word);
                    data.AddCustomer(customer);
                    message = "Customer added with success.";
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
        /// Update customer in the database and in the memory.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string UpdateCustomer(int id, string lastName, string firstName)
        {
            string word = FirstNameManipulation(firstName);
            // Query statement.
            string query = "UPDATE customer SET customer_lastName = @lastName, customer_firstName = @firstName WHERE customer_id = @id";

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

                    data.UpdateCustomer(id, lastName, word);
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

        public string DeleteCustomer(int id)
        {
            // Query statement.
            string query = "DELETE * FROM customer WHERE customer.customer_id = @id";

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

                    data.SubstractCustomer(id);
                    message = "Customer deleted with success.";
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
