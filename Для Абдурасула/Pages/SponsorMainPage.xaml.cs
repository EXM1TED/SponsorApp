using System;
using System.Collections.Generic;
using System.Linq;
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
using Для_Абдурасула.Classes;
using Для_Абдурасула.Windows;

namespace Для_Абдурасула.Pages
{
    /// <summary>
    /// Логика взаимодействия для SponsorMainPage.xaml
    /// </summary>
    public partial class SponsorMainPage : Page
    {
        public SponsorMainPage()
        {
            InitializeComponent();
            moneyPay.Text = string.Format($"{50}");
            ClassHelper.cash = 50;
        }
        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.frame.Navigate(new SponsorPageConfirm());
        }

        private void minusMoney_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(moneyPay.Text);
            i--;
            moneyPay.Text = i.ToString();
            ClassHelper.cash = Convert.ToInt32(moneyPay.Text);
        }

        private void plusMoney_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(moneyPay.Text);
            i++;
            moneyPay.Text = i.ToString();
            ClassHelper.cash = Convert.ToInt32(moneyPay.Text);
        }

        private void btnCancelPay_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window sponsorWinodw = Window.GetWindow(this);
            sponsorWinodw.Close();
        }
    }
}
