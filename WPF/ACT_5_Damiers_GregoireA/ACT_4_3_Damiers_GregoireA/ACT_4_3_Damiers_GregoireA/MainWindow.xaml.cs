﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace ACT_4_3_Damiers_GregoireA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int tailleGrille = 8;
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
                    buttons[i, y].FontWeight = FontWeights.Bold;
                    buttons[i, y].FontSize = 37;
                    
                   
                    

                    if (i == 0 || i == 1 || i == 6 || i == 7)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        switch (compteur)
                        {
                            case 1:
                            case 8:
                            case 57:
                            case 64:

                                imageBouton.UriSource = new Uri("assets/t.png", UriKind.Relative);

                                break;

                            case 2:
                            case 7:
                            case 58:
                            case 63:
                                imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);

                                break;

                            case 3:
                            case 6:
                            case 59:
                            case 62:
                                imageBouton.UriSource = new Uri("assets/b.png", UriKind.Relative);

                                break;

                            case 4:
                            case 60:
                                imageBouton.UriSource = new Uri("assets/k.png", UriKind.Relative);

                                break;

                            case 5:
                            case 61:
                                imageBouton.UriSource = new Uri("assets/q.png", UriKind.Relative);

                                break;
                            default:
                                imageBouton.UriSource = new Uri("assets/q.png", UriKind.Relative);
                                break;
                        }
                        if ((compteur >= 9 && compteur <= 16) || (compteur >= 49 && compteur <= 56))
                        {
                            imageBouton.UriSource = new Uri("assets/p.png", UriKind.Relative);
                            ;
                        }
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        buttons[i, y].Content = imBouton;
                    }
                    Grid.SetRow(buttons[i, y], i);
                    Grid.SetColumn(buttons[i, y], y);
                    grdMain.Children.Add(buttons[i, y]);
                    compteur++;
                }
            }
        }
    }
}
