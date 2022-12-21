using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/lfa#file=1c5e8afec1479c495dee626a21f040d55766ce95

    

    [TestClass]
    public class AstrologyTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "LS5RN5", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", true, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() {
            new Plate(true, false, false, false, false, false),
            new Plate(true, false, false, false, false, false),
            new Plate(false, false, false, false, false, false) 
             });

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Saturn", "Taurus");

            Assert.AreEqual(1,module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Saturn", "Virgo");

            Assert.AreEqual(1, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Jupiter", "Capricorn");

            Assert.AreEqual(2, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Jupiter", "Taurus");

            Assert.AreEqual(2, module.Solve(true));

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Sagittarius");

            Assert.AreEqual(6, module.Solve(true));

            io.Close();
        }

    }
}