using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes
{
    public class Kreis
    {
        public Linie Linie { get; set; }
        public Kreis(Linie Linie) 
        {
            this.Linie = Linie;
        }
        public double BerechneUmfang()
        {
            return Linie.Laenge;
        }
        public double BerechneFlaeche()
        {
            return Math.Pow(Linie.Laenge, 2) * Math.PI;
        }
    }
}
