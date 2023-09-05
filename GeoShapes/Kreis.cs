using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes
{
    public class Kreis
    {
        private Linie linie;
        public Kreis(Linie Linie) 
        {
            this.linie = Linie;
        }

        /// <summary>
        /// Berechnet den Umfang eines Kreises
        /// </summary>
        /// <returns>Umfang</returns>
        public double BerechneUmfang()
        {
            return linie.Laenge;
        }

        /// <summary>
        /// Berechnet die Flache eines Kreises
        /// </summary>
        /// <returns>Flaeche</returns>
        public double BerechneFlaeche()
        {
            return Math.Pow(linie.Laenge, 2) * Math.PI;
        }
    }
}
