using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Sensors
{
    [Table("SensorType")]
    public class SensorType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        private SensorType(SensorTypeEnum type)
        {
            Id = (byte)type;
            Name = type.ToString();
        }

        public static implicit operator SensorType(SensorTypeEnum type) => new SensorType(type);
        public static implicit operator SensorTypeEnum(SensorType type) => (SensorTypeEnum)type.Id;
    }

    public enum SensorTypeEnum : ushort
    {
        UV
    }
}