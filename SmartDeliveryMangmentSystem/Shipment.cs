using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class Shipment
    {
<<<<<<< HEAD
        public string TrackingCode;
        private string Description;
        private double Weight;
        public double DeliveryFee { get; set; }
        private double NewFee;
        private decimal weight1;
        private string type;
        private decimal deliveryFee;

        public DeliveryAdress Destination {  get; set; }

       
=======
        private string TrackingCode;
        private string Description;
        private double Weight;
        public double DeliveryFee { get; set; }
        private double NewFee; 
        public DeliveryAdress Destination {  get; set; }

        public Shipment()
        {
       
        }
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
        public Shipment(string trackingcode,string description,double weight,double deliveryFee,DeliveryAdress destination)
        {
            TrackingCode = trackingcode;
           
<<<<<<< HEAD
           description=Description;
            weight = Weight;
            DeliveryFee = DeliveryFee;
           Destination = Destination;
            
        }

        public Shipment(string trackingCode, string description, decimal weight1, string type, decimal deliveryFee, DeliveryAdress destination)
        {
            TrackingCode = trackingCode;
            this.description = description;
            this.weight1 = weight1;
            this.type = type;
            this.deliveryFee = deliveryFee;
            Destination = destination;
        }

=======
           this.description=Description;
            this.weight = Weight;
            this.DeliveryFee = DeliveryFee;
            this.Destination = Destination;
            
        }

>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
        public string trackingcode
        {
            get

            {
                return TrackingCode;
            }

            set
            {
                if (string.IsNullOrEmpty(TrackingCode))
                {

                    throw new ArgumentNullException("TrackingCode cannot Be Embty");

                }

            }
        }

        public string description
        {
            get
            {
                return description;


            }
            set
            {
                if (value != null || value == " ")
                {

                    Description = value;

                }


            }
        }

            public double weight
        {
            get { return Weight; }

            set
            {
                if (value >= 0)
                {
                    Weight = value;
                }
            }

        }
            public double deliveryfee
        {

            get { return DeliveryFee; }
            private set
            {
                if (value >= 0)
                {
                 DeliveryFee=value;
                
                }

            }
           
        
        }

        public virtual double  EstimatedCost
        {
            get
            {
                return DeliveryFee + (weight * 5);
            }
        }
<<<<<<< HEAD
        public double UpdateWeight(double newWeight)
        {
            return weight = newWeight;

        }
        public double UpdateWeight(double newWeight,double extraPackingWeight)
        {
          return weight = newWeight + extraPackingWeight;
          
        }


=======
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac


        public void UpdateDeliveryFee()
        {
            if (NewFee > 0)
            {
                DeliveryFee = NewFee;
            }

        }
<<<<<<< HEAD
        public virtual string PrintShipment()
        {
            return $"{TrackingCode} - {Description} - {Weight} - {DeliveryFee} - {Destination} - {EstimatedCost} - {NewFee}";
        }


        public void CompletedShipment(
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
=======
        public string PrintShipment()
        {
            return $"{TrackingCode} - {Description} - {Weight} - {DeliveryFee} - {Destination} - {EstimatedCost} - {NewFee}";
        }
>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
    }
}

