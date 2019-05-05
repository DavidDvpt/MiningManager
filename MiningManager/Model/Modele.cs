using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Modele")]
    public class Modele : Commun
    {
        public bool IsStackable { get; set; }

        public int CategorieId { get; set; }

        [Required]
        [ForeignKey("CategorieId")]
        public virtual Categorie Categorie { get; set; }

        public virtual ICollection<InWorld> InWorlds { get; set; }
    }
}
