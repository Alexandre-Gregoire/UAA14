using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ACT_4_2_MatchingGame_GregoireA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock derniereTBClique;
        public MainWindow()
        {
            InitializeComponent();
            ColumnDefinition[] coldef = new ColumnDefinition[4];
            RowDefinition[] rowDef = new RowDefinition[4];
            TextBlock[,] textBlocks = new TextBlock[4,4];
            for (int i = 0; i < 4; i++)
            {
                coldef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef[i]);
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
            for (int i = 0;i < 4;i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    textBlocks[i,j] = new TextBlock();
                    textBlocks[i,j].HorizontalAlignment = HorizontalAlignment.Center;
                    textBlocks[i,j].VerticalAlignment = VerticalAlignment.Center;
                    textBlocks[i,j].FontSize = 39;
                    textBlocks[i, j].MouseDown += TextBlock_MouseDown;
                    textBlocks[i,j].Text = "?";
                    Grid.SetRow(textBlocks[i, j], i);
                    Grid.SetColumn(textBlocks[i,j], j);
                    grdMain.Children.Add(textBlocks[i,j]);
                }
            }
            

        }
        

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            textBlockActif.Text = "X";
            derniereTBClique = textBlockActif;
        }

       
    }
}