using MiningManager.Controller;
using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.View;
using MiningManager.ViewModel;
using System.Data.Entity;
using System.Linq;
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
            MainViewModel viewModel = new MainViewModel(new MainController());
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = viewModel;
            MainWindow.Show();

            //TestContext();

        }

        private void TestContext()
        {
            MiningContext ctx = new MiningContext();

            Finder f = new Finder();
            ctx.SaveChanges();

            //ctx.Communs.Load();
            //bool b = ctx.Communs.Any(x => x.Nom == "Finder F-101");
            //bool c = ctx.Communs.Any(x => x.Nom == "Finder F-101mjm");
        }
    }
}
