namespace Portfolio_Auftrag_GeoShapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Linie linieA = new Linie(2);
            Linie linieB = new Linie(2);
            Linie linieC = new Linie(4);
            Linie linieD = new Linie(4);
            Linie linieE = new Linie(3);
            Linie linieF = new Linie(3);

            Rechteck rechteck1 = new Rechteck(linieA, linieB, linieC, linieD);
            Rechteck rechteck2 = new Rechteck(linieA, linieB, linieE, linieF);

            Dreieck dreieck1 = new Dreieck(linieA, linieC, linieE);

            Kreis kreis1 = new Kreis(linieA);
            Kreis kreis2 = new Kreis(linieC);

            Formenbehaelter formenbehaelter = new Formenbehaelter(rechteck1, rechteck2, kreis1);
            formenbehaelter.FuegeFormHinzu(dreieck1);
            formenbehaelter.FuegeFormHinzu(kreis2);
            
        }
    }
}