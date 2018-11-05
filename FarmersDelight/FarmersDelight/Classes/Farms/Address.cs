using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Farms
{
    [Table("Address")]
    public class Address
    {
        City city;
        Country country;
        string streetName;
        int streetNumber;

        public City City { get => city; set => city = value; }
        public Country Country { get => country; set => country = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public int StreetNumber { get => streetNumber; set => streetNumber = value; }

        public Address(City city, Country country, string streetName, int streetNumber)
        {
            City = city;
            Country = country;
            StreetName = streetName;
            StreetNumber = streetNumber;
        }
    }
}