
using System;
using Courier_and_Shipment_Tracking_System.Models;

namespace Courier_and_Shipment_Tracking_System.Services
{
    public class CustomerService
    {
        List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer c)
        {
            if (customers.Any(x => x.CustomerID == c.customerId))
            {
                Console.WriteLine("Customer ID already exists");
                return;
            }

            customers.Add(c);
            Console.WriteLine("Customer added successfully");
        }

        public void DisplayCustomers()
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.customerId);
                Console.WriteLine(c.FullName);
                Console.WriteLine(c.PhoneNumber);
                Console.WriteLine(c.Location);
            }
        }

        public void SearchCustomer(int id)
        {
            Customer? c = customers.FirstOrDefault(
                x => x.customerId == id);

            if (c != null)
                Console.WriteLine(c.FullName);
            else
                Console.WriteLine("Customer not found");
        }
    }
}
