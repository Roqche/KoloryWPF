using System.Windows.Media;

namespace KoloryWPF.ModelView
{
    using Model;

    public class EdycjaKoloru
    {
        private readonly Kolor kolor = Ustawienia.Czytaj();

        public byte R
        {
            get => kolor.R;
            set => kolor.R = value;
        }

        public byte G
        {
            get => kolor.G;
            set => kolor.G = value;
        }

        public byte B
        {
            get => kolor.B;
            set => kolor.B = value;
        }

        public Color Color => kolor.ToColor();

        public void Zapisz()
        {
            Ustawienia.Zapisz(kolor);
        }
    }

    public static class Rozszerzenia
    {
        public static Color ToColor(this Kolor kolor)
        {
            return new Color()
            {
                A = 255,
                R = kolor.R,
                G = kolor.G,
                B = kolor.B
            };
        }
    }
}