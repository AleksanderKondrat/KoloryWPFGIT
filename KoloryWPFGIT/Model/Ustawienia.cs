using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

//namespace KoloryWPFGIT
namespace KoloryWPFGIT.Model
{
    class Ustawienia
    {
        /*
        public static Color Czytaj() {
            Properties.Settings ustawienia = Properties.Settings.Default;
            Color kolor = new Color()
            {
                A = 255,
                R = ustawienia.R,
                G = ustawienia.G,
                B = ustawienia.B
            };
            return kolor;
        }
        */
        public static Kolor Czytaj()
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            return new Kolor(ustawienia.A, ustawienia.R, ustawienia.G, ustawienia.B);
        }

        public static void Zapisz(Kolor kolor)
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            ustawienia.A = kolor.A;
            ustawienia.R = kolor.R;
            ustawienia.G = kolor.G;
            ustawienia.B = kolor.B;
            ustawienia.Save();
        }

        private Kolor Zapisane
        {
            get
            {
                return Czytaj();
            }
            set
            {
                Zapisz(value);
            }
        }


    }
}
