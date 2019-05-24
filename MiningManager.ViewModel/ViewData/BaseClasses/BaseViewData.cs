using MiningManager.Model;
using System;
using System.Globalization;
using System.Reflection;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// Classe de base pour tous les classe de mappage de modele
    /// </summary>
    public class BaseViewData : BindableBase
    {
        /// <summary>
        /// exporte les valeurs de propriétés publiques d'un objet
        /// </summary>
        /// <param name="o">Object contenant les valeurs à récupérer</param>
        public void ImportPropertiesValuesFromModel(object o)
        {
            foreach (PropertyInfo p in o.GetType().GetProperties())
            {
                if (this.GetType().GetProperty(p.Name) != null)
                {
                    this.GetType().GetProperty(p.Name).SetValue(this, p.GetValue(o));
                }
            }
        }

        /// <summary>
        /// Importe les valeurs de propriétés publiques d'un objet
        /// </summary>
        /// <param name="o">Object destinataire des valeurs</param>
        public void ExportPropertiesValuesToModel(object o)
        {
            foreach (PropertyInfo p in this.GetType().GetProperties())
            {
                if (o.GetType().GetProperty(p.Name) != null)
                {

                    o.GetType().GetProperty(p.Name).SetValue(o, p.GetValue(this));
                }
            }
        }

        /// <summary>
        /// Détermine la précision nécessaire d'une valeur décimale pour son affichage
        /// </summary>
        /// <param name="number">Nombre decimal à traiter</param>
        /// <param name="precision">Précision voulue par default</param>
        /// <returns></returns>
        public decimal GetGoodDecimalPrecision(decimal number, int precision)
        {
            int i = 0;
            string[] tab = number.ToString(System.Globalization.CultureInfo.InvariantCulture).TrimEnd('0').Split('.');

            if (tab.Length >1)
            {
                i = tab[1].Length;
            }

            i = i <= precision ? precision : i;

            return Math.Round(number, i);
        }
    }
}
