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

            // les 3 controls composant cette fenetre sont totalement indépendants les un des autres

            //Affichage du menu
            // aucun acces à la base de donnée pour cette entité
            IMenuController mc = new MenuController();
            MenuView mv = new MenuView();
            MenuViewModel mvm = new MenuViewModel(mc, mv);
            mv.ShowInWindow(false, vw, "MiningManager", 800, 450, Dock.Top, mvm.OnWindowClosed);

            // Affichage Status
            // aucun acces à la base de donnée pour cette entité
            IStatusController sc = new StatusController();
            StatusView sv = new StatusView();
            StatusViewModel svm = new StatusViewModel(sc, mv);
            sv.ShowInWindow(vw, Dock.Bottom, svm.OnWindowClosed);

            // Affichage du container
            // aucun acces à la base de donnée pour cette entité
            IContainerController cc = new ContainerController();
            ContainerView cv = new ContainerView();
            ContainerViewModel cvm = new ContainerViewModel(cc, cv);
            cv.ShowInWindow(vw, null, svm.OnWindowClosed);

            TestContext();

        }

        private void TestContext()
        {
            MiningContext ctx = new MiningContext();

            ctx.Communs.Load();
            bool b = ctx.Communs.Any(x => x.Nom == "Finder F-101");
            bool c = ctx.Communs.Any(x => x.Nom == "Finder F-101mjm");
        }
    }
}
