using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ValuteConverterZininaMatveeva.Model
{
    public class CurrencyService
    {
        private const string JSON_PATH = "https://www.cbr-xml-daily.ru/daily_json.js";
        public async Task LoadCurrencyAsync(ListView listView)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(JSON_PATH);

                if (!string.IsNullOrEmpty(response))
                {
                    Currency currency = JsonConvert.DeserializeObject<Currency>(response);

                    listView.ItemsSource = currency.Valute.Values;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
