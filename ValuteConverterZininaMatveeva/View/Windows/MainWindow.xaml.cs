using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValuteConverterZininaMatveeva.Model;

namespace ValuteConverterZininaMatveeva
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CurrencyService _currencyService;
        public MainWindow()
        {
            InitializeComponent();
            _currencyService = new CurrencyService();
        }
       
        private void SellCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PurchaseCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateCourseBtn_Click(object sender, RoutedEventArgs e)
        {
            _currencyService.LoadCurrencyAsync(CurrencyLV);
        }

        private void ConvertBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
