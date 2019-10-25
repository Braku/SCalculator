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
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            Smenu.Visibility = System.Windows.Visibility.Visible;
        }
        private void BtnMenu1_Click(object sender, RoutedEventArgs e)
        {
            Smenu.Visibility = System.Windows.Visibility.Hidden;
        }

        double a;
        double b;
        string c;

        private void B0_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "0";
            }
            else
            {
                TRel.Text = TRel.Text + "0";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "1";
            }
            else
            {
                TRel.Text = TRel.Text + "1";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "2";
            }
            else
            {
                TRel.Text = TRel.Text + "2";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "3";
            }
            else
            {
                TRel.Text = TRel.Text + "3";
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "4";
            }
            else
            {
                TRel.Text = TRel.Text + "4";
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "5";
            }
            else
            {
                TRel.Text = TRel.Text + "5";
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "6";
            }
            else
            {
                TRel.Text = TRel.Text + "6";
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "7";
            }
            else
            {
                TRel.Text = TRel.Text + "7";
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "8";
            }
            else
            {
                TRel.Text = TRel.Text + "8";
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (TRel.Text == "")
            {
                TRel.Text = "9";
            }
            else
            {
                TRel.Text = TRel.Text + "9";
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
            }
            else
            {
                TRel.Text = TRel.Text + ".";
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
            }
            else
            {
                TRel.Text = TRel.Text.Substring(0, TRel.Text.Length - 1);
            }
        }

        private void BC_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble("0");
            b = Convert.ToDouble("0");
            this.TRel.Text = "";
        }

        private void BIgual_Click(object sender, EventArgs e)
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

        //private void TRel_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        BIgual.PerformClick();
        //        this.TRel.Focus();
        //    }
        //    if (e.KeyChar == 43)
        //    {
        //        bmas.PerformClick();
        //        this.TRel.Focus();
        //    }
        //    else if (e.KeyChar == 45)
        //    {
        //        bres.PerformClick();
        //        this.TRel.Focus();
        //    }
        //    else if (e.KeyChar == 42)
        //    {
        //        bmult.PerformClick();
        //        this.TRel.Focus();
        //    }
        //    else if (e.KeyChar == 47)
        //    {
        //        bdiv.PerformClick();
        //        this.TRel.Focus();
        //    }
        //    else if (e.KeyChar == 37)
        //    {
        //        bpo.PerformClick();
        //        this.TRel.Focus();
        //    }
        //}

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
    }
}
      