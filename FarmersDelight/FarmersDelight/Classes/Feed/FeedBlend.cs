using FarmersDelight.Classes.Animal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Feed
{
    [Table("FeedBlend")]
    public class FeedBlend
    {
        string name;
        ICollection<FeedDistribution> feedDistributions;
        PigType targetPigType;

        public string Name { get => name; set => name = value; }
        public ICollection<FeedDistribution> FeedDistributions { get => feedDistributions; set => feedDistributions = value; }
        public PigType TargetPigType { get => targetPigType; set => targetPigType = value; }

        public FeedBlend(string name, PigType targetPigType)
        {
            Name = name;
            TargetPigType = targetPigType;
        }
    }
}