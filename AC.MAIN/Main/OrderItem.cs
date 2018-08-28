using System;

namespace AC.Main
{
    public class OrderItem
    {
        public int ProductID {get;set;}
        public int Quantity {get;set;}
        public decimal? PurchasePrice {get;set;}

        public bool Validate()
        {
            var isValid = true;
            return isValid;
        }
    }
}