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
    /// Logique d'interaction pour NewEmploye.xaml
    /// </summary>
    public partial class NewEmploye : Window
    {
        GestionnaireBdd gstBdd;
        public NewEmploye(GestionnaireBdd unGst)
        {
            InitializeComponent();
            gstBdd = unGst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstEmployes.ItemsSource = gstBdd.GetAllEmploye();
            txtNum.Text = gstBdd.LastNumEmploye().ToString();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if(txtNom.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom de l 'employe", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                gstBdd.InsertEmploye(Convert.ToInt16(txtNum.Text), txtNom.Text);
                lstEmployes.ItemsSource = null;
                lstEmployes.ItemsSource = gstBdd.GetAllEmploye();
                txtNum.Text = gstBdd.LastNumEmploye().ToString();
                txtNom.Text = "";
            }
        }

    }
}
