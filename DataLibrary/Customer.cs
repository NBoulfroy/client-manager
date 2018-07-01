using System;

namespace DataLibrary
{
    [Serializable]
    public class Customer
    {
        public int Customer_id { get; set; }

        public string Customer_lastName { get; set; }

        public string Customer_firstName { get; set; }
    }
}
