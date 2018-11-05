using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Farms
{
    [Table("Country")]
    public class Country
    {
        string name;

        public string Name { get => name; set => name = value; }

        public Country(string name)
        {
            Name = name;
        }
    }
}