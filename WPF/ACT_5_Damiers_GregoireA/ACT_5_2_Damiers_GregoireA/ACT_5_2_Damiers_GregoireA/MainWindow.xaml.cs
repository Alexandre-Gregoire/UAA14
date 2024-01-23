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

namespace ACT_5_2_Damiers_GregoireA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int tailleGrille = 10;
            int compteur = 1;
            InitializeComponent();
            Button[,] buttons = new Button[tailleGrille, tailleGrille];
            ColumnDefinition[] coldef = new ColumnDefinition[tailleGrille];
            RowDefinition[] rowDef = new RowDefinition[tailleGrille];

            for (int i = 0; i < tailleGrille; i++)
            {
                coldef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef[i]);
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
            for (int i = 0; i < tailleGrille; i++)
            {
                for (int y = 0; y < tailleGrille; y++)
                {
                    buttons[i, y] = new Button();
                    if ((y + i) % 2 == 0)
                    {
                        buttons[i, y].Background = Brushes.White;
                    }
                    else
                    {
                        buttons[i, y].Background = Brushes.Black;
                    }
                    buttons[i, y].Foreground = Brushes.Red;
                    buttons[i, y].Height = 65;
                    buttons[i, y].Width = 65;
                    if (i%2 == 0)
                    {
                        buttons[i, y].Content = compteur;
                    }
                    else
                    {
                        buttons[i, y].Content = (i*10+10)-y;
                    }
                    
                    buttons[i, y].FontWeight = FontWeights.Bold;
                    buttons[i, y].FontSize = 37;
                    compteur++;
                    Grid.SetRow(buttons[i, y], i);
                    Grid.SetColumn(buttons[i, y], y);
                    grdMain.Children.Add(buttons[i, y]);

                }
            }
        }
    }
}
