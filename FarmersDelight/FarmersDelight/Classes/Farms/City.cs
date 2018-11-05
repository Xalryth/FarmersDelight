using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Farms
{
    [Table("City")]
    public class City
    {
        string name;
        int zipcode;

        public string Name { get => name; set => name = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }

        public City(string name, int zipcode)
        {
            Name = name;
            Zipcode = zipcode;
        }
    }
}