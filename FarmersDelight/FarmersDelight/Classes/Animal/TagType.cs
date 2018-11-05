using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Animal
{
    [Table("TagType")]
    public class TagType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        private TagType(TagTypeEnum type)
        {
            Id = (byte)type;
            Name = type.ToString();
        }

        public static implicit operator TagType(TagTypeEnum type) => new TagType(type);
        public static implicit operator TagTypeEnum(TagType type) => (TagTypeEnum)type.Id;
    }

    public enum TagTypeEnum : byte
    {
        Red,
        Green,
        Grey
    }
}