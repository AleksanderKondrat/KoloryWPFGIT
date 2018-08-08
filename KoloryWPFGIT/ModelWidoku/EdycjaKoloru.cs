using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloryWPFGIT.ModelWidoku
{
    using Model;
    using System.ComponentModel;
    using System.Windows.Input;
    using System.Windows.Media;

    public class EdycjaKoloru : ObservedObject
    {
        //pole kolor odzczytane 
        private readonly Kolor kolor = Ustawienia.Czytaj();
        //zapewnienie dostępu
        public byte A {
            get { return kolor.A; }
            set {
                kolor.A = value;
                OnPropertyChanged("A", "Color");
            } }
        public byte R {
            get { return kolor.R; }
            set {
                kolor.R = value;
                OnPropertyChanged("R", "Color");
            } }
        public byte G {
            get { return kolor.G; }
            set {
                kolor.G = value;
                OnPropertyChanged("G", "Color");
            } }
        public byte B {
            get { return kolor.B; }
            set {
                kolor.B = value;
                OnPropertyChanged("B", "Color");
            } }

        //udostepnienie typu Color 
        //public Color Color { get { return kolor.ToColor(); } }

        //Zapis
        public void Zapisz() {
            Ustawienia.Zapisz(kolor);
        }

        public ICommand resetujCommand;

        public ICommand Resetuj {
            get
            {
                if (resetujCommand == null) resetujCommand = new ResetujCommand(this);
                return resetujCommand;
            }
        }
    }
    static class Rozszerzenia
    {
        public static Color ToColor(this Kolor kolor)
        {
            return new Color()
            {
                A = kolor.A,
                R = kolor.R,
                G = kolor.G,
                B = kolor.B
            };
        }
    }
}
