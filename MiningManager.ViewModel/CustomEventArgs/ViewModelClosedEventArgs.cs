using System;

namespace MiningManager.ViewModel.CustomEventArgs
{
    public class ViewModelClosedEventArgs : EventArgs
    {
        public bool? DialogResult { get; set; }
    }
}
