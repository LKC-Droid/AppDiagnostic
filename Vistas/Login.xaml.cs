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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            fecha.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (rutId.Text == "19922308-9" & pass.Password == "123")
            {
                this.Hide();
                Main NuevaVentana = new Main();
                NuevaVentana.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
                pass.Password = "";
            }
            
            
        }
    }

}
