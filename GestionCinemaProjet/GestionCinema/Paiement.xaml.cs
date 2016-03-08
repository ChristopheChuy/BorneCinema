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
namespace GestionCinema
{
    /// <summary>
    /// Logique d'interaction pour Paiement.xaml
    /// </summary>
    public partial class Paiement : Window
    {
        ListBox listeDeFilm;
        Seance seance;
        int nbPlace;
        public Paiement(String nomFilm,String nbPlace,Seance seance,ListBox ListeDeFilm)
        {
            InitializeComponent();
            this.seance = seance;
            NomFilm.Text = nomFilm;
            NbPace.Text = nbPlace + " X";
            Prix.Text = seance.Prix+" €";
            PrixTotal.Text = (seance.Prix.Centime * ((Convert.ToInt32(nbPlace)))/100.0).ToString() + " €";
            this.nbPlace = Convert.ToInt32(nbPlace);
            this.listeDeFilm = ListeDeFilm;
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Payer(object sender, RoutedEventArgs e)
        {
            seance.PlaceLibre -= nbPlace;
            listeDeFilm.SelectedIndex = -1;
            Impression impression = new Impression();
            impression.Show();
            this.Close();
        }
    }
}
