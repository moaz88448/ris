using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string connectionstring = "Data Source'.',Datadialog='employee',Username='sa',Password=FIATS@2024";
        public Window1()
        {
            InitializeComponent();
            MainWindow window = new MainWindow();
            window.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {






        }

        private void Load()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("selcet *from employees",con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                e.ItemsSource = dt.DefaultView;

            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string query = "Inset Into employees (name,password) values (@name,@password)";
            using(SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd=new SqlCommand(query,con);
               



            }
        }
    }
}
