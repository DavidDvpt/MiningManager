using System.Windows;

/// <summary>
/// Logique d'interaction pour ViewWindow.xaml
/// </summary>
namespace MiningManager.View
{
    /// <summary>
    /// Logique d'interaction pour ViewWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties

        public bool IsDialogWindow { get; set; }

        #endregion

        public ViewWindow()
        {
            InitializeComponent();
        }
    }
}
