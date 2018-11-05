using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Feed
{
    [Table("FeedType")]
    public class FeedType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        private FeedType(FeedTypeEnum type)
        {
            Id = (byte)type;
            Name = type.ToString();
        }

        public static implicit operator FeedType(FeedTypeEnum type) => new FeedType(type);
        public static implicit operator FeedTypeEnum(FeedType type) => (FeedTypeEnum)type.Id;
    }

    public enum FeedTypeEnum : byte
    {
        Wheat,
        Soja,
        Peas,
        Barley
    }
}