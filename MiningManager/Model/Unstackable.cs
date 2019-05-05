using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Unstackable")]
    public abstract class Unstackable : InWorld
    {
        public bool IsLimited { get; set; }

        [Range(0, 9999.999)]
        public decimal Decay { get; set; }

        public string Code { get; set; }
    }
}
