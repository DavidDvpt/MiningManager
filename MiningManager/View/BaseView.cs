using MiningManager.ViewModel;
using MiningManager.ViewModel.CustomEventArgs;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MiningManager.View
{
    /// <summary>
    /// c'est la classe de base de toutes les vues
    /// elle ne peut pas être abstraite car ca va causer des pb qd "design time"
    /// va essayer d'instancier cette classe
    /// cette viex n'a pas de XAML car on ne peux pas heriter d'une classe XAML
    /// </summary>
    public class BaseView : UserControl, IDisposable, IView
    {
        #region Champs

        /// <summary>
        /// La fenêtre sur laquelle la vue est affichée (si elle est affichée sur une fenêtre)
        /// La fenêtre sera créée par View on demand (si nécessaire) ou peut être
        /// fourni par l'application.
        /// </summary>
        private ViewWindow viewWindow;
        public ViewWindow ViewWindow
        {
            get
            {
                if (viewWindow == null)
                {
                    viewWindow = new ViewWindow();
                    viewWindow.Closed += ViewsWindow_Closed;
                }

                return viewWindow;
            }
            private set { viewWindow = value; }
            
        }
		/// <summary>
		/// Délégué qui autorise le traitement de l'event WindowClosed 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public event EventHandler OnWindowClosed;

        #endregion

        #region Constructeurs

        public BaseView()
        {
        }

        #endregion
        
        #region Fermeture

        /// <summary>
        /// La fenetre se ferme, on efface les references de la vues données au viewModel
        /// </summary>
        public void ViewClosed()
        {
            // Afin de gérer le cas où l'utilisateur ferme la fenêtre (plutôt que de contrôler nous même la fermeture via un ViewModel)
            // nous devons vérifier que le DataContext n'est pas nul (ce qui voudrait dire que ViewClosed a déjà été fait)
            if (DataContext != null)
            {
				//desabonnement de la vue à l'event du viewmodel
                ((BaseViewModel)DataContext).OnViewModelClosed -= ViewModelClosingHandler;
                ((BaseViewModel)DataContext).OnViewModelActivated -= ViewModelActivatingHandler;
				
                this.DataContext = null; // Assurez - vous que nous n'avons plus aucune référence VM
            }
        }

        /// <summary>
        /// Traitement de l'event Window Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ViewsWindow_Closed(object sender, EventArgs e)
        {
            // REMPLACER PAR ONCLOSEVIEWWINDOW
            OnWindowClosed?.Invoke(sender, e);

            ((BaseViewModel)DataContext).OnCloseViewModel(false);
        }

        #endregion

        #region Implementation IView

        public void ViewModelActivatingHandler(object sender, EventArgs e)
        {
            if(viewWindow != null)
			{
				viewWindow.Activate();
			}
        }

        public void ViewModelClosingHandler(object sender, ViewModelClosedEventArgs e)
        {
            if (viewWindow == null)
            {
                Panel panel = this.Parent as Panel;
                if (panel != null)
                {
                    panel.Children.Remove(this);
                }
            }
            else
            {
                ViewWindow.Closed -= ViewsWindow_Closed;

                if (viewWindow.IsDialogWindow)
                {
                    // si la fenetre est un dialog et non active, elle doit etre dans le processus de fermeture
                    if (viewWindow.IsActive)
                    {
                        ViewWindow.DialogResult = e.DialogResult;
                    }

                    ViewWindow.DialogResult = e.DialogResult;
                }
                else
                {
                    ViewWindow.Close();
                }

                ViewWindow = null;
            }

            // Traitez la méthode ViewClosed pour la gérer si cela a été déclenché par l'utilisateur qui ferme une fenêtre plutôt que par
            //la fermeture étant initiée par un ViewModel
            ViewClosed();
        }

        #endregion

        #region Methodes D'affichage

		#region Dans une nouvelle fenêtre
        
		/// <summary>
        /// Afficher ce contrôle dans une =nouvelle fenetre, de la taille du contenu, avec le titre de votre choix
        /// </summary>
        /// <param name="modal"></param>
        /// <param name="windowTitle"></param>
        public void ShowInWindow(bool modal, string windowTitle)
        {
			// renvoi au constructeurVue #2
            ShowInWindow(modal, windowTitle, 0, 0, Dock.Top, null);
        }

        /// <summary>
        /// Afficher ce contrôle dans une nouvelle fenetre, de la taille voulue, avec le titre de votre choix, et indication de l'ancrage du control
        /// </summary>
        /// <param name="modal"></param>
        /// <param name="windowTitle">titre de la fenetre</param>
        /// <param name="windowWidth">largeur de la fenetre</param>
        /// <param name="windowHeight">hauteur de la fenetre</param>
        /// <param name="dock">comment la vue doit être dockee</param>
        /// <param name="onWindowClose">traitement de l'event quand la fenetre est fermee</param>
        public void ShowInWindow(bool modal, string windowTitle, double windowWidth, double windowHeight, Dock dock, EventHandler onWindowClose)
        {
			// renvoi au constructeurVue #4
			// Ajout de la vue de base (new)
            ShowInWindow(modal, ViewWindow, windowTitle, windowWidth, windowHeight, dock, onWindowClose);
        }
		
		#endregion
		
		#region Dans une fenêtre existante
        
		/// <summary>
        /// Afficher ce contrôle dans une fenêtre fournie en parametre, par défaut, ancré en haut.
        /// </summary>
        /// <param name="modal"></param>
        /// <param name="window"></param>
        public void ShowInWindow(bool modal, ViewWindow window)
        {
            ShowInWindow(modal, window, window.Title, window.Width, window.Height, Dock.Top, null);
        }


        /// <summary>
        /// Affiche le controle dans une vue existante, dockable ou non
        /// </summary>
        /// <param name="modal"></param>
        /// <param name="window">fenetre dans laquelle la vue dout etre affichée</param>
        /// <param name="windowTitle">titre de la fenetre</param>
        /// <param name="windowWidth">largeur de la fenetre</param>
        /// <param name="windowHeight">hauteur de la fenetre</param>
        /// <param name="dock">Placement de la vue, null donne toute la place restante au control</param>
        /// <param name="onWindowClose">traitement de l'event quand la fenetre est fermee</param>
        public void ShowInWindow(ViewWindow window, Nullable<Dock> nDock, EventHandler onWindowClose)
        {
            //Dock dock = Dock.Top;
            // OnWindowClose methode de la classe ViewModel
            this.OnWindowClosed = onWindowClose;

            ViewWindow = window;

            if (nDock != null)
            {
                //dock = nDock.Value;
                DockPanel.SetDock(this, nDock.GetValueOrDefault());
            }
            

            // Le viewWindow doit avoir un dockPanel appelé WindowDockPanel. Si vous voulez changer ceci pour utiliser un autre conteneur sur la fenêtre, alors
            // le code ci - dessous devrait être le seul endroit où il doit être changé.
            viewWindow.WindowDockPanel.Children.Add(this);

        }    /// <summary>
             /// Flexibilité maximale de la version Définition de la fenêtre de Show In Window
             /// </summary>
             /// <param name="modal"></param>
             /// <param name="window">fenetre dans laquelle la vue dout etre affichée</param>
             /// <param name="windowTitle">titre de la fenetre</param>
             /// <param name="windowWidth">largeur de la fenetre</param>
             /// <param name="windowHeight">hauteur de la fenetre</param>
             /// <param name="dock">comment la vue doit être dockee</param>
             /// <param name="onWindowClose">traitement de l'event quand la fenetre est fermee</param>
        public void ShowInWindow(bool modal, ViewWindow window, string windowTitle, double windowWidth, double windowHeight, Dock dock, EventHandler onWindowClose)
        {
            // OnWindowClose methode de la classe ViewModel
            this.OnWindowClosed = onWindowClose;

            ViewWindow = window;
            ViewWindow.Title = windowTitle;
        
            DockPanel.SetDock(this, dock);

            // Le viewWindow doit avoir un dockPanel appelé WindowDockPanel. Si vous voulez changer ceci pour utiliser un autre conteneur sur la fenêtre, alors
            // le code ci - dessous devrait être le seul endroit où il doit être changé.
            viewWindow.WindowDockPanel.Children.Add(this);

            if (windowWidth == 0 && windowHeight == 0)
            {
                viewWindow.SizeToContent = SizeToContent.WidthAndHeight;
            }
            else
            {
                viewWindow.SizeToContent = SizeToContent.Manual;
                viewWindow.Width = windowWidth;
                viewWindow.Height = windowHeight;
            }

            if (modal)
            {
                viewWindow.ShowDialog();
            }
            else
            {
                viewWindow.Show();
            }
        }

		#endregion

        #endregion

        #region Membres disposables

        public void Dispose()
        {
            // supprime tous les event de la fenetre pour eviter les pb fuite memoire
            if (viewWindow != null)
            {
                viewWindow.Closed -= this.ViewsWindow_Closed;
            }
        }

        #endregion
   }
}
