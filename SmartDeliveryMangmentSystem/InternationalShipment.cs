using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class InternationalShipment : Shipment
    {
        private double CustomeFee;
        private string DestinationCountry = null!;
<<<<<<< HEAD
        private string type;
        private decimal deliveryFee;
        private decimal customsFee;
=======
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac

        public double customerfee
        {
            get
            {
                return CustomeFee;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("customerfee not be embty");
                }
                CustomeFee = value;
            }
        }

        public string detinationcountry
        {
            get
            {
                return DestinationCountry;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new ArgumentException("destinationcountry cannot be embty");
                }
                DestinationCountry = value;
            }


        }

        public InternationalShipment(string trackingcode, string Description, double Weight, double DeliveryFee, DeliveryAdress Destination,string destinationcountry,double customfee):base()
        {
            this.detinationcountry = DestinationCountry;
            this.customerfee = CustomeFee;
        }

<<<<<<< HEAD
        public InternationalShipment(string trackingCode, string description, string type, decimal deliveryFee, DeliveryAdress destination, decimal customsFee)
        {
            TrackingCode = trackingCode;
            this.description = description;
            this.type = type;
            this.deliveryFee = deliveryFee;
            Destination = destination;
            this.customsFee = customsFee;
        }

=======
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
        public override double EstimatedCost 
        
        
        {
            get
            {
                return DeliveryFee + ((weight * 5) +(double) customerfee);

            }

        }
<<<<<<< HEAD
        public override string PrintShipment()
        {
            return $"{TrackingCode} - {description} - {weight} - {DeliveryFee} - {Destination} - {EstimatedCost}-{customerfee}-{detinationcountry}";

        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine(
                $"Customs Report for {TrackingCode}");
        }
=======
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac


    }
}
