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
using System.IO;
using System.Data.SqlClient;
using LSM;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string connectionString = "Data Source=.;Initial Catalog=app;User ID=sa;Password=FIATS@2024;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 L_page = new Window1();
            MainWindow mainWindow = new MainWindow();
            L_page.Show();
           
            mainWindow.Hide();


        }

        private void signup_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window1_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void ffggfffff(object sender, NavigatingCancelEventArgs e)
        {

        }
    }
}
