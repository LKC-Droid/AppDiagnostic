using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diagnos.Vistas
{
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registro_de_cita.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Pacientes.Visibility = Visibility.Hidden;
            Agenda.Visibility = Visibility.Visible;
            menu3.IsExpanded = false;
            menu2.IsExpanded = false;
            menu1.IsExpanded = false;
            menu.IsExpanded = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            menu3.IsExpanded = false;
            menu2.IsExpanded = false;
            menu1.IsExpanded = false;
            menu.IsExpanded = false;

            Agenda.Visibility = Visibility.Hidden;
            Pacientes.Visibility = Visibility.Visible;
            
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
