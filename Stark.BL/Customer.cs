using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class Customer
    {
        /*private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }*/

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
        public string Email { get; set; }
        

    }
}
