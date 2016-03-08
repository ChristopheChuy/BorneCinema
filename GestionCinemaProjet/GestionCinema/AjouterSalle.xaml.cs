using GestionCinemaLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
namespace GestionCinema
{
    /// <summary>
    /// Logique d'interaction pour AjouterSalle.xaml
    /// </summary>
    public partial class AjouterSalle : Window
    {
        public LesSalles Salles { get; set; }

        public AjouterSalle(LesSalles salles)
        {
            InitializeComponent();
            Salles = salles;
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            try
            {
            if (string.IsNullOrWhiteSpace(Numero.Text))
                MessageBox.Show("Numero de salle inapproprié");
            if (string.IsNullOrWhiteSpace(Capacite.Text) || Convert.ToInt32(Capacite.Text) <= 0)
                MessageBox.Show("Capacité inapproprié");
            if (string.IsNullOrWhiteSpace(Capacite.Text) || Convert.ToInt32(Capacite.Text) <= 0 || string.IsNullOrWhiteSpace(Numero.Text))// si Donnée non valide
                return;
            
                Salle salleSaisi = new Salle(Convert.ToInt32(Numero.Text), Convert.ToInt32(Capacite.Text));

                if (!Salles.Contains(salleSaisi))
                    Salles.Add(salleSaisi);
                else MessageBox.Show("Salle déjà existante");
                Close();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }


    }
}
