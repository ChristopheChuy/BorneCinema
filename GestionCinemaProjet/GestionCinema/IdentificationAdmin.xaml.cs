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
    /// Logique d'interaction pour IdentificationAdmin.xaml
    /// </summary>
    public partial class IdentificationAdmin : Window
    {
        public LesFilms Films { get; set; }
        public LesSalles Salles { get; set; }
        public LesPersonnes Personnes { get; set; }
        public IdentificationAdmin(LesFilms films, LesSalles salles,LesPersonnes personnes)
        {
            InitializeComponent();
            Personnes = personnes;
            Films = films;
            Salles = salles;
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            
            if (Login.Text.Equals("admin") && MDP.Password.Equals("admin"))
            {
                Admin administration = new Admin(Films,Salles,Personnes);
                administration.Show();
            }
            else MessageBox.Show("Login ou mot de passe invalide", "Erreur d'identification");
            this.Close();
        }
    }
}
