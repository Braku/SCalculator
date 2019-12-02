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
using Microsoft.Win32;
using System.Data;

namespace SC
{
    /// <summary>
    /// Lógica de interacción para VentanaInicio.xaml
    /// </summary>
    public partial class VentanaInicio : Window
    {
        public VentanaInicio(string fname, string lname, string user)
        {
            InitializeComponent();
            tbfname.Text = fname;
            tblname.Text = lname;
            profile.Content = user;

            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=usuarios;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT photo FROM users WHERE username = '" + profile.Content + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                photo.Visibility = System.Windows.Visibility.Collapsed;
                photoch.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                photoch.Visibility = System.Windows.Visibility.Collapsed;
                photo.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            if (MessageBox.Show("Are you sure that you want to sign out", "Caution", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MW.Show();
                this.Close();
            }
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            if (sout.Visibility == System.Windows.Visibility.Collapsed)
            {
                sout.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                sout.Visibility = System.Windows.Visibility.Collapsed;
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

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void ChPin_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=usuarios;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "UPDATE pin SET pinid = '" + ChPin.Text + "' WHERE id = 1;";
            if (ChPin.Visibility == System.Windows.Visibility.Hidden)
            {
                ChPin.Visibility = System.Windows.Visibility.Visible;
            }
            else if (ChPin.Visibility == System.Windows.Visibility.Visible)
            {
                if (MessageBox.Show("Are you sure you want to chanche the pin?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    ChPin.Visibility = System.Windows.Visibility.Hidden;
                }
                else
                {
                    ChPin.Visibility = System.Windows.Visibility.Hidden;
                }
            }

        }

        private void photoch_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=usuarios;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "UPDATE users SET photo = LOAD_FILE('" + photo.Source + "') WHERE username = '" + profile.Content + "';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                photo.Source = new BitmapImage(new Uri(op.FileName));
            }
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            photoch.Visibility = System.Windows.Visibility.Collapsed;
            photo.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
