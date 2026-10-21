using System;
using System.Collections.Generic;
using System.Text;

namespace Courier_and_Shipment_Tracking_System.Models
{
    internal class Shipment
    {
        public int ShipmentId { get; set; }
        public int SenderCustomerId { get; set; }

        public string ReceiverName { get; set; }

        public int ReceiverPhone { get; set; }
        public string DestinationAddress { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Weight { get; set; }

        public int ShippingFee { get; set; }

        public string CurrentStatus { get; set; }
    }
    public shipment(
        int shipmentId,
        int senderCustomerId,
        string receiverName,
        int receiverPhone,
        string destinationAddress,
        int weight,
        int shippingFee,
        int currentStatus,
        )
        {
            ShipmentId = shipmentId;
            senderCustomerId = SenderCustomerId;
            ReceiverName = receiverName;
            ReceiverPhone = receiverPhone;
            DestinationAddress = destinationAddress;
            CreatedDate = DateTime.Now;
            Weight = weight;
            ShippingFee = shippingFee;
            CurrentStatus = CurrentStatus;
        }

    }
}