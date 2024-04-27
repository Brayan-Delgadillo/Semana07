using Business;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Semana07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetPeople18_Click(object sender, RoutedEventArgs e)
        {
            PersonBusiness business = new PersonBusiness();
            dgPeople18.ItemsSource = business.GetPeople18();
        }

        private void GetCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomerBussiness business = new CustomerBussiness();
            dgCustomers.ItemsSource = business.GetCustomers();
        }
    }
}