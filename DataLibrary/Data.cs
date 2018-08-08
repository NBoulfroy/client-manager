using System;
using System.Collections.Generic;

namespace DataLibrary
{
    [Serializable]
    public class Data
    {
        private List<Customer> customers;

        public Data()
        {
            customers = new List<Customer>();
        }

        #region Accessor

        public List<Customer> GetCustomers() { return customers; }
        public void SetCustomers(List<Customer> customers) { this.customers = customers; }

        #endregion

        #region Property

        public List<Customer> Customers { get { return customers; } }

        #endregion

        #region Methods

        /// <summary>
        /// Adds customer into the Customer list.
        /// </summary>
        /// <param name="customer">A customer object</param>
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(int id)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Customer_id == id)
                {
                    customers.Remove(customers[i]);
                }
            }
        }

        /// <summary>
        /// Updates a customer into the Customer list.
        /// </summary>
        /// <param name="id">Customer's identity</param>
        /// <param name="lastName">Customer's name</param>
        /// <param name="firstName">Customer's christian name</param>
        public void UpdateCustomer(int id, string lastName, string firstName)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Customer_id == id)
                {
                    customer.Customer_id = id;
                    customer.Customer_lastName = lastName.ToUpper();
                    customer.Customer_firstName = firstName;
                }
            }
        }

        #endregion
    }
}
