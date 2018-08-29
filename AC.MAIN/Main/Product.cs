using System;

namespace AC.Main
{
    public class Product
    {
        public Product(){}

        public Product(int productID)
        {
            this.ProductID = productID;
        }

        public int ProductID {get;set;}
        public string ProductName {get;set;}
        public string Description {get;set;}
        public decimal? CurrentPrice {get;set;}

        public bool Validate()
        {
            var isValid = true;
            return isValid;
        }

        public override string ToString()
        {
            return ProductName.InsertSpaces() + " (" + ProductID + ").";
        }
    }
}