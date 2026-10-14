using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class StandardShipment:Shipment
    {
<<<<<<< HEAD
        public StandardShipment(string trackingcode, string Description, double Weight, double DeliveryFee, string Destination):base(
=======
        public StandardShipment(string trackingcode, string Description, double Weight, double DeliveryFee, DeliveryAdress Destination):base(
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
           )
         
        {
            
        }
<<<<<<< HEAD

        public override string PrintShipment()
        {
           return $"{TrackingCode} - {description} - {weight} - {DeliveryFee} - {Destination} - {EstimatedCost}";
        }
    }
    
    }

=======
    }
}
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
