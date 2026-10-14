using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            string type,
            decimal deliveryFee,
            DeliveryAdress destination,
            decimal customsFee) : base(trackingCode, description , type, deliveryFee, destination, customsFee)

        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority Customs Report for {TrackingCode}");
        }
    }
}
