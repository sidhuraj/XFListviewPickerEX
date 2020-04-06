using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListviewPickerEx
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            List<Vehicle> objVehicleList = new List<Vehicle>();
            objVehicleList.Add(new Vehicle { VechiclePhoto = "icon.png", VechicleName = "Honda Activa", VechicleColor = "Red" });
            objVehicleList.Add(new Vehicle { VechiclePhoto = "icon.png", VechicleName = "pulsur", VechicleColor = "Red" });
            objVehicleList.Add(new Vehicle { VechiclePhoto = "icon.png", VechicleName = "R15", VechicleColor = "Red" });
            objVehicleList.Add(new Vehicle { VechiclePhoto = "icon.png", VechicleName = "Yamaha", VechicleColor = "Red" });



            lbxVechiclesList.ItemsSource = objVehicleList;




            btnStatespage.Clicked += BtnStatespage_Clicked;
        }

        private void BtnStatespage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StatesListPage());
        }
    }
}
