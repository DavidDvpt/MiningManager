using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.Model
{
    [Table("Enhancer")]
    public class Enhancer : InWorld
    {
        [Range(1, 10)]
        public byte Slot { get; set; }

        [Range(0.01, 99.99)]
        public decimal BonusValue1 { get; set; }

        [Range(0, 99)]
        public short BonusValue2 { get; set; }
    }

}
