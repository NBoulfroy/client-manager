using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    [Serializable]
    public class Customer
    {
        public int Customer_id { get; set; }
        public string Customer_lastName { get; set; }
        public string CUstomer_firstName { get; set; }
    }
}
