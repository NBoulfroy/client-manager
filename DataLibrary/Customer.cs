using System;

namespace DataLibrary
{
    [Serializable]
    public class Customer
    {
        private int id;
        private string lastName;
        private string firstName;

        public Customer(int id, string lastName, string firstName)
        {
            this.id = id;
            this.lastName = lastName.ToUpper();
            this.firstName = firstName;
        }

        #region Accessors

        public int GetId() { return id; }
        public string GetLastName() { return lastName; }
        public string GetFirstName() { return firstName; }

        public void SetId(int id) { this.id = id; }
        public void SetLastName(string lastName) { this.lastName = lastName; }
        public void SetFirstName(string firstName) { this.firstName = firstName; }

        #endregion

        #region Properties

        public int Id { get { return id; } set { id = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }

        #endregion
    }
}
