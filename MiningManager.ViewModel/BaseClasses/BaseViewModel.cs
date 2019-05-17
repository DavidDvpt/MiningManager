using MiningManager.ViewModel.ControllerInterfaces;
using System.Collections.Generic;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// Classe de base pour tous les ViewModel
    /// </summary>
    public class BaseViewModel : BindableBase
    {
        #region Constructeurs

        /// <summary>
        /// Constructeur utilisé lors de l'instanciation de itemManager.
        /// l'appel de la methode Init est obligatoire dans ce cas
        /// </summary>
        public BaseViewModel()
        {

        }
        /// <summary>
        /// Constructeur classique quand la view est instanciée via DataTemplate coté XAML (vue dans fenetre existante)
        /// </summary>
        /// <param name="controller"></param>
        public BaseViewModel(IController controller)
        {
            Controller = controller;
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
    }
}
