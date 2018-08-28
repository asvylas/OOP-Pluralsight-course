using System;
using System.Collections.Generic;

namespace AC.Main
{
    public class Customer
    {
        public Customer()
            :this(0)
        {

        }

        public Customer(int customerID)
        {
            this.CustomerID = customerID;
            this.AddressList = new List<Address>();
        }

        public static int CustomerCounter {get;set;}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress {get;set;}
        public int CustomerID {get; private set;}
        public List<Address> AddressList {get;set;}

        public string fullName
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName))
                {
                    return LastName + ", " + FirstName;
                }
                else if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    return FirstName;
                } 
                else
                {
                    return LastName;
                }
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
