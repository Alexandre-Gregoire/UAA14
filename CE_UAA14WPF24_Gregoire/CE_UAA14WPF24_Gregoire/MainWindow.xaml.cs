using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;

namespace CE_UAA14WPF24_Gregoire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] buttonsCercle = new Button[15,15];
        Button[,] buttonsRectangle = new Button[15, 15];
        public MainWindow()
        {
            InitializeComponent();
            label2.Visibility = Visibility.Hidden;
            btnValider.Click += new RoutedEventHandler(BtnValider_click);
        }
        private async void BtnValider_click(object sender,RoutedEventArgs e)
        {
            ColumnDefinition[] coldef = new ColumnDefinition[15];
            RowDefinition[] rowdef = new RowDefinition[15];
            if (btnBande.IsChecked == true && boxCol.Text != "" && boxLi.Text != "")
            {
                if (int.Parse(boxLi.Text) < 2 || int.Parse(boxLi.Text) > 12 || int.Parse(boxCol.Text) > 12 || int.Parse(boxCol.Text) < 2)
                {
                    affichageErreur.Text = "Entrez des valeurs valides (doivent etres comprise entre 2 et 12)";
                }
                else
                {


                    for (int i = 0; i < int.Parse(boxCol.Text); i++)
                    {
                        coldef[i] = new ColumnDefinition();
                        grdSecond.ColumnDefinitions.Add(coldef[i]);

                    }
                    for (int i = 0; i < int.Parse(boxLi.Text); i++)
                    {
                        rowdef[i] = new RowDefinition();
                        grdSecond.RowDefinitions.Add(rowdef[i]);
                    }
                    for (int i = 0; i < int.Parse(boxCol.Text); i++)
                    {
                        for (int y = 0; y < int.Parse(boxLi.Text); y++)
                        {
                            if (y == 0 || i == 0 || y == int.Parse(boxLi.Text) - 1 || i == int.Parse(boxCol.Text) - 1)
                            {
                                buttonsRectangle[i, y] = new Button();
                                buttonsRectangle[i, y].Content = "X";
                                buttonsRectangle[i, y].Background = Brushes.Khaki;
                                buttonsRectangle[i, y].Foreground = Brushes.Red;
                                buttonsRectangle[i, y].FontWeight = FontWeights.Bold;
                                buttonsRectangle[i, y].FontSize = 22;
                                Grid.SetRow(buttonsRectangle[i, y], y);
                                Grid.SetColumn(buttonsRectangle[i, y], i);
                                grdSecond.Children.Add(buttonsRectangle[i, y]);
                            }
                        }
                    }
                }
            }
            else if (btnSolitaire.IsChecked == true)
            {
                for (int i = 0; i < 9; i++)
                {
                    coldef[i] = new ColumnDefinition();
                    grdSecond.ColumnDefinitions.Add(coldef[i]);
                    rowdef[i] = new RowDefinition();
                    grdSecond.RowDefinitions.Add(rowdef[i]);
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (!((i < 3 && y < 3) || (i < 3 && y > 5) || (i > 5 && y > 5) || (i > 5 && y < 3)))
                        {
                            buttonsCercle[i, y] = new Button();
                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                            imageBouton.EndInit();
                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                            buttonsCercle[i, y].Content = imBouton;
                            buttonsCercle[i, y].Background = Brushes.Khaki;
                            Grid.SetRow(buttonsCercle[i, y], i);
                            Grid.SetColumn(buttonsCercle[i, y], y);
                            grdSecond.Children.Add(buttonsCercle[i, y]);

                            
                        }                       

                    }
                }
            }
            else if (btnMarelle.IsChecked == true)
            {
                for (int i = 0; i < 7; i++)
                {
                    coldef[i] = new ColumnDefinition();
                    grdSecond.ColumnDefinitions.Add(coldef[i]);
                    rowdef[i] = new RowDefinition();
                    grdSecond.RowDefinitions.Add(rowdef[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    for (int y = 0; y < 7; y++)
                    {
                        if ((i == y) || (i == 6-y) || (i == 3) || (y == 3) )
                        {
                            if (i != 3 || y != 3)
                            {
                                buttonsCercle[i, y] = new Button();
                                BitmapImage imageBouton = new BitmapImage();
                                imageBouton.BeginInit();
                                imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                                imageBouton.EndInit();
                                Image imBouton = new Image();
                                imBouton.Source = imageBouton;
                                imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                                buttonsCercle[i, y].Content = imBouton;
                                buttonsCercle[i, y].Background = Brushes.Khaki;
                                
                                Grid.SetRow(buttonsCercle[i, y], i);
                                Grid.SetColumn(buttonsCercle[i, y], y);
                                grdSecond.Children.Add(buttonsCercle[i, y]);

                                
                            }
                            
                        }

                    }
                }
            }
            else if (btnBande.IsChecked == true)
            {
                label2.Visibility = Visibility.Visible;
                boxCol.PreviewTextInput += new TextCompositionEventHandler(verifInputCol);
                boxLi.PreviewTextInput += new TextCompositionEventHandler(verifInputLi);
            }

            else
            {
                affichageErreur.Text = "Veuillez cochez une des possibilité";
            }
            
        }
 
        private async void verifInputCol(object sender, TextCompositionEventArgs e)
        {
            int a;
            if (!int.TryParse(boxCol.Text,out a)) {
                boxCol.Text = "";
                affichageErreur.Text = "Entrez des valeurs valides";
            }

        }
        private async void verifInputLi(object sender, TextCompositionEventArgs e)
        {
            int a;
            if (!int.TryParse(boxLi.Text, out a))
            {
                boxLi.Text = "";
                affichageErreur.Text = "Entrez des valeurs valides";
            }

        }
    }
}
