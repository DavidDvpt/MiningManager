using System;
using System.Windows.Controls;

namespace MiningManager.View
{
    /// <summary>
    /// Délégué qui autorise le traitement de l'event WindowClosed 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void OnWindowClose(Object sender, EventArgs e);

    /// <summary>
    /// c'est la classe de base de toutes les vues
    /// elle ne peut pas être abstraite car ca va causer des pb qd "design time"
    /// va essayer d'instancier cette classe
    /// cette viex n'a pas de XAML car on ne peux pas heriter d'une classe XAML
    /// </summary>
    public class BaseView : UserControl, IDisposable, IView
    {
        #region Champs

        private ViewWindow viewWindow; // si affiché dans une fenêtre, la voila
        private OnWindowClose onWindowClosed = null;

        #endregion

        #region Implementation IView

        public void ViewModelActivatingHandler()
        {
            throw new NotImplementedException();
        }

        public void ViewModelClosingHandler(bool? dialogResult)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
