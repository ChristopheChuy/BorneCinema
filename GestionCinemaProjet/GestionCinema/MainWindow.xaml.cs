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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestionCinemaLib;
using System.Collections.ObjectModel;
namespace GestionCinema
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LesPersonnes lesPersonnes;
        public LesSalles lesSalles;
        public LesFilms lesFilms;
        public int nbBillet { get; set; }
        public ListBox seances;
        public MainWindow()
        {
            InitializeComponent();
            ListeDeFilm.SelectedIndex = -1;
            nbBillet = 0;
            this.DataContext = this;
            Paiement.IsEnabled = false;
            lesSalles = new LesSalles();
            lesPersonnes = new LesPersonnes();
            lesFilms = FindResource("ListeFilm") as LesFilms;
            seances = new ListBox();
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            Manager.SauverFilms(lesFilms);
            Manager.SauverPersonnes(lesPersonnes);
            Manager.SauverSalles(lesSalles);
            this.Close();
        }

        private void NbBilletSup(object sender, RoutedEventArgs e)
        {
            if ((seances.SelectedItem as Seance) != null && (((seances.SelectedItem as Seance).PlaceLibre) - nbBillet) != 0)
            {
                nbBillet++;
                TextBlockNbBillet.Text = nbBillet.ToString();
                if (nbBillet != 0)
                {
                    Paiement.IsEnabled = true;
                }
            }
        }

        private void NbBilletInf(object sender, RoutedEventArgs e)
        {
            if (nbBillet != 0)
                nbBillet--;
            TextBlockNbBillet.Text = nbBillet.ToString();
            if (nbBillet == 0)
            {
                Paiement.IsEnabled = false;
            }
        }


        private void Admin(object sender, RoutedEventArgs e)
        {
            IdentificationAdmin fenetreIdentification =new IdentificationAdmin(lesFilms,lesSalles,lesPersonnes);
            fenetreIdentification.Show();
        }

        private void Paiements(object sender, RoutedEventArgs e)
        {
            Seance seance=seances.SelectedItem as Seance;
            if(seance!=null){
            Paiement paiement = new Paiement((ListeDeFilm.SelectedItem as Film).Nom, TextBlockNbBillet.Text,seance,ListeDeFilm);
            paiement.Show();
            }
            nbBillet = 0;
            TextBlockNbBillet.Text = nbBillet.ToString();
            Paiement.IsEnabled = false;
        }

        private void InitialiserListbox(object sender, RoutedEventArgs e)
        {
            seances = sender as ListBox;
        }
    }
}
