using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int CustomerCounter { get; set; }
        public Customer()
        {

        }
        public Customer(int cutomerId, int cutomerCounter)
        {
            CustomerId = cutomerId;
            CustomerCounter = cutomerCounter;
        }
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        public string GetCustomerInfo()
        {
            return $"{CustomerId} {CustomerCounter}";
        }
    }
}
