using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Feed
{
    [Table("FeedDistribution")]
    public class FeedDistribution
    {
        FeedType feedType;
        float percentageOfBlend;

        public FeedType FeedType { get => feedType; set => feedType = value; }
        public float PercentageOfBlend { get => percentageOfBlend; set => percentageOfBlend = value; }

        public FeedDistribution(FeedType feedType, float percentageOfBlend)
        {
            FeedType = feedType;
            PercentageOfBlend = percentageOfBlend;
        }
    }
}