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

namespace SC
{
    /// <summary>
    /// Lógica de interacción para Inicio_Sesion.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.username.Focus();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=usuarios;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT first_name, last_name, username FROM users WHERE username = '" + username.Text + "' AND password = '" + pass.Password + "'";
            if (username.Text != "")
            {
                if (pass.Password != "")
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        string a = read["first_name"].ToString();
                        string b = read["last_name"].ToString();
                        string c = read["username"].ToString();
                        MessageBox.Show("Welcome.");
                        VentanaInicio vi = new VentanaInicio(a, b, c) ;
                        vi.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Access denied, the username or password might be wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Lin.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }

        private void Logincan_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
