using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MiningManager.ViewModel
{
    public interface IDatagridGeneratingColumns
    {
        Visibility SetColumnVisibility(string columnHeader);
        int SetColumnIndex(string columnHeader);
    }
}
