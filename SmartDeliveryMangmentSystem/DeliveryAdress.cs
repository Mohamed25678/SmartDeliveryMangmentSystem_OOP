using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal struct DeliveryAdress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAdress(string City,string Street,int BuildingNumber)
        {
            this.City = City;
            this.Street = Street;
            this.BuildingNumber = BuildingNumber;
            
        }

        public string GetFullAdress()
        {
            return $"{City}-{Street}-{BuildingNumber}";
        }
    }
}
