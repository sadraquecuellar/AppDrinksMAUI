using AppMaui.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaui.ViewModel
{
    [QueryProperty(nameof(SelectedDrink),"Drink")]
    public partial class DrinkDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Drink selectedDrink;
    }
}
