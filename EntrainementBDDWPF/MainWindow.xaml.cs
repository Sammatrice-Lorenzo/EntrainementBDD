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
using MetierBDD;
namespace EntrainementBDDWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        GestionnaireBdd gstBdd;

        private void btnRayonSecteur_Click(object sender, RoutedEventArgs e)
        {
            RayonSecteur frm = new RayonSecteur(gstBdd);
            frm.Show();
        }

        private void btnNewEmploye_Click(object sender, RoutedEventArgs e)
        {
            NewEmploye frm = new NewEmploye(gstBdd);
            frm.Show();
        }

        private void btnGestionHoraires_Click(object sender, RoutedEventArgs e)
        {
            GestionHoraires frm = new GestionHoraires(gstBdd);
            frm.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gstBdd = new GestionnaireBdd();
        }
    }
}
