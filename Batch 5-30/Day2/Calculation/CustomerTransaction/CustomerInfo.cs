using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTransaction
{
    public class CustomerInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public Spouse Spouse { get; set; }
        
    }
    public class Spouse
    {
        public string Name;
        public int Age;
        public int Salary;
    }
}
