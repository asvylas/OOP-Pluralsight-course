using System;
using AC.Main;

namespace AC.Repository
{
    public class CustomerRepository
    {
        private AddressRepository _addressRepository {get;set;}
        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }
        // Mock
        public Customer Retrieve(int customerID)
        {
            var customer = new Customer(customerID)
            {
                EmailAddress = "jamesanderson@gmail.com",
                FirstName = "James",
                LastName = "Anderson"
            };
            return customer;
        }
    }
}