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
using GestionCinemaLib;
using System.Collections.ObjectModel;
namespace GestionCinema
{
    /// <summary>
    /// Logique d'interaction pour SupprimerSeance.xaml
    /// </summary>
    public partial class SupprimerSeance : Window
    {
        public Film Film { get; set; } //Film sur lequelle nous llons supprimée une seance
        public SupprimerSeance(Film film)
        {
            InitializeComponent();
            Film = film;
            ListeSeances.ItemsSource = Film.LesSeances;
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            if (ListeSeances.SelectedItem != null)
                Film.LesSeances.Remove(ListeSeances.SelectedItem as Seance);
            Close();
        }

    }
}
