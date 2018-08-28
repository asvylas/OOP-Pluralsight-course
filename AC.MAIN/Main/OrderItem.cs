using System;

namespace AC.Main
{
    public class OrderItem
    {
        public OrderItem(){}
        public OrderItem(int productID, int quantity, decimal purchasePrice)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
            this.PurchasePrice = purchasePrice;
        }
        public int ProductID {get; private set;}
        public int Quantity {get;set;}
        public decimal? PurchasePrice {get; private set;}

        public bool Validate()
        {
            var isValid = true;
            return isValid;
        }
    }
}