using MiningManager.Controller;
using MiningManager.View;
using MiningManager.ViewModel.ViewData;
using System.Collections.Generic;

namespace BaseClasses
{
    /// <summary>
    /// Classe de base pour tous les ViewModel
    /// </summary>
    public class BaseViewModel : BindableBase
    {
		#region Evenements
		/// <summary>
		/// Quand le VueModel est fermé, les vues associées doivent fermer aussi
		/// </summary>
		/// <param name="dialogResult"></param>
        public event EventHandler<ViewModelClosingEventArgs> ViewModelClosing;
    
		/// <summary>
		/// Quand un ViewModel pre-exisant est activé, la vue doit s'activer aussi
		/// </summary>
        public event EventHandler ViewModelActivating;
        
		#region Nested Classe
		
		private class ViewModelClosingEventArgs : EventArgs
		{
			public bool? DialogResult { get; set; }
		}
		
		#endregion
		#endregion
		
        #region Constructeurs

        /// <summary>
        /// Constructeur classique quand la view est instanciée via DataTemplate coté XAML (vue dans fenetre existante)
        /// </summary>
        /// <param name="controller"></param>
        public BaseViewModel(IController controller)
        {
            Controller = controller;
        }

        /// <summary>
        /// Constructeur avec vue associée (donc fenêtre)
        /// Le ViewModel ne conserve pas de reférence de la vue, 
        /// le constructeur abonne seulement les gestionnaires d'evenement des vues
        /// aux events associés du ViewModel
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="view"></param>
        public BaseViewModel(IController controller, IView view)
            : this(controller)
        {
            if (view != null)
            {
                // Affectation du datacontext ds le code plutot que par le XAML
                // Afin de pouvoir passer des elemnts au constructeur le cas echeant
                view.DataContext = this;
				
				// Abonnement des gestionnaires de la vue
                ViewModelClosing += view.ViewModelClosingHandler;
                ViewModelActivating += view.ViewModelActivatingHandler;
            }
        }

        #endregion
        
        /// <summary>
        /// Conservez une liste de tous les enfants ViewModels afin que nous puissions
        /// les supprimer en toute sécurité lorsque ce ViewModel est fermé.
        /// </summary>
        public List<BaseViewModel> ChildViewModels { get; private set; } = new List<BaseViewModel>();
        
        /// <summary>
        /// Si le viewModel veut faite quelque chose il a besoin du controller
        /// </summary>
        public IController Controller { get; set; }
        
        #region Propriétés bindables

        public BaseViewData ViewData
        {
            get { return GetValue(() => ViewData); }
            set
            {
                if (ViewData != value)
                {
                    SetValue(() => ViewData, value);
                }
            }
        }
        
        #endregion

        #region Declencheurs d'evenements

        public void OnCloseViewModel(bool? dialogResult)
        {
            // desenregistre ce viewModel de messenger
            Controller.Messenger.DeRegister(this);
            if (ViewModelClosing != null)
            {
				ViewModelClosingEventArgs e = new ViewModelClosingEventArgs()
				e.DialogResult = dialogResult;
				
				EventHandler<ViewModelClosingEventArgs> handler = ViewModelClosing
                handler(this, e);
            }

            // Declclenche l'evenement chez tous les viewModels enfants
            foreach (var childViewModel in ChildViewModels)
            {
                childViewModel.OnCloseViewModel(dialogResult);
            }
        }

        public void OnActivateViewModel()
        {
            if (ViewModelActivating != null)
            {
				EventHandler<ViewModelClosingEventArgs> handler = ViewModelActivating
                handler(this, EventArgs.Empty);
            }
        }

        #endregion

    }
}
