using System;
using System.Collections.Generic;
using System.Text;

namespace Courier_and_Shipment_Tracking_System.Models
{
    public class ShipmentStatusHistory
    {
        public int ShipmentId { get; set;}
        public string Status { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string Loacation { get; set; }
        
    }
    public ShipmentStatusHistory(
        int shipmentId,
        string status,
        string location,
        )
        {
            ShipmentId = Shipment;
            Status = status;
            UpdatedAt = DateTime.Now;
            location = location;
        }
}
