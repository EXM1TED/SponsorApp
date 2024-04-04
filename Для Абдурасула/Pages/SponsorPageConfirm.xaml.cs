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
    /// Логика взаимодействия для SponsorPageConfirm.xaml
    /// </summary>
    public partial class SponsorPageConfirm : Page
    {
        public SponsorPageConfirm()
        {
            InitializeComponent();
            int cash = ClassHelper.cash;
            this.DataContext = cash;
        }

        private void btnReturnToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.frame.Navigate(new SponsorMainPage());
        }
    }
}
