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
using System.Data.SqlClient;
using System.Data;



namespace WpfApp10
{ 
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source=.,Datadialog=employee,Username=sa,Password=FIATS@2024";
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string x = "SELECT COUNT(*) FROM employees WHERE employ_name=@employ_name AND employ_password=@password";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string a=username.Text;
                string b=password.Text;
                //SqlCommand cmd = new SqlCommand(x,connection);
                using (SqlCommand cmd = new SqlCommand( x, connection) )
                {
                    cmd.Parameters.AddWithValue("@employ_name", a);
                    cmd.Parameters.AddWithValue("@employ_password", b);
                    cmd.ExecuteNonQuery(); 
                }
                Window window = new Window();
                window.Show();
                this.Close();



            }

        }

        

    }
}
