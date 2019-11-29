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
    public partial class signup : Window
    {
        public signup()
        {
            InitializeComponent();
        }

        private void singup_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=reg_sechma;";
            if (username.Text != "")
            {
                if (pass.Password != "")
                {
                    string querty = "z";

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    MySqlCommand cmd = new MySqlCommand(querty, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso.");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Favor introduce tu correo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor introduce tu nombre", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.Close();
        }

        private void TextBlock_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {

        }
    }
}
