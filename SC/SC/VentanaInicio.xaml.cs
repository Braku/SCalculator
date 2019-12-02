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
using MySql.Data.MySqlClient;
using System.Data;

namespace SC
{
    /// <summary>
    /// Lógica de interacción para VentanaInicio.xaml
    /// </summary>
    public partial class VentanaInicio : Window
    {
        public VentanaInicio()
        {
            InitializeComponent();
            full_name();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            full_name();
            if (signup.Visibility == System.Windows.Visibility.Collapsed & login.Visibility == System.Windows.Visibility.Collapsed)
            {
                signup.Visibility = System.Windows.Visibility.Visible;
                login.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                signup.Visibility = System.Windows.Visibility.Collapsed;
                login.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Folders_Click(object sender, RoutedEventArgs e)
        {
            if (Folders.Visibility == System.Windows.Visibility.Collapsed)
            {
                Folders.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                Folders.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login lin = new Login();
            lin.Show();
            if (signup.Visibility == System.Windows.Visibility.Collapsed & login.Visibility == System.Windows.Visibility.Collapsed)
            {
                signup.Visibility = System.Windows.Visibility.Visible;
                login.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                signup.Visibility = System.Windows.Visibility.Collapsed;
                login.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            if (signup.Visibility == System.Windows.Visibility.Collapsed & login.Visibility == System.Windows.Visibility.Collapsed)
            {
                signup.Visibility = System.Windows.Visibility.Visible;
                login.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                signup.Visibility = System.Windows.Visibility.Collapsed;
                login.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void full_name()
        {
            Login lin = new Login();
            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=usuarios;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM users;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                first_name.Text = read["first_name"].ToString();
                last_name.Text = read["last_name"].ToString();
            }
            connection.Close();
        }
    }
}
