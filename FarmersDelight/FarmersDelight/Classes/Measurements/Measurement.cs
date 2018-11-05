using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using FarmersDelight.Classes.Sensors;

namespace FarmersDelight.Classes.Measurements
{
    [Table("Measurement")]
    public class Measurement
    {
        SensorType sensorType;
        DateTime timeOfMeasurement;
        float measurementValue;

        public SensorType SensorType { get => sensorType; set => sensorType = value; }
        public DateTime TimeOfMeasurement { get => timeOfMeasurement; set => timeOfMeasurement = value; }
        public float MeasurementValue { get => measurementValue; set => measurementValue = value; }

        public Measurement(SensorType sensorType, float measurementValue)
        {
            SensorType = sensorType;
            MeasurementValue = measurementValue;
        }
    }
}