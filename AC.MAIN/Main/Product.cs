using System;

namespace AC.Main
{
    public class Product
    {
        public int ProductID {get;set;}
        public string ProductName {get;set;}
        public string Description {get;set;}
        public decimal? CurrentPrice {get;set;}

        public bool Validate()
        {
            var isValid = true;
            return isValid;
        }
    }
}