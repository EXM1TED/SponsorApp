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
using System.Windows.Shapes;
using Для_Абдурасула.Classes;
using Для_Абдурасула.Pages;

namespace Для_Абдурасула.Windows
{
    /// <summary>
    /// Логика взаимодействия для SponsorWindow.xaml
    /// </summary>
    public partial class SponsorWindow : Window
    {
        public SponsorWindow()
        {
            InitializeComponent();
            ClassHelper.frame = MainSponsorFrame;
            ClassHelper.frame.Navigate(new SponsorMainPage());
        }

        private void btnCancelPay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.frame.Navigate(new SponsorPageConfirm());
        }

        private void plusMoney_Click(object sender, RoutedEventArgs e)
        {

        }

        private void minusMoney_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
