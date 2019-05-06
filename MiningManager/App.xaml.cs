using MiningManager.Model;
using MiningManager.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MiningManager
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //MiningContext ctx = new MiningContext();

            //DbSet<Commun> dbSet = ctx.Communs;
            //bool b = dbSet.Any(x => x.Nom == "Finder F-101");
        }

    }
}
