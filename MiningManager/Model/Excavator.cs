using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Excavator")]
    public class Excavator : Tool
    {
        public decimal Efficienty { get; set; }
    }
}
