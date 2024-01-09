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

namespace ACT_3_BIS_Ex_EVENTS
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            boutonCalculer.Click += new RoutedEventHandler(boutonCalculer_Click);

        }

        private async void boutonCalculer_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonChalet.IsChecked == true || radioButtonTente.IsChecked == true)
            {
                bool typeLogement = (bool)radioButtonChalet.IsChecked; //true = chalet | false = tente
                if (nombrePersonne.Text == null || dateArrive.Text == null || dateSortie.Text == null)
                {
                    int NombrePersonne = int.Parse(nombrePersonne.Text);
                    DateTime DateArrive = DateTime.Parse(dateArrive.Text);
                    DateTime DateSortie = DateTime.Parse(dateSortie.Text);

                    TimeSpan TempEcouler = DateArrive - DateSortie;
                    MessageBox.Show(TempEcouler.ToString());
                }
                else
                {
                    MessageBox.Show("Veuillez complétez les caracteristique du sejours");
                }
                
                
            }
            else
            {
                MessageBox.Show("Veuillez choisir un des deux type de logements disponible");
            }
        }
    }
}
