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
    /// Logique d'interaction pour AjouterSeance.xaml
    /// </summary>
    public partial class AjouterSeance : Window
    {
        ObservableCollection<Salle> salles;
        public Film LeFilm { get; set; }
        public LesPersonnes Personnes { get; set; }
        public AjouterSeance(ObservableCollection<Salle> salles, Film film, LesPersonnes personnes)
        {
            InitializeComponent();
            this.salles = salles;
            Personnes = personnes;
            LeFilm = film;
            Projectionniste.ItemsSource = Personnes;
            Salle.ItemsSource = salles;

        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ajouter(object sender, RoutedEventArgs e)
        {
            if (Salle.SelectedIndex == -1)
                MessageBox.Show("Salle non selectionné");
            if (Projectionniste.SelectedIndex == -1)
                MessageBox.Show("Projectionniste non selectionné");
            if(string.IsNullOrWhiteSpace(Horaire.Text))
                MessageBox.Show("Horaire invalide");
            if (string.IsNullOrWhiteSpace(Horaire.Text) || Projectionniste.SelectedIndex == -1 || Salle.SelectedIndex == -1) // si Donnée non valide
                return;
            Salle salle = Salle.SelectedItem as Salle;
            Seance s = new Seance(Horaire.Text, salle.Capacite, salle, (Projectionniste.SelectedItem as Personne));
            if (!LeFilm.LesSeances.Contains(s))
            {
                LeFilm.LesSeances.Add(s);
            }
            else MessageBox.Show("Seance déjà existante");
            Close();
        }

    }
}
