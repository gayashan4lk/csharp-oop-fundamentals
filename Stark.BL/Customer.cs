using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class Customer
    {
        public Customer(): this(0) // Calling Customer(int customerId) contructor
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public List<Address> AddressList { get; set; }

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

        public override string ToString() => FullName;

        public bool Validate()
        {
            bool isValid = (String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(Email)) ? false : true;
            return isValid;
        }
    }
}
