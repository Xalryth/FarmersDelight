using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.FarmBuilding
{
    [Table("Stable")]
    public class Stable : Building
    {
        ICollection<Pen> pens;

        public ICollection<Pen> Pens { get => pens; set => pens = value; }

        public Stable(string name) : base(name)
        {
        }
    }
}