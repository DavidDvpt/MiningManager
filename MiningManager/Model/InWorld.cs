using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("InWorld")]
    public abstract class InWorld : Commun
    {
        public decimal Value { get; set; }

        public int ModeleId { get; set; }

        [Required]
        [ForeignKey("ModeleId")]
        public virtual Modele Modele { get; set; }
    }
}
