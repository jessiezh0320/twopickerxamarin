using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoPickerApp
{
    public class City
    {
        public int Key { get; set; }
        public string CityName { get; set; }

        public ObservableCollection<Region> Regions { set; get; }

        public City()
        {
            //Regions = Regions ?? new List<string>();
            Regions = new ObservableCollection<Region>();
        }
    }
}
