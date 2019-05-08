using MiningManager.Controller;
using MiningManager.Repository;
using MiningManager.View;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MiningManager
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Vue principale
            ViewWindow vw = new ViewWindow();

            //Affichage du menu
            IMenuController mc = new MenuController(new MenuRepository());
            MenuView mv = new MenuView();
            MenuViewModel mvm = new MenuViewModel(mc, mv);
            mv.ShowInWindow(false, vw, "MiningManager", 800, 450, Dock.Top, mvm.OnWindowClosed);
            //mc.Start();

            // Affichage Status
            IStatusController sc = new StatusController(new StatusRepository());
            StatusView sv = new StatusView();
            StatusViewModel svm = new StatusViewModel(sc, mv);
            sv.ShowInWindow(vw, Dock.Bottom, svm.OnWindowClosed);

            // Affichage du container
            IContainerController cc = new ContainerController(new ContainerRepository());
            ContainerView cv = new ContainerView();
            ContainerViewModel cvm = new ContainerViewModel(cc, cv);
            cv.ShowInWindow(vw, null, svm.OnWindowClosed);

            TestContextAsync();

        }

        private void TestContextAsync()
        {
            MiningContext ctx = new MiningContext();

            ctx.Communs.Load();
            bool b = ctx.Communs.Any(x => x.Nom == "Finder F-101");
            bool c = ctx.Communs.Any(x => x.Nom == "Finder F-101mjm");
        }
    }
}
