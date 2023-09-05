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
        private Linie linieA;
        private Linie linieB;
        private Linie linieC;
        private Linie linieD;
        public Rechteck(Linie linieA, Linie linieB, Linie linieC, Linie linieD)
        {
            if (IstGueltigesRechteck(linieA.Laenge, linieB.Laenge, linieC.Laenge, linieD.Laenge))
            {
                this.linieA = linieA;
                this.linieB = linieB;
                this.linieC = linieC;
                this.linieD = linieD;
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
            return (laengen[0] == laengen[1]) && (laengen[2] == laengen[3]) && (laengen[0] != laengen[2]);
        }

        /// <summary>
        /// Berechnet den Umfang eines Rechteck
        /// </summary>
        /// <returns>Umfang</returns>
        public double BerechneUmfang()
        {
            return linieA.Laenge + linieB.Laenge + linieC.Laenge + linieD.Laenge;
        }

        /// <summary>
        /// Berechnet die Flaeche eines Rechtecks
        /// </summary>
        /// <returns>Flaeche</returns>
        public double BerechneFlaeche()
        {
            if (linieA.Laenge != linieB.Laenge)
            {
                return linieA.Laenge * linieB.Laenge;
            }
            else if (linieA.Laenge != linieC.Laenge)
            {
                return linieA.Laenge * linieC.Laenge;
            }
            else
            {
                return linieA.Laenge * linieD.Laenge;
            }
        }
    }
}
