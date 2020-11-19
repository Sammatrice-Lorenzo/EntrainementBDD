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
    /// Logique d'interaction pour RayonSecteur.xaml
    /// </summary>
    public partial class RayonSecteur : Window
    {
        GestionnaireBdd gstBdd;
        public RayonSecteur(GestionnaireBdd unGst)
        {
            InitializeComponent();
            gstBdd = unGst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboSecteur.ItemsSource = gstBdd.GetAllSecteurs();
        }

        private void cboSecteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboSecteur.SelectedItem != null)
            {
                lstRayons.ItemsSource = gstBdd.GetRayonBySecteur((cboSecteur.SelectedItem as Secteur).NumSecteur);
            }
        }
    }
}
