using AppMaui.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AppMaui.Service
{
    public class DrinkService{
        HttpClient httpClient;
        List<Drink> drinks;
        const string REQUEST_URL = "https://gist.githubusercontent.com/dgbarreto/b04b167bc3eb58925c14ee55c69a7746/raw/9769d0a77014bd82c8eb060984e5dbed824712da/drinks.json";

        public DrinkService(){
            httpClient = new HttpClient();
        }

        public async Task<List<Drink>> GetDrinksAsync(){
            if(drinks?.Count > 0){
                return drinks;
            }

            var response = await httpClient.GetAsync(REQUEST_URL);

            if (response.IsSuccessStatusCode){
                drinks = await response.Content.ReadFromJsonAsync<List<Drink>>();
            }

            return drinks;

        }

    }
}
