using KoloryWPFGIT.Model;
using KoloryWPFGIT.ModelWidoku;
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

namespace KoloryWPFGIT
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //Kolor kolor = Ustawienia.Czytaj();//.ToColor();
            //rectangle.Fill = new SolidColorBrush(kolor.ToColor());
            //sliderR.Value = kolor.R;
            //sliderG.Value = kolor.G;
            //sliderB.Value = kolor.B;
            //sliderA.Value = kolor.A;

            /*
            InitializeComponent();
            Kolor kolor = Ustawienia.Czytaj();
            rectangle.Fill =
            /* I
            Color kolor = Ustawienia.Czytaj().ToColor();
            rectangle.Fill = new SolidColorBrush(kolor);
            sliderR.Value = kolor.R;
            sliderG.Value = kolor.G;
            sliderB.Value = kolor.B;
            */
            //sliderR_ValueChanged(null,null);


        }
        /*
        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Kolor kolor = new Kolor((byte)sliderA.Value, (byte)sliderR.Value, (byte)sliderG.Value, (byte)sliderB.Value);
            KolorProstokata = kolor.ToColor();

            /* I
            Color kolor = Color.FromRgb(
                (byte) sliderR.Value,
                (byte) sliderG.Value,
                (byte) sliderB.Value
                
                );
            KolorProstokata = kolor;
            
            // III  (rectangle.Fill as SolidColorBrush).Color = kolor;
            // II   (rectangle.Fill as SolidColorBrush).Color= new SolidColorBrush(kolor);
            // I    Brushes.GreenYellow;
        }
        */
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Close();
        }
        /*
        private Color KolorProstokata {
            get {
                return (rectangle.Fill as SolidColorBrush).Color;
            }
            set {
                (rectangle.Fill as SolidColorBrush).Color = value;
            }
        }
        */
        private void Window_Closed(object sender, EventArgs e)
        {
            EdycjaKoloru edycjaKoloru = this.Resources["edycjaKoloru"] as EdycjaKoloru;
           // EdycjaKoloru edycjaKoloru = this.DataContext as EdycjaKoloru;              //WIAZANIE Z 
            edycjaKoloru.Zapisz();
            //Ustawienia.Zapisz(new Kolor( KolorProstokata.R, KolorProstokata.G, KolorProstokata.B));
        }
    }
}
