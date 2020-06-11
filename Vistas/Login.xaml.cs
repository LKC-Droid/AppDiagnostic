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
using System.Windows.Threading;

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
            fecha.Content = DateTime.Now.ToString("dddd dd");
            fecha2.Content = DateTime.Now.ToString("MMMMM");
            Año.Content = DateTime.Now.ToString("yyyy");
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Hora.Content = DateTime.Now.ToString("HH:mm");
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
