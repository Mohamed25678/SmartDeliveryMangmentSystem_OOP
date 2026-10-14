using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
 
        internal sealed class CompletedShipment : Shipment
        {
            public CompletedShipment(
                string trackingCode,
                string description,
                decimal weight,
                string type,
                decimal deliveryFee,
                DeliveryAdress destination)
                : base(
                    trackingCode,
                    description,
                    weight,
                    type,
                    deliveryFee,
                    destination)
            {
            }
        }




    }
    
    

