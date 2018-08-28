using System;

namespace AC.Main
{
    public class Customer
    {
        public static int CustomerCounter {get;set;}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get;set;}
        public int CustomerID {get;set;}

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
            if(string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

    }
}
