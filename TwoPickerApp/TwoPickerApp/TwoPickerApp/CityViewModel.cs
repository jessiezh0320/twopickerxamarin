using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoPickerApp
{
    public class CityViewModel
    {
        public ObservableCollection<City> Cities { get; set; }

        public CityViewModel()
        {
            Cities = new ObservableCollection<City>();
        }
    }
}
