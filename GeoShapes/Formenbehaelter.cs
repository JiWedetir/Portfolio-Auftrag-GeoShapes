using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes
{
    public class Formenbehaelter
    {
        private Rechteck rechteckA;
        private Rechteck rechteckB;
        private List<Dreieck> dreiecke = new List<Dreieck>();
        private List<Kreis> kreise = new List<Kreis>();
        private const int maxAnzahlDreiecke = 4;
        private const int minAnzahlDreiecke = 0;
        private const int maxAnzahlKreise = 3;
        private const int minAnzahlKreise = 1;

        public Formenbehaelter(Rechteck rechteckA, Rechteck rechteckB, Kreis kreis)
        {
            this.rechteckA = rechteckA;
            this.rechteckB = rechteckB;
            kreise.Add(kreis);
        }

        public void FuegeFormHinzu(Kreis kreis)
        {
            if (kreise.Count < maxAnzahlKreise) 
            {
                kreise.Add(kreis);
            }
            else
            {
                Console.WriteLine("Kreis konnte nicht hinzugefügt werden, " +
                    $"da schon die maximale Anzahl von {maxAnzahlKreise} Kreisen vorhanden ist.");
            }
        }

        public void FuegeFormHinzu(Dreieck dreieck)
        {
            if (dreiecke.Count < maxAnzahlDreiecke)
            {
                dreiecke.Add(dreieck);
            }
            else
            {
                Console.WriteLine("Dreieck konnte nicht hinzugefügt werden, " +
                    $"da schon die maximale Anzahl von {maxAnzahlDreiecke} Dreiecken vorhanden ist.");
            }
        }

        public void EntferneForm(Kreis kreis)
        {
            if (kreise.Count > minAnzahlKreise)
            {
                kreise.Remove(kreis);
            }
            else
            {
                Console.WriteLine("Kreis konnte nicht entfernt werden, " +
                    "da sonst weniger als 1 Kreis vorhanden ist.");
            }
        }

        public void EntferneForm(Dreieck dreieck)
        {
            if (dreiecke.Count > minAnzahlDreiecke)
            {
                dreiecke.Remove(dreieck);
            }
            else
            {
                Console.WriteLine("Dreieck konnte nicht entfernt werden, " +
                    "da kein Dreieck zum entfernen vorhanden ist.");
            }
        }
    }
}
