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
