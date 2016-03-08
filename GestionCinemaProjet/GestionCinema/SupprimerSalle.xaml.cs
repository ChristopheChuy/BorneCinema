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
    /// Logique d'interaction pour SupprimerSalle.xaml
    /// </summary>
    public partial class SupprimerSalle : Window
    {

        public LesFilms Films { get; set; }
        public LesSalles LesSalles { get; set; }
        public SupprimerSalle(LesSalles salles, LesFilms films)
        {
            InitializeComponent();
            LesSalles = salles;
            Films = films;
            ListeSalles.ItemsSource = LesSalles;
        }
        private void fermer(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            if (ListeSalles.SelectedItem != null)
            {
                foreach (Film film in Films)
                {
                    for (int i = film.LesSeances.Count - 1; i >= 0; i--)
                    {
                        if (film.LesSeances[i].LaSalle.Equals(ListeSalles.SelectedItem as Salle))
                            film.LesSeances.RemoveAt(i);
                    }
                }
                LesSalles.Remove(ListeSalles.SelectedItem as Salle);
            }
            Close();
        }
    }
}
