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

namespace ACT_4_CreationDynamique_GregoireA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            grdMain.RowDefinitions.Add(rowDef1);
            grdMain.RowDefinitions.Add(rowDef2);
            grdMain.RowDefinitions.Add(rowDef3);*/
            ColumnDefinition[] coldef = new ColumnDefinition[3];
            RowDefinition[] rowDef = new RowDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                coldef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef[i]);
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
            //créer le textblock du haut
            TextBlock txtBlockHaut = new TextBlock();
            Thickness marginBlockHaut = new Thickness();
            marginBlockHaut.Top = 50 ;
            txtBlockHaut.Margin = marginBlockHaut;
            txtBlockHaut.Text = "TextBlock créé dynamiquement";
            txtBlockHaut.Background = Brushes.Yellow;
            txtBlockHaut.FontSize = 18;
            txtBlockHaut.Foreground = Brushes.Red;
            txtBlockHaut.FontWeight = FontWeights.UltraBold;
            txtBlockHaut.FontFamily = new FontFamily("NomDePolice");
            //ajout du textblock a la grille au emplacement voulus
            Grid.SetRow(txtBlockHaut, 0);
            Grid.SetColumnSpan(txtBlockHaut, 3);
            grdMain.Children.Add(txtBlockHaut);
            //creation des buttons du millieu

            Button[] button = new Button[3];
            for (int i = 0; i < 3; i++)
            {
                button[i] = new Button();
                button[i].Height = 100;
                button[i].Width = 100;
                button[i].Content = "BOUTON " + (i+1);
                //placement des boutons dans la grille
                Grid.SetColumn(button[i], i);
                Grid.SetRow(button[i], 1);
                grdMain.Children.Add(button[i]);
            }
            //Text block du bas
            TextBlock txtBlockBas = new TextBlock();
            Thickness marginBlockbas = new Thickness();
            marginBlockbas.Bottom = 80;
            txtBlockBas.Margin = marginBlockbas;
            txtBlockBas.Text = "Infos : ";
            txtBlockBas.FontSize = 14;
            txtBlockBas.Foreground = Brushes.Black;
            txtBlockBas.Background = Brushes.Yellow;
            txtBlockBas.FontFamily = new FontFamily("NomDePolice");
            Grid.SetRow(txtBlockBas, 2);
            Grid.SetColumnSpan(txtBlockBas, 2);
            grdMain.Children.Add(txtBlockBas);
            //creation textBox
            TextBox txtBoxBas = new TextBox();
            txtBoxBas.Height = 20;
            txtBoxBas.Text = "J'attend vos infos";
            Grid.SetRow(txtBoxBas, 2);
            Grid.SetColumnSpan(txtBoxBas, 2);
            grdMain.Children.Add(txtBoxBas);
            //creation combo box
            ComboBox comboBoxBas = new ComboBox();
            comboBoxBas.Items.Add("alphonse");
            comboBoxBas.Items.Add("alfred");
            comboBoxBas.VerticalAlignment = VerticalAlignment.Center;
            comboBoxBas.HorizontalAlignment = HorizontalAlignment.Center;
            comboBoxBas.Height = 80;
            comboBoxBas.Width = 150;
            Grid.SetRow(comboBoxBas, 3);
            Grid.SetColumn(comboBoxBas, 3);
            grdMain.Children.Add(comboBoxBas);
        }
    }
}
