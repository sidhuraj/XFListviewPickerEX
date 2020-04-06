using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewPickerEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatesListPage : ContentPage
    {
        public StatesListPage()     
        {
            InitializeComponent();

            string[] statesName = new string[8];
            statesName[0] = "Andrapradesh";
            statesName[1] = "Telangana";
            statesName[2] = "Karnataka";
            statesName[3] = "Chennai";
            statesName[4] = "Kerala"; 
            statesName[5] = "Delhi";
            statesName[6] = "Maharastra";
            statesName[7] = "Kolkata";

           
            lpicStateslist.ItemsSource = statesName;
            lpicStateslist.SelectedIndex = 1;
        }
    }
}