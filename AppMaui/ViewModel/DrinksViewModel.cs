using AppMaui.Model;
using AppMaui.Service;
using AppMaui.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaui.ViewModel
{
    public partial class DrinksViewModel : BaseViewModel {
        DrinkService drinkService;
        public ObservableCollection<Drink> Drinks { get; } = new();

        public DrinksViewModel(DrinkService drinkService){
            this.drinkService = drinkService;
        }

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        async Task GetDrinksAsync()
        {
            if (IsBusy) return;
            try
            {
                IsBusy = true;

                var drinks = await drinkService.GetDrinksAsync();

                if (drinks?.Count > 0)
                {
                    Drinks.Clear();
                }

                drinks.ForEach(d => Drinks.Add(d));

            }catch(Exception e)
            {
                Debug.WriteLine($"Unable to return drinks. {e.Message}");
                await Shell.Current.DisplayAlert("Error", "Unable to fetch drinks!", "OK");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GoToDetails(Drink drink)
        {
            if (drink == null) return;

            await Shell.Current.GoToAsync(nameof(DrinkDetailsPage), true, new Dictionary<string, object>{
                {"Drink", drink}
            });
        }

    }
}
