using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel.ViewData
{
    class ItemsListManagerViewData : BaseViewData
    {
        public ObservableCollection<BaseViewData> Items
        {
            get => GetValue(() => Items);
            set
            {
                if (Items != value)
                {
                    SetValue(() => Items, value);
                }
            }
        }
    }
}
