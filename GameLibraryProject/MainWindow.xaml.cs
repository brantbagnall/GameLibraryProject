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
using System.Data;
using System.Data.SqlClient;


namespace GameLibraryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            connectionButton.Click += ConnectionButton_Click;
        }

        private void ConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CNN"].ConnectionString;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            if (cnn.State.ToString() == "open")
            {

            }

        }
    }
}
