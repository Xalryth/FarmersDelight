using FarmersDelight.Classes.Measurements;
using FarmersDelight.Classes.Sensors;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.FarmBuilding
{
    [Table("")]
    public abstract class Building
    {
        string name;
        ICollection<Measurement> measurements;
        ICollection<Sensor> sensors;

        public string Name { get => name; set => name = value; }
        public ICollection<Measurement> Measurements { get => measurements; set => measurements = value; }
        public ICollection<Sensor> Sensors { get => sensors; set => sensors = value; }

        protected Building(string name)
        {
            Name = name;
        }
    }
}