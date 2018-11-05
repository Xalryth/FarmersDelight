using System.ComponentModel.DataAnnotations.Schema;

namespace FarmersDelight.Classes.Animal
{
    [Table("Pig")]
    public class Pig
    {
        string pigID;
        PigType pigType;
        TagType tagType;

        public string PigID { get => PigID; set => PigID = value; }
        public PigType PigType { get => pigType; set => pigType = value; }
        public TagType TagType { get => tagType; set => tagType = value; }

        public Pig(string pigID, PigType pigType, TagType tagType)
        {
            PigID = pigID;
            PigType = pigType;
            TagType = tagType;
        }
    }
}