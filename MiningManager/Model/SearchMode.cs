using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("SearchMode")]
    public class SearchMode : Commun
    {
        [Required]
        [MaxLength(3)]
        public string Abbrev { get; set; }

        [Required]
        [Range(1, 6)]
        public decimal Multiplicateur { get; set; }
    }
}
