using System;
using System.Collections.Generic;

namespace DufflinMunder
{
    public class SalesEmployee : Employee
    {
        public List<Sale> Sales {get; set;}

        public SalesEmployee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
