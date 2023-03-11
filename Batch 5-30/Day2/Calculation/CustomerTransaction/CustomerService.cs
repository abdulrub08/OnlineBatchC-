using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTransaction
{
    public class CustomerService
    {
        public readonly List<CustomerInfo> customerList;
        public CustomerService()
        {
            customerList = new List<CustomerInfo>();
        }
        public bool AddCustomerInfo(int nth)
        {
            CustomerInfo customerInfo = new CustomerInfo()
            {
                ID = 1,
                Name = "Added throgh Loop",
                Age = 32,
                Department = "IT"
            };
            for (int i = 0; i < nth; i++)
            {
                customerList.Add(customerInfo);
            }
            return true;
        }
        public bool AddCustomerInfo()
        {
            CustomerInfo customerInfo = new CustomerInfo()
            {
                ID = 1,
                Name = "only Single",
                Age = 32,
                Department = "IT"
            };
            customerList.Add(customerInfo);
            return true;
        }
        public bool AddCustomerInfo(Spouse spouse)
        {
            CustomerInfo customerInfo = new CustomerInfo()
            {
                ID = 1,
                Name = "Added Spouse Seprately",
                Age = 32,
                Department = "IT",
                Spouse = spouse
            };
            customerList.Add(customerInfo);
            return true;
        }
        public void DisplayCustomerInfo()
        {
            //foreach (var item in customerList)
            //{
            //    Console.WriteLine(item.department);
            //}

            for (int i = 0; i < customerList.Count; i++)
            {
                Console.Write(customerList[i].ID);
                Console.Write(" "+ customerList[i].Name);
                Console.Write(" "+ customerList[i].Age);
                Console.WriteLine(" "+ customerList[i].Department);
            }
        }
    }
}
