using System;
using AC.Base;

namespace AC.Main
{
    public class Order : EntityBase
    {
        public Order(){}
        
        public Order(int customerID, int orderID)
        {
            this.CustomerID = customerID;
            this.OrderID = orderID;
        }

        public int CustomerID {get; private set;}
        public int OrderID {get; private set;}
        public DateTimeOffset? OrderDate {get;set;}
        public int AddressID {get;set;}

        public override bool Validate()
        {
            var isValid = true;
            return isValid;
        }

        public override string ToString()
        {
            return "CustomerID: " + CustomerID + ". AddressID: " + AddressID;
        }
    }
}