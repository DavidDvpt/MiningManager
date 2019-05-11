using MiningManager.ViewModel.CustomEventArgs;
using System;

namespace MiningManager.ViewModel
{
    public interface IView
    {
        object DataContext { get; set; }
    }
}
