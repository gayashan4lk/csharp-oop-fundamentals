﻿using Stark.BL.Models;
using System.Collections.Generic;

namespace Stark.BL.Repository
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address();

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.AddressLine1 = "Bag End";
                address.AddressLine2 = "Bagshot Raw";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                AddressLine1 = "Bag End",
                AddressLine2 = "Bagshot Raw",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                AddressLine1 = "Green dragon",
                City = "ByWater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146",
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
