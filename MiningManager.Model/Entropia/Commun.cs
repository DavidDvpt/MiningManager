using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Commun")]
    public abstract class Commun
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public string Nom { get; set; }

        public bool IsActive { get; set; }
    }
}
