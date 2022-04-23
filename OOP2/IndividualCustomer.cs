using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // inheritance
    class IndividualCustomer:Customer
    {
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
