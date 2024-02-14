using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ACT_7_COURSE_DE_LEVRIERS_GregoireA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            Chien[] chiens = new Chien[4];
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




        }
        private async void btnLancer_click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}