using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }

        // full decleration of Lastname field
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!String.IsNullOrEmpty(LastName))
                {
                    fullName = LastName + ", " + fullName;
                }
                if(String.IsNullOrEmpty(FirstName))
                {
                    fullName = LastName;
                }

                return fullName;
            }
        }
        public string Email { get; set; }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            bool isValid = (String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(Email)) ? false : true;
            return isValid;
        }
    }
}
