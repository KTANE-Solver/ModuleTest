using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class AstrologyTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=3005fb93421555aca1291fdc7045c7bdb8612606;bomb=EP5SB4

        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "EP5SB4", 3, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", true, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1,
            new Port("DVID", 1), new Port("Parallel", 0), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 1));

        [TestMethod]
        public void Test1()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Pluto", "Leo");

            Assert.AreEqual(3,module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test10()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Uranus", "Sagittarius");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test100()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Pluto", "Aquarius");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test11()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Saturn", "Sagittarius");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test12()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mars", "Cancer");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test13()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Neptune", "Leo");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test14()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Sun", "Aquarius");

            Assert.AreEqual(-3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test15()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mercury", "Scorpio");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test16()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Uranus", "Gemini");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test17()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Gemini");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test18()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Uranus", "Scorpio");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test19()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Saturn", "Libra");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Jupiter", "Aries");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test20()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Sun", "Aquarius");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test21()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Pluto", "Aquarius");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test22()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Pluto", "Cancer");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test23()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Saturn", "Aries");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test24()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Uranus", "Gemini");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test25()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mercury", "Capricorn");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test26()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Uranus", "Virgo");

            Assert.AreEqual(-1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test27()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Jupiter", "Pisces");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test28()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Neptune", "Gemini");

            Assert.AreEqual(-1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test29()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mars", "Gemini");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mars", "Scorpio");

            Assert.AreEqual(7, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test30()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Moon", "Aries");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test31()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Sun", "Libra");

            Assert.AreEqual(-2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test32()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mars", "Gemini");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test33()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Sun", "Pisces");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test34()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Mars", "Libra");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test35()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Mars", "Cancer");

            Assert.AreEqual(-5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test36()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Mars", "Capricorn");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test37()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Moon", "Leo");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test38()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Pluto", "Leo");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test39()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Saturn", "Scorpio");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Moon", "Aries");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test40()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mercury", "Capricorn");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test41()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Uranus", "Aries");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test42()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Saturn", "Aries");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test43()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Moon", "Capricorn");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test44()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Venus", "Scorpio");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test45()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Neptune", "Cancer");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test46()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Pluto", "Sagittarius");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test47()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mars", "Pisces");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test48()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Moon", "Leo");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test49()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Sun", "Virgo");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Venus", "Libra");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test50()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mercury", "Libra");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test51()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Mars", "Gemini");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test52()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Uranus", "Aquarius");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test53()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Neptune", "Taurus");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test54()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Sun", "Virgo");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }


        [TestMethod]
        public void Test55()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Jupiter", "Cancer");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test56()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Sun", "Aquarius");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test57()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mercury", "Cancer");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test58()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Saturn", "Cancer");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test59()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Sun", "Libra");

            Assert.AreEqual(-2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test6()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Aries");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test60()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mercury", "Pisces");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test61()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Pisces");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test62()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Pluto", "Taurus");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test63()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Pluto", "Cancer");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test64()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mars", "Scorpio");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test65()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Jupiter", "Aries");

            Assert.AreEqual(0, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test66()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Pluto", "Aries");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test67()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Uranus", "Aries");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test68()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mars", "Aquarius");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test69()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Saturn", "Scorpio");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test7()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Saturn", "Cancer");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test70()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Taurus");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test71()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mars", "Cancer");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test72()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Pluto", "Leo");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void Test73()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Neptune", "Aquarius");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test74()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Mars", "Pisces");

            Assert.AreEqual(-3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test75()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Scorpio");

            Assert.AreEqual(7, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test76()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Pluto", "Aquarius");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test77()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Pluto", "Capricorn");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test78()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Moon", "Libra");

            Assert.AreEqual(-1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test79()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Venus", "Taurus");

            Assert.AreEqual(7, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test8()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Moon", "Cancer");

            Assert.AreEqual(-1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test80()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Jupiter", "Virgo");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test81()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Cancer");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test82()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Pluto", "Cancer");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test83()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Mars", "Aquarius");

            Assert.AreEqual(5, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test84()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Mars", "Gemini");

            Assert.AreEqual(-4, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test85()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Jupiter", "Capricorn");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test86()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Moon", "Taurus");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test87()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Jupiter", "Taurus");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test88()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Mercury", "Taurus");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test89()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Sun", "Cancer");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test9()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Moon", "Gemini");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test90()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Jupiter", "Gemini");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test91()
        {
            Astrology module = new Astrology(bomb, io, "Earth", "Uranus", "Libra");

            Assert.AreEqual(7, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test92()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Mars", "Leo");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test93()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Jupiter", "Taurus");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test94()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Pluto", "Taurus");

            Assert.AreEqual(6, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test95()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Neptune", "Leo");

            Assert.AreEqual(2, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test96()
        {
            Astrology module = new Astrology(bomb, io, "Water", "Saturn", "Capricorn");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test97()
        {
            Astrology module = new Astrology(bomb, io, "Air", "Mars", "Scorpio");

            Assert.AreEqual(1, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test98()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Jupiter", "Cancer");

            Assert.AreEqual(3, module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test99()
        {
            Astrology module = new Astrology(bomb, io, "Fire", "Jupiter", "Gemini");

            Assert.AreEqual(4, module.Solve(true));
            io.Close();
        }
    }
}