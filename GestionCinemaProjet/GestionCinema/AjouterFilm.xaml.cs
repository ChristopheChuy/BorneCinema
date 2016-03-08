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
    /// Logique d'interaction pour AjouterFilm.xaml
    /// </summary>
    public partial class AjouterFilm : Window
    {
        public LesFilms LesFilms { get; set; }
        String filename ="";
        public AjouterFilm(LesFilms films)
        {
            InitializeComponent();
            LesFilms = films;
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(Nom.Text))
            {
                MessageBox.Show("Nom du film incorrect");
                
            }
            if (string.IsNullOrWhiteSpace(Rea.Text))
            {
                MessageBox.Show("Realisateur incorrect");
            }
            if (string.IsNullOrWhiteSpace(Duree.Text))
            {
                MessageBox.Show("Duree incorrect");
            }
            if (string.IsNullOrWhiteSpace(Synopsis.Text))
            {
                MessageBox.Show("Synopsis incorrect");
            }
            if (string.IsNullOrWhiteSpace(Age.Text))
            {
                Age.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Nom.Text) || string.IsNullOrWhiteSpace(Rea.Text) || string.IsNullOrWhiteSpace(Duree.Text) || string.IsNullOrWhiteSpace(Synopsis.Text)) // si Donnée non valide
            {
                filename = null;
                return;
            }
            try
            {

                Film f = new Film(Nom.Text, Rea.Text, Duree.Text, filename, Synopsis.Text, Convert.ToInt32(Age.Text), (bool)ThreeD.IsChecked);
                if (!LesFilms.Contains(f))
                    LesFilms.Add(f);
                else MessageBox.Show("Film déjà existant");
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

        private void Affiche(object sender, RoutedEventArgs e)
        {
           
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Images";
            dlg.DefaultExt = ".jpg | .png | .gif";
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                filename = dlg.FileName;
                
            }
        }


    }
}
