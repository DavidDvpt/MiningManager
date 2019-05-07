using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("FinderAmplifier")]
    public class FinderAmplifier : Unstackable
    {
        public decimal Coefficient { get; set; }
    }
}
