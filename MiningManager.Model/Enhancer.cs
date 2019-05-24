using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Enhancer")]
    public class Enhancer : InWorld
    {
        public byte Slot { get; set; }

        public decimal BonusValue1 { get; set; }
        
        public short BonusValue2 { get; set; }
    }

}
