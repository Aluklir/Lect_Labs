using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human1
{
    class Address
    {
        private string country;
        private string region;
        private string sity;
        private string street;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public string Sity
        {
            get { return sity; }
            set { sity = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public Address(string Country, string Region, string Sity, string Street)
        {
            country = Country;
            region = Region;
            sity = Sity;
            street = Street;
        }
   
    }
}
