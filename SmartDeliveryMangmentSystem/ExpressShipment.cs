using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class ExpressShipment : Shipment
    {
        private decimal ExtraaFee;

        public decimal extraafee
        {
            get { return ExtraaFee; }


            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("extra fee cannot be negative");





                }
                extraafee = value;
            }

        }
        public ExpressShipment(string trackingcode, string Description, double Weight, double DeliveryFee, DeliveryAdress Destination,decimal extraafee):base()
        {
            this.extraafee = ExtraaFee;
        }

        public override double EstimatedCost
        {
            get
            {
                return DeliveryFee + ((weight * 5) + (double)extraafee);
            }
        }
<<<<<<< HEAD
        public override string PrintShipment()
        {
           return $"{TrackingCode} - {description} - {weight} - {DeliveryFee} - {Destination} - {EstimatedCost}-{extraafee}";
            
        }
=======
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
    }
}
