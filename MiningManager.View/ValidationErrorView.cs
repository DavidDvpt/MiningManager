using MiningManager.ViewModel;
using System.Windows.Controls;

namespace MiningManager.View
{
    public class ValidationErrorView : UserControl
    {
        protected void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added) BindableBase.Errors += 1;
            if (e.Action == ValidationErrorEventAction.Removed) BindableBase.Errors -= 1;
        }
    }
}
