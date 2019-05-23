﻿using MiningManager.Model;
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
        /// Récupère les valeurs de propriétés publiques d'un objet
        /// </summary>
        /// <param name="o">Object contenant les valeurs à récupérer</param>
        public void ImportPropertiesValuesFromModel(object o)
        {
            //this.GetType().GetField("_id").SetValue(this, ((Commun)o).Id);

            foreach (PropertyInfo p in o.GetType().GetProperties())
            {
                if (this.GetType().GetProperty(p.Name) != null)
                {
                    this.GetType().GetProperty(p.Name).SetValue(this, p.GetValue(o));
                }
            }
        }

        public void ExportPropertiesValuesToModel(object o)
        {
            //((Commun)o).Id = (Int32)this.GetType().GetField("_id").GetValue(this);

            foreach (PropertyInfo p in this.GetType().GetProperties())
            {
                if (o.GetType().GetProperty(p.Name) != null)
                {

                    o.GetType().GetProperty(p.Name).SetValue(o, p.GetValue(this));
                }
            }
        }

        public decimal GetGoodDecimalPrecision(decimal number, int precision)
        {
            int i = 0;
            string txt = number.ToString(System.Globalization.CultureInfo.InvariantCulture).TrimEnd('0');
            string[] t = txt.Split('.');
            if (t.Length >1)
            {
                i = t[1].Length;
            }

            i = i <= precision ? precision : i;

            return Math.Round(number, i);//Math.Round(number, precision);
        }
    }
}
