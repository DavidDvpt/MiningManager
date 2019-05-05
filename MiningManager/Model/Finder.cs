using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Finder")]
    public class Finder : Tool
    {
        [Range(0, 1000)]
        public decimal Depth { get; set; }

        [Range(0, 60)]
        public decimal Range { get; set; }

        public short BasePecSearch { get; set; }
    }
}
