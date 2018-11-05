using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Animal
{
    [Table("PigType")]
    public class PigType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        private PigType(PigTypeEnum type)
        {
            Id = (byte)type;
            Name = type.ToString();
        }

        public static implicit operator PigType(PigTypeEnum type) => new PigType(type);
        public static implicit operator PigTypeEnum(PigType type) => (PigTypeEnum)type.Id;
    }

    public enum PigTypeEnum : byte
    {
        Pig,
        Sow,
        Boar,
        Piglet
    }
}