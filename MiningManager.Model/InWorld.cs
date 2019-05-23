using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("InWorld")]
    public abstract class InWorld : Commun
    {
        private Modele _modele;

        public decimal Value { get; set; }

        public int ModeleId { get; set; }

        [ForeignKey("ModeleId")]
        public virtual Modele Modele
        {
            get => _modele;
            set
            {
                _modele = value;
                ModeleId = value.Id;
            }
        }
    }
}
