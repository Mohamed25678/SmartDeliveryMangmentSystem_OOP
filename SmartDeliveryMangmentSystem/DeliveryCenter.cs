using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class DeliveryCenter
    {
        public string CenterName { get; set; } = null!;
        private Shipment[]Shipments =new Shipment[20];
<<<<<<< HEAD
        public Drrevier Driver { get; set; }
=======

>>>>>>> 443ad3123fcdfebc9647768a359cc6147b755bac
        public DeliveryCenter(string centername)
        {
            centername = CenterName;
            Shipments = new Shipment[20];
            
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null &&
                    Shipments[i].trackingcode == trackingCode)
                {
                    Shipments[i] = null!;
                    return true;
                }
            }

            return false;
        }
        public void printAllShipment()
        {
            for (int i = 0; i < Shipments.Length; i++) 
            {
            if(Shipments[i] != null) 
                {
                    Shipments[0].PrintShipment();
                    Console.WriteLine("-------------------");
                
                
                }
            
            }

        }

    }
}
