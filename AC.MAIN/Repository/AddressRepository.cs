using System;
using System.Collections.Generic;
using AC.Main;

namespace AC.Repository
{
    public class AddressRepository
    {
        public Address Retrieve(int addressID)
        {
            var address = new Address();
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Jamango, Company Holdings",
                StreetLine2 = "Jamango str. 8",
                City = "Jamanago",
                StateProvince = "Jumango Province, Jipini District",
                PostalCode = "448912",
                Country = "Jamango Republic"

            };
            addressList.Add(address);
            return addressList;
        }

        public bool Save()
        {
            var isSafe = true;
            // Save data
            return isSafe;

        }
    }
}