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

namespace UAA14_I3_GREGOIRE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            boutonCalculer.Click += new RoutedEventHandler(boutonCalculer_click);
            boutonReset.Click += new RoutedEventHandler(BoutonReset_Click);
        }

        private void BoutonReset_Click(object sender, RoutedEventArgs e)
        {
            nombre1.Text = string.Empty;
            nombre2.Text = string.Empty;
            boutonAddition.IsChecked = true;
        }

        private void boutonCalculer_click(object sender, RoutedEventArgs e)
        {
            {
                bool test01 = true;
                ushort[] binaire1;
                ushort[] binaire2;
                ushort[] binaireFinit = new ushort[7];
                foreach (char item in nombre1.Text)
                {
                    if (item.ToString() != "1" && item.ToString() != "0")
                    {
                        test01 = false;
                    }
                }
                foreach (char item in nombre2.Text)
                {
                    if (item.ToString() != "1" && item.ToString() != "0")
                    {
                        test01 = false;
                    }
                }
                if (nombre1.Text.Length <= 7 && nombre2.Text.Length <= 7 && test01)
                {
                    MethodesDuProjet mesOutils = new MethodesDuProjet();
                    binaire1 = mesOutils.RemplirTableau(nombre1.Text);
                    binaire2 = mesOutils.RemplirTableau(nombre2.Text);
                    if (boutonAddition.IsChecked == true)
                    {
                        mesOutils.Additionne(binaire1, binaire2, out binaireFinit, out test01);
                        if (test01)
                        {
                            affichageReponse.Content = mesOutils.Concatene(binaireFinit);
                        }
                        else
                        {
                            MessageBox.Show("Addition imposible");
                        }
                    }
                    else
                    {
                        mesOutils.Soustrait(binaire1, binaire2, out binaireFinit);
                        affichageReponse.Content = mesOutils.Concatene(binaireFinit);
                    }
                }
                else
                {
                    MessageBox.Show("veuillez entrez des données valides");
                }

            }

        }
    }
}
