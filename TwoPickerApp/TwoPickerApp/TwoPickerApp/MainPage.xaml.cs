using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwoPickerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var cities = new ObservableCollection<City>()
            {
                new City() { Key = 1, CityName = "Keelung", Regions = { new Region { RegionName = "CenterK" }, new Region { RegionName = "EastK" }, new Region { RegionName = "NorthK" }, new Region { RegionName = "WestK" }, new Region { RegionName = "SouthK" }, } },
                new City() { Key = 2, CityName = "Hsinchu", Regions = { new Region { RegionName= "HEast" }, new Region { RegionName = "HNorth" }, new Region { RegionName = "HCenter" } } },
                new City() { Key = 3, CityName = "Chiayi", Regions = { new Region { RegionName = "CEast" }, new Region { RegionName = "CWest" } } }
            };

            CityViewModel cityViewModel = new CityViewModel();
            cityViewModel.Cities = cities;

            BindingContext = cityViewModel;
        }
        private void DiameterPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityViewModel viewModel = BindingContext as CityViewModel;
            RegionPicker.ItemsSource = viewModel.Cities[((Picker)sender).SelectedIndex].Regions;
        }
    }
}
