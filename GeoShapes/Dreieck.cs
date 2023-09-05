using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes
{
    public class Dreieck
    {
        private Linie linieA;
        private Linie linieB;
        private Linie linieC;
        public Dreieck(Linie linieA, Linie linieB, Linie linieC)
        {
            if (IstGueltigesDreieck(linieA.Laenge, linieB.Laenge, linieC.Laenge))
            {
                this.linieA = linieA;
                this.linieB = linieB;
                this.linieC = linieC;
            }
            else
            {
                Console.WriteLine("Die Angegebenen Werte ergeben kein Dreieck, versuchen Sie es neu.");
            }
        }

        private static bool IstGueltigesDreieck(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// Berechnet den Umfang eines Dreieck
        /// </summary>
        /// <returns>Umfang</returns>
        public double BerechneUmfang()
        {
            return linieA.Laenge + linieB.Laenge + linieC.Laenge;
        }

        /// <summary>
        /// Berechnet die Flaeche eines Dreieck
        /// </summary>
        /// <returns>Flaeche</returns>
        public double BerechneFlaeche()
        {
            double s = BerechneUmfang() / 2;
            double zwischenWert = s * (s - linieA.Laenge) * (s - linieB.Laenge) * (s - linieC.Laenge);
            return Math.Sqrt(zwischenWert);            
        }
    }
}
