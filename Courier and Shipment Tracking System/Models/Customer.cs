using System;
using System.Collections.Generic;
using System.Text;

namespace Courier_and_Shipment_Tracking_System.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }

        public int PhoneNumber { get; set; }
        public string Address { get; set; }

    }
    public Customer (
        int customerId,
        string fullName,
        int phoneNumber,
        string address )
        {
            CustomerId = customerId;
            FullName = fullName;
            PhoneNumber = PhoneNumber;
            Address = address;
        }
}
