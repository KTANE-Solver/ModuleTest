using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class CreationTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e8f6e6a9015cb8174b91f87738246b32893d80d8;bomb=QB4IU3
        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "QB4IU3", 2, 1,
        new Indicator("BOB", false, false), new Indicator("CAR", true, false), new Indicator("CLR", true, true),
        new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
        new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(false, true, false, false, false, false),

        });

        Creation.Weather clear = Creation.Weather.Clear;
        Creation.Weather heatWave = Creation.Weather.HeatWave;
        Creation.Weather rain = Creation.Weather.Rain;
        Creation.Weather meteorShower = Creation.Weather.MeteorShower;
        Creation.Weather wind = Creation.Weather.Wind;


        [TestMethod]
        public void Test1()
        {
            Creation module = new Creation(bomb, io, clear, "", "", "", "");

            /*
             EARTH + WATER

            rain
            earth + fire
            swamp + energy

            wind
            life + weater

            meatorshower
            air + weeds
             */

            string answer1 = module.Solve(clear, 0, true).ToUpper();
            string answer2 = module.Solve(rain, 1, true).ToUpper();
            string answer3 = module.Solve(wind, 2, true).ToUpper();
            string answer4 = module.Solve(meteorShower, 3, true).ToUpper();

            io.Close();

            Assert.AreEqual("EARTH + WATER", answer1);
            Assert.AreEqual("FIRE + AIR,\nSWAMP + ENERGY", answer2);
            Assert.AreEqual("LIFE + WATER", answer3);
            Assert.AreEqual("AIR + WEEDS", answer4);
        }

        [TestMethod]
        public void Test2()
        {
            Creation module = new Creation(bomb, io, heatWave, "", "", "Fire", "");

            /*
             EARTH + WATER

            meator
            fire + air
            swamp + energy

            wind
            life + water

            meatorshower
            air + weeds
             */

            string answer1 = module.Solve(heatWave, 0, true).ToUpper();
            string answer2 = module.Solve(rain, 1, true).ToUpper();
            string answer3 = module.Solve(wind, 2, true).ToUpper();
            string answer4 = module.Solve(meteorShower, 3, true).ToUpper();

            io.Close();

            Assert.AreEqual("EARTH + WATER", answer1);
            Assert.AreEqual("FIRE + AIR,\nSWAMP + ENERGY", answer2);
            Assert.AreEqual("LIFE + WATER", answer3);
            Assert.AreEqual("AIR + WEEDS", answer4);
        }

        [TestMethod]
        public void Test3()
        {
            Creation module = new Creation(bomb, io, clear, "", "", "", "");

            /*
             EARTH + WATER

            meator shower
            earth + fire
            swamp + energy

            rain
            life + fire

            heat wave
            air + weeds
             */

            string answer1 = module.Solve(clear, 0, true).ToUpper();
            string answer2 = module.Solve(meteorShower, 1, true).ToUpper();
            string answer3 = module.Solve(rain, 2, true).ToUpper();
            string answer4 = module.Solve(heatWave, 3, true).ToUpper();

            io.Close();

            Assert.AreEqual("EARTH + WATER", answer1);
            Assert.AreEqual("FIRE + AIR,\nSWAMP + ENERGY", answer2);
            Assert.AreEqual("LIFE + FIRE", answer3);
            Assert.AreEqual("EARTH + WEEDS", answer4);
        }

        [TestMethod]
        public void Test4()
        {
            Creation module = new Creation(bomb, io, heatWave, "", "", "Fire", "");

            /*
             HEAT WAVE
             EARTH + WATHER

            RAIN
            FIRE + AIR
            swamp + energy

            wind
            life + water

            HEAT WAVE
            air + weeds
             */

            string answer1 = module.Solve(heatWave, 0, true).ToUpper();
            string answer2 = module.Solve(rain, 1, true).ToUpper();
            string answer3 = module.Solve(wind, 2, true).ToUpper();
            string answer4 = module.Solve(heatWave, 3, true).ToUpper();

            io.Close();

            Assert.AreEqual("EARTH + WATER", answer1);
            Assert.AreEqual("FIRE + AIR,\nSWAMP + ENERGY", answer2);
            Assert.AreEqual("LIFE + WATER", answer3);
            Assert.AreEqual("EARTH + WEEDS", answer4);
        }

        [TestMethod]
        public void Test5()
        {
            Creation module = new Creation(bomb, io, heatWave, "", "Fire", "", "");

            /*
             HEAT WAVE
             EARTH + WATER

            CLEAR
            fire + air
            swamp + energy
            life + SWAMP

            CLEAR
            BACTERIA + WATER
             */

            string answer1 = module.Solve(heatWave, 0, true).ToUpper();
            string answer2 = module.Solve(clear, 1, true).ToUpper();
            string answer3 = module.Solve(clear, 2, true).ToUpper();

            io.Close();

            Assert.AreEqual("EARTH + WATER", answer1);
            Assert.AreEqual("FIRE + AIR,\nSWAMP + ENERGY,\nSWAMP + LIFE", answer2);
            Assert.AreEqual("WATER + BACTERIA", answer3);
        }
    }
}