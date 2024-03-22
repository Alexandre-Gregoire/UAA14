using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ACT_7_COURSE_DE_LEVRIERS_GregoireA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Chien[] chiens = new Chien[4];
        Parieur Joe = new Parieur("Joe",null,70);
        Parieur Bob = new Parieur("Bob", null, 50);
        Parieur Bill = new Parieur("Bill", null, 30);
        public MainWindow()
        {
            InitializeComponent();
            JoeBal.Content = "Joe possède " + Joe.Cash.ToString() + " écus";
            BobBal.Content = "Bob possède " + Bob.Cash.ToString() + " écus";
            BillBal.Content = "Bill possède " + Bill.Cash.ToString() + " écus";
            for (int i = 0; i < 4; i++)
            {
                BitmapImage imageChien = new BitmapImage();
                imageChien.BeginInit();
                imageChien.UriSource = new Uri("assets/dog.png", UriKind.Relative);
                imageChien.EndInit();

                Image monImageChien = new Image();
                monImageChien.Source = imageChien;
                monImageChien.Stretch = System.Windows.Media.Stretch.None;

                chiens[i] = new Chien(0, monImageChien, false, i);
                Canvas.SetLeft(chiens[i].ImageChien, 1);
                Canvas.SetTop(chiens[i].ImageChien, i * 70);

                piste.Children.Add(chiens[i].ImageChien);
            }
            btnLancer.Click += new RoutedEventHandler(btnLancer_click);
            btnParie.Click += new RoutedEventHandler(btnLancer_click);
            JoeBal.Checked += new RoutedEventHandler(JoeBalChecked);
            BobBal.Checked += new RoutedEventHandler(BobBalChecked);
            BillBal.Checked += new RoutedEventHandler(BillBalChecked);
            btnLancer.Click += new RoutedEventHandler(btnLancer_click);
            btnLancer.Click += new RoutedEventHandler(btnLancer_click);
            //

        }
        private async void btnLancer_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("uwu");
        }
        private async void btnParie_click(object sender, RoutedEventArgs e)
        {
            
        }

        private async void JoeBalChecked(object sender, RoutedEventArgs e)
        {
            NomParieur.Text = "Joe";
        }
        private async void BobBalChecked(object sender, RoutedEventArgs e)
        {
            NomParieur.Text = "Bob";
        }
        private async void BillBalChecked(object sender, RoutedEventArgs e)
        {
            NomParieur.Text = "Bill";
        }
    }
}