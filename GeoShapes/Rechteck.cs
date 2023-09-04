using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes
{
    public class Rechteck
    {
        public Linie LinieA { get; set; }
        public Linie LinieB { get; set; }
        public Linie LinieC { get; set; }
        public Linie LinieD { get; set; }
        public Rechteck(Linie LinieA, Linie LinieB, Linie LinieC, Linie LinieD)
        {
            if (IstGueltigesRechteck(LinieA.Laenge, LinieB.Laenge, LinieC.Laenge, LinieD.Laenge))
            {
                this.LinieA = LinieA;
                this.LinieB = LinieB;
                this.LinieC = LinieC;
                this.LinieD = LinieD;
            }
            else
            {
                Console.WriteLine("Die Angegebenen Werte ergeben kein Rechteck, versuchen Sie es neu.");
            }
        }
        private static bool IstGueltigesRechteck(double a, double b, double c, double d)
        {
            double[] laengen = {a, b, c, d};
            Array.Sort(laengen);
            bool langeSeitenGleich = laengen[0] == laengen[1];
            bool kurzeSeitenGleich = laengen[2] == laengen[3];
            bool nichtAlleGleich = laengen[0] != laengen[2];
            return langeSeitenGleich && kurzeSeitenGleich && nichtAlleGleich;
        }
        public double BerechneUmfang()
        {
            return LinieA.Laenge + LinieB.Laenge + LinieC.Laenge + LinieD.Laenge;
        }
        public double BerechneFlaeche()
        {
            if (LinieA.Laenge != LinieB.Laenge)
            {
                return LinieA.Laenge * LinieB.Laenge;
            }
            else if (LinieA.Laenge != LinieC.Laenge)
            {
                return LinieA.Laenge * LinieC.Laenge;
            }
            else
            {
                return LinieA.Laenge * LinieD.Laenge;
            }
        }
    }
}
