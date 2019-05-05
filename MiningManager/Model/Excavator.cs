using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Excavator")]
    public class Excavator : Tool
    {
        [Range(0, 99.9)]
        public decimal Efficienty { get; set; }
    }
}
