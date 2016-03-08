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
    /// Logique d'interaction pour Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public LesPersonnes Personnes { get; set; }
        public LesFilms Films { get; set; }
        public LesSalles Salles { get; set; }
        public Admin(LesFilms films, LesSalles salles, LesPersonnes personnes)
        {
            InitializeComponent();
            Films = films;
            Salles = salles;
            Personnes = personnes;
            ListeDeFilm.ItemsSource = Films;
        }
        private void AjoutFilm(object sender, RoutedEventArgs e)
        {
            AjouterFilm ajFilm = new AjouterFilm(Films);
            ajFilm.Show();
        }

        private void AjoutSalle(object sender, RoutedEventArgs e)
        {
            AjouterSalle ajSalle = new AjouterSalle(Salles);
            ajSalle.Show();
        }

        private void AjoutSeance(object sender, RoutedEventArgs e)
        {
            if ((ListeDeFilm.SelectedItem as Film) == null)
                MessageBox.Show("Aucun Film Selectionné");
            else
            {
                AjouterSeance ajSeance = new AjouterSeance(Salles, ListeDeFilm.SelectedItem as Film, Personnes);
                ajSeance.Show();
            }
        }

        private void SupprimerSeance(object sender, RoutedEventArgs e)
        {
            if ((ListeDeFilm.SelectedItem as Film).LesSeances.Count == 0)

                MessageBox.Show("Aucune Seance pour le film selectionné");
            else
            {
                SupprimerSeance supSeance = new SupprimerSeance(ListeDeFilm.SelectedItem as Film);
                supSeance.Show();
            }
        }

        private void SupSalle(object sender, RoutedEventArgs e)
        {

            if (Salles.Count == 0)

                MessageBox.Show("Aucune salle a suprimée");
            else
            {
                SupprimerSalle supSalle = new SupprimerSalle(Salles, Films);
                supSalle.Show();
            }
        }

        private void SupprimerFilm(object sender, RoutedEventArgs e)
        {
            if (Films.Count == 0)

                MessageBox.Show("Aucun film a supprimé");
            else
            {
                SupprimerFilm supFilm = new SupprimerFilm(Films);
                supFilm.Show();
            }
        }

        private void NouveauProg(object sender, RoutedEventArgs e)
        {
            foreach (Film film in Films)
                film.LesSeances.Clear();
        }

        private void SupPersonne(object sender, RoutedEventArgs e)
        {
            if (Personnes.Count == 0)
                MessageBox.Show("Aucun Projectionniste a supprimée");
            else
            {
                SupprimerPersonne supprimerPersonne = new SupprimerPersonne(Personnes, Films);
                supprimerPersonne.Show();
            }
        }

        private void AjouPersonnes(object sender, RoutedEventArgs e)
        {
            AjouterPersonne ajPersonne = new AjouterPersonne(Personnes);
            ajPersonne.Show();
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
