using System;
using DataLibrary;
using System.Data.OleDb;
using Dapper;
using System.Configuration;

namespace DatabaseLibrary
{
    [Serializable]
    public class Database 
    {
        private readonly ConnectionStringSettings connectionStringSettings;
        private readonly string connectionString;
        private readonly string file;
        private readonly string extension;
        private string message;
        private Data data;

        public Database(string connectionStringSettings = "sgbd", string file = "database", string extension = ".mdb")
        {
            this.connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionStringSettings];
            connectionString = this.connectionStringSettings.ConnectionString;
            this.file = file;
            this.extension = extension;
            message = "";
            data = new Data();
        }

        #region Accessors

        public Data GetData()
        {
            return data;
        }

        public string GetMessage()
        {
            return message;
        }

        #endregion

        #region Methods

        public string LoadData()
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                try
                {
                    data.SetCustomers(connection.Query<Customer>("SELECT * FROM Customer").AsList());
                }
                catch (Exception e)
                {
                    message = e.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                return message;
            }
        }

        /// <summary>
        /// Adds a customer into database and in memory.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string AddCustomer(string lastName, string firstName)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var insertion = connection.Execute(
                        "INSERT INTO customer (customer_lastName, customer_firstName) VALUES (@lastName, @firstName)",
                        new { lastName = LastNameManipulation(lastName), firstName = FirstNameManipulation(firstName) }
                    );

                    var id = connection.Query<int>("SELECT @@Identity").AsList();

                    // Defines new customer.
                    Customer customer = new Customer
                    {
                        Customer_id = id[0],
                        Customer_lastName = LastNameManipulation(lastName),
                        Customer_firstName = FirstNameManipulation(firstName)
                    };

                    // Insertion into data List.
                    data.AddCustomer(customer);

                    message = "Customer added with success.";
                }
                catch (Exception e)
                {
                    message = e.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                return message;
            }
        }

        /// <summary>
        /// Updates a customer into database and in memory.
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string UpdateCustomer(int identity, string lastName, string firstName)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var insertion = connection.Execute(
                        "UPDATE customer SET customer_lastName = @lastName, customer_firstName = @firstName WHERE customer_id = @id",
                        new { lastName = LastNameManipulation(lastName), firstName = FirstNameManipulation(firstName), id = identity }
                    );

                    // Updates into data List.
                    data.UpdateCustomer(identity, LastNameManipulation(lastName), FirstNameManipulation(firstName));

                    message = "Customer updated with success.";
                }
                catch (Exception e)
                {
                    message = e.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                return message;
            }
        }

        /// <summary>
        /// Removes a customer into database and in memory.
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public string RemoveCustomer(int identity)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var insertion = connection.Execute(
                        "DELETE FROM customer WHERE customer_id = @id",
                        new { id = identity }
                    );

                    // Deletion into data List.
                    data.RemoveCustomer(identity);

                    message = "Customer deleted with success.";
                }
                catch (Exception e)
                {
                    message = e.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }

                return message;
            }
        }

        /// <summary>
        /// Returns string like "Nicolas" or "Pierre-Robert".
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        private static string FirstNameManipulation(string firstName)
        {
            string manipulation;

            if (firstName.Contains("-"))
            {
                string[] words = firstName.Split('-');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 1).ToLower() + "-";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 1);
                    }
                }

                return manipulation;
            }
            else
            {
                string firstName_begin = firstName.Substring(0, 1).ToUpper();
                string firstName_end = firstName.Substring(1, firstName.Length - 1);
                return manipulation = firstName_begin + firstName_end;
            }
        }

        /// <summary>
        /// Returns string like "BOULFROY", "DE MONTMORENCY" and "DUPONT-SMITH.
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        private static string LastNameManipulation(string lastName)
        {
            string manipulation;
            manipulation = "";

            if (lastName.Contains(" "))
            {
                string[] words = lastName.Split(' ');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, words[i].Length).ToUpper() + " ";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 1);
                    }
                }
            }

            if (lastName.Contains("-"))
            {
                string[] words = lastName.Split('-');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, words[i].Length).ToUpper() + "-";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 1);
                    }
                }
            }

            if (lastName.Contains(" de ") || lastName.Contains(" DE ") || lastName.Contains(" dE ") || lastName.Contains(" De "))
            {
                string[] words = lastName.Split('-');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, words[i].Length).ToUpper() + " DE ";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 4);
                    }
                }
            }

            return manipulation = lastName.ToUpper();
        }

        #endregion
    }
}
