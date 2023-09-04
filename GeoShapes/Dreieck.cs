using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes
{
    public class Dreieck
    {
        public Linie LinieA { get; set; }
        public Linie LinieB { get; set; }
        public Linie LinieC { get; set; }
        public Dreieck(Linie LinieA, Linie LinieB, Linie LinieC)
        {
            if (IstGueltigesDreieck(LinieA.Laenge, LinieB.Laenge, LinieC.Laenge))
            {
                this.LinieA = LinieA;
                this.LinieB = LinieB;
                this.LinieC = LinieC;
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
        public double BerechneUmfang()
        {
            return LinieA.Laenge + LinieB.Laenge + LinieC.Laenge;
        }
        public double BerechneFlaeche()
        {
            double s = BerechneUmfang() / 2;
            double zwischenWert = s * (s - LinieA.Laenge) * (s - LinieB.Laenge) * (s - LinieC.Laenge);
            return Math.Sqrt(zwischenWert);            
        }
    }
}
