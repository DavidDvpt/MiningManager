using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel.ViewData
{
    public class FinderItemListViewData : BaseViewData  
    {
        public int Id;

        public string Nom
        {
            get => GetValue(() => Nom);
            set
            {
                if (Nom != value)
                {
                    SetValue(() => Nom, value);
                }
            }
        }

        public decimal Value
        {
            get => GetValue(() => Value);
            set
            {
                if (Value != value)
                {
                    SetValue(() => Value, value);
                }
            }
        }

        public bool IsLimited
        {
            get => GetValue(() => IsLimited);
            set
            {
                if (IsLimited != value)
                {
                    SetValue(() => IsLimited, value);
                }
            }
        }

        public decimal Decay
        {
            get => GetValue(() => Decay);
            set
            {
                if (Decay != value)
                {
                    SetValue(() => Decay, value);
                }
            }
        }

        public string Code
        {
            get => GetValue(() => Code);
            set
            {
                if (Code != value)
                {
                    SetValue(() => Code, value);
                }
            }
        }

        public short UsePerMin
        {
            get => GetValue(() => UsePerMin);
            set
            {
                if (UsePerMin != value)
                {
                    SetValue(() => UsePerMin, value);
                }
            }
        }

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
