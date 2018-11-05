using FarmersDelight.Classes.Animal;
using FarmersDelight.Classes.Measurements;
using FarmersDelight.Classes.Sensors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FarmersDelight.Classes.FarmBuilding
{
    [Table("Pen")]
    public class Pen : Building
    {
        PigType pigType;
        ICollection<Pig> pigs;

        public PigType PigType { get => pigType; set => pigType = value; }
        public ICollection<Pig> Pigs { get => pigs; set => pigs = value; }

        public Pen(string name, PigType pigtype) : base(name)
        {
            PigType = pigtype;
        }
    }
}