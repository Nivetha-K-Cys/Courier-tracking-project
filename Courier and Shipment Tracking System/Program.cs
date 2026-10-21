
using System;
using Courier_and_Shipment_Tracking_System.Models;
using Courier_and_Shipment_Tracking_System.Services;

namespace Courier_and_Shipment_Tracking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            ShipmentService shipmentService = new ShipmentService();
            ShipmentStatusHistoryService historyService =
                new ShipmentStatusHistoryService();

           

