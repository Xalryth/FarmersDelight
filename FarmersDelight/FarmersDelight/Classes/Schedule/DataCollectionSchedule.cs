using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Schedule
{
    [Table("DataCollectionSchedule")]
    public class DataCollectionSchedule
    {
        string name;
        ICollection<ScheduleElement> scheduleElements;
        DateTime framDate;
        DateTime toDate;

        public string Name { get => name; set => name = value; }
        public ICollection<ScheduleElement> ScheduleElements { get => scheduleElements; set => scheduleElements = value; }
        public DateTime FramDate { get => framDate; set => framDate = value; }
        public DateTime ToDate { get => toDate; set => toDate = value; }

        public DataCollectionSchedule(string name, DateTime framDate, DateTime toDate)
        {
            Name = name;
            FramDate = framDate;
            ToDate = toDate;
        }
    }
}