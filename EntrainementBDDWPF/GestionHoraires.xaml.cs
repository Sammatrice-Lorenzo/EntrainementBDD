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
using MetierBDD;

namespace EntrainementBDDWPF
{
    /// <summary>
    /// Logique d'interaction pour GestionHoraires.xaml
    /// </summary>
    public partial class GestionHoraires : Window
    {
        GestionnaireBdd gstBdd;
        public GestionHoraires(GestionnaireBdd unGst)
        {
            InitializeComponent();
            gstBdd = unGst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboEmployes.ItemsSource = gstBdd.GetAllEmploye();
        }

        private void sldTempsPasse_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtSlider.Text = Convert.ToInt16(sldTempsPasse.Value).ToString();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {

            if (cboEmployes.SelectedItem == null)
            {
                MessageBox.Show("Veuliez sélectionner un employe", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (cboRayons.SelectedItem == null)
                {
                    MessageBox.Show("Veuliez sélectionner un rayon", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {

                }
            }
        }

        private void cboEmployes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboEmployes.SelectedItem != null)
            {
                lstGestion.ItemsSource = gstBdd.GetDateTempByEmploye((cboEmployes.SelectedItem as Employe).NumEmploye);
            }
        }
    }
}
