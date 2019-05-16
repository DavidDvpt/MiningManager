using MiningManager.Model;
using System;
using System.Reflection;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// Classe de base pour tous les classe de mappage de modele
    /// </summary>
    public class BaseViewData : BindableBase
    {
        /// <summary>
        /// Récupère les valeurs de propriétés publiques d'un objet
        /// </summary>
        /// <param name="o">Object contenant les valeurs à récupérer</param>
        public void ImportPropertiesValuesFromModel(object o)
        {
            foreach (PropertyInfo p in o.GetType().GetProperties())
            {
                this.GetType().GetField("_id").SetValue(this, ((Commun)o).Id);

                if (this.GetType().GetProperty(p.Name) != null)
                {
                    this.GetType().GetProperty(p.Name).SetValue(this, p.GetValue(o));
                }
            }
        }

        public void ExportPropertiesValuesToModel(object o)
        {
            foreach (PropertyInfo p in o.GetType().GetProperties())
            {
                ((Commun)o).Id = (Int32)this.GetType().GetProperty("_id").GetValue(this);

                if (this.GetType().GetProperty(p.Name) != null)
                {
                    this.GetType().GetProperty(p.Name).SetValue(this, p.GetValue(o));
                }
            }
        }
    }
}
