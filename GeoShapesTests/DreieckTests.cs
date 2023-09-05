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
    public class DreieckTests
    {
        [TestMethod()]
        public void BerechneUmfangTest()
        {
            Linie linieA = new Linie(5);
            Linie linieB = new Linie(4);
            Linie linieC = new Linie(3);

            Dreieck dreieck = new Dreieck(linieA, linieB, linieC);

            double value = dreieck.BerechneUmfang();

            Assert.AreEqual(value, 12);
        }
    }
}