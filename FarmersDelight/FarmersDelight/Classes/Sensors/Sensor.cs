using FarmersDelight.Classes.FarmBuilding;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Sensors
{
    [Table("Sensor")]
    public class Sensor
    {
        Building owningBuilding;
        SensorType sensorType;

        public Building OwningBuilding { get => owningBuilding; set => owningBuilding = value; }
        public SensorType SensorType { get => sensorType; set => sensorType = value; }

        public Sensor(Building owningBuilding, SensorType sensorType)
        {
            OwningBuilding = owningBuilding;
            SensorType = sensorType;
        }
    }
}