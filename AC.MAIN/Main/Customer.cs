using System;
using System.Collections.Generic;
using AC.Base;
using AC.Interfaces;

namespace AC.Main
{
    public class Customer : EntityBase, ILogger
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

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return fullName;
        }

        public string Log()
        {
            var logged = string.Empty;
            return logged;
        }
    }
}
