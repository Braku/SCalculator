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
            string connectionString = "datasource=127.0.0.1;username=root;password=Brambila1402;database=usuarios;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM users WHERE username = '" +username.Text+ "';";
            if (fname.Text != "")
            {
                if (lname.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        MessageBox.Show("The user already exists, use another one", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        usercau.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        connection.Close();
                        if (pass.Password != "" & pass.Password.Length >= 6)
                        {
                            usercau.Visibility = System.Windows.Visibility.Collapsed;
                            if (cpass.Password == pass.Password)
                            {
                                passcau.Visibility = System.Windows.Visibility.Collapsed;
                                connection.Open();
                                if (read.Read())
                                {
                                    MessageBox.Show("The e-mail is used, use another one", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    usercau.Visibility = System.Windows.Visibility.Visible;
                                }
                                else if (email.Text != "")
                                {
                                    connection.Close();
                                    string query1 = "INSERT INTO users(first_name, last_name, username, email, password) VALUES('" +fname.Text+ "', '" +lname.Text+ "', '" + username.Text + "', '" + email.Text + "', '" + pass.Password + "');";
                                    MySqlCommand comm = new MySqlCommand(query1, connection);
                                    connection.Open();
                                    comm.ExecuteNonQuery();
                                    MessageBox.Show("User signed up succesfully", "Seccesful", MessageBoxButton.OK, MessageBoxImage.Information);
                                    this.Close();
                                    connection.Close();
                                }
                                else
                                { 
                                    MessageBox.Show("Please enter an e-mail", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    passcau.Visibility = System.Windows.Visibility.Collapsed;
                                    mailcau.Visibility = System.Windows.Visibility.Visible;
                                }
                            }
                            else
                            {
                                MessageBox.Show("The password is not the same", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                cpasscau.Visibility = System.Windows.Visibility.Visible;
                            }
                        }
                        else
                        {
                            if (pass.Password == "" || username.Text == "")
                            {
                                MessageBox.Show("Complete all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                usercau.Visibility = System.Windows.Visibility.Visible;
                            }
                            else if (pass.Password.Length <= 5)
                            {
                                MessageBox.Show("The password is too short, try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            passcau.Visibility = System.Windows.Visibility.Visible;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            Login lin = new Login();
            lin.Show();
            this.Close();
        }

        private void Signup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.sup.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }
    }
}
