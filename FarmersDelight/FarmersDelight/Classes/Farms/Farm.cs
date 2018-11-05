using FarmersDelight.Classes.FarmBuilding;
using FarmersDelight.Classes.Feed;
using FarmersDelight.Classes.Schedule;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Farms
{
    [Table("Farm")]
    public class Farm
    {
        string name;
        Address farmAddress;
        ICollection<FeedBlend> feedBlends;
        ICollection<Silo> silos;
        ICollection<Stable> stables;
        ICollection<DataCollectionSchedule> dataCollectionSchedules;
        
        public string Name { get => name; set => name = value; }
        public Address FarmAddress { get => farmAddress; set => farmAddress = value; }
        public virtual ICollection<FeedBlend> FeedBlends { get => feedBlends; set => feedBlends = value; }
        public virtual ICollection<Silo> Silos { get => silos; set => silos = value; }
        public virtual ICollection<Stable> Stables { get => stables; set => stables = value; }
        public virtual ICollection<DataCollectionSchedule> DataCollectionSchedules { get => dataCollectionSchedules; set => dataCollectionSchedules = value; }

        public Farm(string name, Address farmAddress)
        {
            Name = name;
            FarmAddress = farmAddress;
        }
    }
}