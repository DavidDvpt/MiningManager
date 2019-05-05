using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningManager.Model
{
    [Table("Setup")]
    public class Setup : Commun
    {
        public int FinderId { get; set; }

        public int FinderAmplifierId { get; set; }

        public int SearchModeId { get; set; }

        [Range(0, 10)]
        public short DepthEnhancerQty { get; set; }

        [Range(0, 10)]
        public short RangeEnhancerQty { get; set; }

        [Range(0, 10)]
        public short SkillEnhancerQty { get; set; }

        [Required]
        [ForeignKey("SearchModeId")]
        public virtual SearchMode SearchMode { get; set; }

        [Required]
        [ForeignKey("FinderId")]
        public virtual Finder Finder { get; set; }

        [ForeignKey("FinderAmplifierId")]
        public virtual FinderAmplifier FinderAmplifier { get; set; }

        // cree le nom du setup à partir des outils utilises
        //private void NomComposition()
        //{
        //    string searchModeAbbrev = "";
        //    string finderCode = "";
        //    string finderAmplifierCode = "";

        //    if (Finder != null)
        //    {
        //        finderCode = Finder.Code;
        //    }

        //    if (FinderAmplifier != null)
        //    {
        //        finderAmplifierCode = FinderAmplifier.Code;
        //    }

        //    if (SearchMode != null)
        //    {
        //        searchModeAbbrev = SearchMode.Abbrev;
        //    }

        //    Nom = finderCode + "_" + finderAmplifierCode + "_T" + TierUsed().ToString() + "_D" + DepthEnhancerQty.ToString() + "R" + RangeEnhancerQty.ToString() + "S" + SkillEnhancerQty.ToString() + "_" + searchModeAbbrev;
        //}

        //public int TierUsed()
        //{
        //    return DepthEnhancerQty + RangeEnhancerQty + SkillEnhancerQty;
        //}
        // Ajouter dans la migration 
        // Sql("ALTER TABLE Setup ADD CONSTRAINT [CK_Setup_MaxEnhancerQty] CHECK (([FinderDepthEnhancerQty] + [FinderRangeEnhancerQty] + [FinderSkillEnhancerQty]) <= 10)");

    }
}
