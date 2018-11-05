using FarmersDelight.Classes.Sensors;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Schedule
{
    [Table("ScheduleElement")]
    public class ScheduleElement
    {
        Sensor sensor;
        DateTime triggerTime;

        public Sensor Sensor { get => sensor; set => sensor = value; }
        public DateTime TriggerTime { get => triggerTime; set => triggerTime = value; }

        public ScheduleElement(Sensor sensor, DateTime triggerTime)
        {
            Sensor = sensor;
            TriggerTime = triggerTime;
        }
    }
}