using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("InWorld")]
    public abstract class InWorld : Commun
    {
        [Range(0, 9999.99999)]
        public decimal Value { get; set; }

        public int ModeleId { get; set; }

        [Required]
        [ForeignKey("ModeleId")]
        public virtual Modele Modele { get; set; }
    }
}
