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

namespace WpMayorEdad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.lblResultado.Background = Brushes.White;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.txtEdad.Text = string.Empty;
            this.lblResultado.Content = string.Empty;
            this.lblResultado.Background= Brushes.White;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int edad;
            string strEdad;
            strEdad = this.txtEdad.Text;
            int.TryParse(strEdad, out edad);
            if (edad > 18)
            {
                this.lblResultado.Content = "Es mayor de edad";
                this.lblResultado.Background = Brushes.Red;
            }
        }
    }
}
