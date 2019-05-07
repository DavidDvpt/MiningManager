using MiningManager.ViewModel.CustomEventArgs;
using System;

namespace MiningManager.View
{
    public interface IView
    {
        // fermeture du viewModel
        void ViewModelClosingHandler(object sender, ViewModelClosedEventArgs e);

        // Activation du viewModel
        void ViewModelActivatingHandler(object sender, EventArgs e);

        object DataContext { get; set; }
    }
}
