using System;
using System.Collections.Generic;
using System.Text;

namespace Assighment1SessionOOP
{
    internal class Drrevier
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string PhoneNamber { get; set; } = null!;

        public Drrevier(int id,string name,string phonenumber)
        {

            id = Id;
            name = Name;
            phonenumber = PhoneNamber;
            
        }

    }
}
