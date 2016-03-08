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
using System.Windows.Threading;
namespace GestionCinema
{
    /// <summary>
    /// Logique d'interaction pour Impression.xaml
    /// </summary>
    public partial class Impression : Window
    {
        DispatcherTimer chronomètre = new DispatcherTimer();
        public Impression()
        {
            InitializeComponent();
        }
        void duree(object sender, EventArgs e)
        {
            mProgressBar.Value++;
            if (mProgressBar.Value == mProgressBar.Maximum)
            {
                chronomètre.Stop();
                this.Close();
            }
        }

        private void Lancer(object sender, EventArgs e)
        {
            chronomètre.Tick += duree;
            chronomètre.Interval = TimeSpan.FromMilliseconds(30);
            chronomètre.Start();
        }
    }
}
