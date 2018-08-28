using System;

namespace AC.Main
{
    public class Address
    {
        public Address(){}

        public Address(int addressID)
        {
            this.AddressID = addressID;
        }

        public int AddressID {get; private set;}
        public int AddressType {get;set;}
        public string StreetLine1 {get;set;}
        public string StreetLine2 {get;set;}
        public string City {get;set;}
        public string StateProvince {get;set;}
        public string PostalCode {get;set;}
        public string Country {get;set;}
    }
}