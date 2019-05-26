using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel.ViewData
{
    public class FinderEditViewData : ToolEditViewData
    {
        [Range(0, 1000, ErrorMessage = "La profondeur doit être comprise entre 0 et 1000")]
        public decimal Depth
        {
            get => GetValue(() => Depth);
            set
            {
                if (Depth != value)
                {
                    SetValue(() => Depth, value);
                }
            }
        }

        [Range(0, 60, ErrorMessage = "La profondeur doit être comprise entre 0 et 1000")]
        public decimal Range
        {
            get => GetValue(() => Range);
            set
            {
                if (Range != value)
                {
                    SetValue(() => Range, value);
                }
            }
        }

        public short BasePecSearch
        {
            get => GetValue(() => BasePecSearch);
            set
            {
                if (BasePecSearch != value)
                {
                    SetValue(() => BasePecSearch, value);
                }
            }
        }
    }
}
