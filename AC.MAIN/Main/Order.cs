using System;

namespace AC.Main
{
    public class Order
    {
        public int CustomerID {get;set;}
        public DateTimeOffset? OrderDate {get;set;}
        public int AddressID {get;set;}

        public bool Validate()
        {
            var isValid = true;
            return isValid;
        }
    }
}