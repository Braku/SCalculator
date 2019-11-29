using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Resources;
using System.Windows.Controls.Primitives;

namespace SC
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.TRel.Focus();
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Smenu.Visibility == Visibility.Hidden)
            {
                Smenu.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                Smenu.Visibility = System.Windows.Visibility.Hidden;
                this.TRel.Focus();
            }
        }

        double a;
        double b;
        string c;

        private void B0_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "0";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "0";
                this.TRel.Focus();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "1";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "1";
                this.TRel.Focus();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "2";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "2";
                this.TRel.Focus();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "3";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "3";
                this.TRel.Focus();
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "4";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "4";
                this.TRel.Focus();
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "5";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "5";
                this.TRel.Focus();
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "6";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "6";
                this.TRel.Focus();
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "7";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "7";
                this.TRel.Focus();
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "8";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "8";
                this.TRel.Focus();
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "9";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + "9";
                this.TRel.Focus();
            }
        }

        private void BPor_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TRel.Text);
            c = "%";
            this.TRel.Text = Convert.ToString(a / 100);
            this.TRel.Focus();
        }

        private void BPunto_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = ".";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text + ".";
                this.TRel.Focus();
            }
        }

        private void BDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TRel.Text);
            c = "/";
            this.TRel.Clear();
            this.TRel.Focus();
        }

        private void BMult_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TRel.Text);
            c = "*";
            this.TRel.Clear();
            this.TRel.Focus();
        }

        private void BMas_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TRel.Text);
            c = "+";
            this.TRel.Clear();
            this.TRel.Focus();
        }

        private void BMenos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TRel.Text);
            c = "-";
            this.TRel.Clear();
            this.TRel.Focus();
        }

        private void BCE_Click(object sender, EventArgs e)
        {

            if (TRel.Text.Length == 1)
            {
                TRel.Text = "";
                this.TRel.Focus();
            }
            else
            {
                TRel.Text = TRel.Text.Substring(0, TRel.Text.Length - 1);
                this.TRel.Focus();
            }
        }

        private void BC_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble("0");
            b = Convert.ToDouble("0");
            this.TRel.Text = "";
            this.TRel.Focus();
        }

        private void BIgual_Click(object sender, EventArgs e)
        {
            if (TRel.Text.Length > 0)
            {
                string contra = TRel.Text;
                if (contra == "0000")
                {
                    VentanaInicio VI = new VentanaInicio();
                    VI.Show();
                    this.Close();
                }

                b = Convert.ToDouble(this.TRel.Text);
                switch (c)
                {
                    case "+":
                        this.TRel.Text = Convert.ToString((b) + (a));
                        break;

                    case "-":
                        this.TRel.Text = Convert.ToString((b) - (a));
                        break;

                    case "*":
                        this.TRel.Text = Convert.ToString((b) * (a));
                        break;

                    case "/":
                        this.TRel.Text = Convert.ToString((b) / (a));
                        break;
                }
            }
            this.TRel.Focus();
        }

        private void TRel_TextChanged(object sender, EventArgs e)
        {
            if (TRel.Text == c)
            {
                if (TRel.Text.Length == 1)
                {
                    TRel.Text = "";
                }
                else
                {
                    TRel.Text = TRel.Text.Substring(0, TRel.Text.Length - 1);
                }
            }
        }

        private void TRel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.TRel.Focus();
                this.BIgual.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            if (e.Key == Key.Add)
            {
                this.TRel.Focus();
                this.BMas.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            if (e.Key == Key.Subtract)
            {
                this.TRel.Focus();
                this.BMenos.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            if (e.Key == Key.Divide)
            {
                this.TRel.Focus();
                this.BDiv.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            if (e.Key == Key.Multiply)
            {
                this.TRel.Focus();
                this.BMult.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }

    }
}
      