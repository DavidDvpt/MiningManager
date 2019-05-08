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
        public byte Slot { get; set; }

        public decimal BonusValue1 { get; set; }
        
        public short BonusValue2 { get; set; }
    }

}
