using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portfolio_Auftrag_GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Auftrag_GeoShapes.Tests
{
    [TestClass()]
    public class KreisTests
    {
        [TestMethod()]
        public void BerechneUmfangTest()
        {
            Linie linie = new Linie(5);
            Kreis kreis = new Kreis(linie);

            double value = kreis.BerechneUmfang();
            
            Assert.AreEqual(value, 5);
        }

        [TestMethod()]
        public void BerechneFlaecheTest()
        {
            Linie linie = new Linie(1);
            Kreis kreis = new Kreis(linie);

            double value = kreis.BerechneFlaeche();

            Assert.AreEqual(value, Math.PI);
        }
    }
}