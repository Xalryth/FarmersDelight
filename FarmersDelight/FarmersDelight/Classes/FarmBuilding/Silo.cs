using FarmersDelight.Classes.Feed;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.FarmBuilding
{
    [Table("Silo")]
    public class Silo : Building
    {
        FeedType feedType;
        float storedAmount;

        public FeedType FeedType { get => feedType; set => feedType = value; }
        public float StoredAmount { get => storedAmount; set => storedAmount = value; }

        public Silo(string name, FeedType feedType) : base(name)
        {
            FeedType = feedType;
        }
    }
}