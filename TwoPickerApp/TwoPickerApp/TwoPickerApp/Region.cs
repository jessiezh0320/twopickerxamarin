using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoPickerApp
{
    public class Region
    {
        public string RegionName { get; set; }

        public ObservableCollection<Street> Streets { set; get; }

        public Region()
        {
            Streets = new ObservableCollection<Street>();
        }
    }
}
