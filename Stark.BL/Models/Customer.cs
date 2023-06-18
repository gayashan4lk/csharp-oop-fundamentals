using Stark.Common;
using System.Collections.Generic;

namespace Stark.BL.Models
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0) // Calling Customer(int customerId) contructor
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
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(_lastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }
        public string Email { get; set; }

        public static int InstanceCount { get; set; }

        public string Log() => $"{CustomerId}: {FullName} Email: {Email} Status: {EntityState}";

        public override string ToString() => FullName;

        public override bool Validate()
        {
            bool isValid = string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Email) ? false : true;
            return isValid;
        }
    }
}
