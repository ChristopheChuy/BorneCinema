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
    /// Logique d'interaction pour AjouterPersonne.xaml
    /// </summary>
    public partial class AjouterPersonne : Window
    {
        public LesPersonnes Personnes { get; set; } // Les Projectionistes
        public AjouterPersonne(LesPersonnes personnes)
        {
            InitializeComponent();
            Personnes = personnes;
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nom.Text))
                MessageBox.Show("Nom Invalide");
            if (string.IsNullOrWhiteSpace(Prenom.Text))
                MessageBox.Show("Prenom Invalide");
            if (string.IsNullOrWhiteSpace(Nom.Text) || string.IsNullOrWhiteSpace(Prenom.Text)) // si Donnée non valide
                return;
            Personne personneSaisi = new Personne(Nom.Text, Prenom.Text);
            if (!Personnes.Contains(personneSaisi))
                Personnes.Add(personneSaisi);
            else
                MessageBox.Show("Personne déjà presente");
            Close();

        }
    }
}
