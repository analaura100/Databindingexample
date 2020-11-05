using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Databindingexample
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventModel evento;
        public MainWindow()
        {
            InitializeComponent();
            evento = new EventModel()
            {
                Title = "Reunión de trabajo",
                Date = new DateTime(2020, 11, 05)
            };
            //nombretextbox.Text = evento.Title;
            //fechadatepicker.SelectedDate = evento.Date;
            DataContext = evento;
        }

        private void modificareventobutton_Click(object sender, RoutedEventArgs e)
        {
            evento.Title = evento.Title.ToLower();
            evento.Date = evento.Date.AddDays(1); 
            nombretextbox.Text = evento.Title; 
            fechadatepicker.SelectedDate = evento.Date; 
            MessageBox.Show(evento.Title + "\n" + evento.Date);
        }
    }
}
