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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ACT_3_EX_WPF_OBJET_EVENTS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MethodesDuProjet MesOutils = new MethodesDuProjet();
        


        public MainWindow()
        {
            InitializeComponent();
            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBouton);

        }
        private async void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(textBoxA.Text,out double a) && double.TryParse(textBoxB.Text, out double b) && double.TryParse(textBoxC.Text, out double c))
            {   

                string message = MesOutils.CalculTrinome(a,b,c);
                AffichageReponse affichageReponseOutil = new AffichageReponse();

                affichageReponseOutil.affichageReponse.Text = message;
                affichageReponseOutil.Show();

            }
            else
            {
                MessageBox.Show("Veuillez entrez des chiffres valide");
            }
        }

        private void SurvolBouton(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Visible;
        }
    }
}
