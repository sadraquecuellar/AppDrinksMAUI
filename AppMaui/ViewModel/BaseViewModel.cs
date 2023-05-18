using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaui.ViewModel
{
    public partial class BaseViewModel : ObservableObject {
        [ObservableProperty]
        bool isBusy;

        [ObservableProperty]
        string title;
    } 
}
