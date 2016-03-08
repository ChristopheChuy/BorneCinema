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
using System.Collections.ObjectModel;
using GestionCinemaLib;
namespace GestionCinema
{
    /// <summary>
    /// Logique d'interaction pour SupprimerFilm.xaml
    /// </summary>
    public partial class SupprimerFilm : Window
    {
        public ObservableCollection<Film> LesFilms { get; set; }
        public SupprimerFilm(ObservableCollection<Film> films)
        {
            InitializeComponent();
            LesFilms = films;
            ListeFilmes.ItemsSource = LesFilms;

        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            if (ListeFilmes.SelectedItem != null)
            {
                LesFilms.Remove(ListeFilmes.SelectedItem as Film);
            }
            Close();
        }
    }
}
