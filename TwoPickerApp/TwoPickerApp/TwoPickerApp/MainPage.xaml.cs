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
            //var cities = new ObservableCollection<City>()
            //{
            //    new City() { Key = 1, CityName = "Keelung", Regions = { new Region { RegionName = "CenterK" }, new Region { RegionName = "EastK" }, new Region { RegionName = "NorthK" }, new Region { RegionName = "WestK" }, new Region { RegionName = "SouthK" }, } },
            //    new City() { Key = 2, CityName = "Hsinchu", Regions = { new Region { RegionName= "HEast" }, new Region { RegionName = "HNorth" }, new Region { RegionName = "HCenter" } } },
            //    new City() { Key = 3, CityName = "Chiayi", Regions = { new Region { RegionName = "CEast" }, new Region { RegionName = "CWest" } } }
            //};

            var cities = new ObservableCollection<City>()
            {
                new City() { Key = 1, CityName = "Keelung", Regions = { new Region { RegionName = "CenterK" , Streets = { new Street { StreetName = "Street1_0" } , new Street { StreetName = "Street1_1" } } }, new Region { RegionName = "EastK", Streets = { new Street { StreetName = "Street1_2" }, new Street { StreetName = "Street1_3" } } }, new Region { RegionName = "NorthK", Streets = { new Street { StreetName = "Street1_4" }, new Street { StreetName = "Street1_4" } } }, new Region { RegionName = "WestK", Streets = { new Street { StreetName = "Street1_5" }, new Street { StreetName = "Street1_6" } } }, new Region { RegionName = "SouthK", Streets = { new Street { StreetName = "Street1_7" }, new Street { StreetName = "Street1_8" } } }, } },
                new City() { Key = 2, CityName = "Hsinchu", Regions = { new Region { RegionName= "HEast", Streets = { new Street { StreetName = "Street2_0" }, new Street { StreetName = "Street2_1" } } }, new Region { RegionName = "HNorth" , Streets = { new Street { StreetName = "Street2_2" }, new Street { StreetName = "Street2_3" } } }, new Region { RegionName = "HCenter", Streets = { new Street { StreetName = "Street2_4" }, new Street { StreetName = "Street2_5" } } } } },
                new City() { Key = 3, CityName = "Chiayi", Regions = { new Region { RegionName = "CEast", Streets = { new Street { StreetName = "Street3_0" }, new Street { StreetName = "Street3_1" } } }, new Region { RegionName = "CWest", Streets = { new Street { StreetName = "Street3_2" }, new Street { StreetName = "Street3_3" } } } } }
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

        private void RegionPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Region region =  ((sender as Picker).SelectedItem as Region);

            if (region != null)
            {
                StreetPicker.ItemsSource = region.Streets;
            }
            else {
                StreetPicker.ItemsSource = null;
            }

        }

        private void StreetPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Street street = ((sender as Picker).SelectedItem as Street);


        }
    }
}
