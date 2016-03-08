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
    /// Logique d'interaction pour SupprimerPersonne.xaml
    /// </summary>
    public partial class SupprimerPersonne : Window
    {
        public LesFilms Films { get; set; }
        public LesPersonnes Personnes { get; set; }
        public SupprimerPersonne(LesPersonnes personnes,LesFilms films)
        {
            InitializeComponent();
            Films = films;
            Personnes = personnes;
            ListePersonnes.ItemsSource = Personnes;

        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // Supprime la personnes dans la liste de personnes et supprime les seances auquelle elle participe
        private void valider(object sender, RoutedEventArgs e)
        {
            if (ListePersonnes.SelectedItem != null)
            {
                foreach (Film film in Films)
                {
                    for (int i = film.LesSeances.Count-1; i >= 0; i--)
                    {
                        if (film.LesSeances[i].Projectioniste.Equals(ListePersonnes.SelectedItem as Personne))
                            film.LesSeances.RemoveAt(i);
                    }
                }
                Personnes.Remove(ListePersonnes.SelectedItem as Personne);
            }
            Close();
        }
    }
}
