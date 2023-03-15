using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class RubikCubeTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=a7c862fd0481f3972065176e88a2cdedb64b5639;bomb=SR6RJ2
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SR6RJ2", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>());

            RubikCube.Face up = RubikCube.Face.GREEN;
            RubikCube.Face left = RubikCube.Face.YELLOW;
            RubikCube.Face front = RubikCube.Face.BLUE;
            RubikCube.Face right = RubikCube.Face.RED;
            RubikCube.Face bottom = RubikCube.Face.WHITE;

            RubikCube module = new RubikCube(up, left, front, right, bottom, bomb, io);

            string answer  = module.Solve(true).Replace(",", "");
            io.Close();

            Assert.AreEqual("R' D D U U F D' U' B' L'", answer);
        }

        [TestMethod]
        public void Test2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3K8CV3", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>());

            RubikCube.Face up = RubikCube.Face.GREEN;
            RubikCube.Face left = RubikCube.Face.ORANGE;
            RubikCube.Face front = RubikCube.Face.YELLOW;
            RubikCube.Face right = RubikCube.Face.RED;
            RubikCube.Face bottom = RubikCube.Face.WHITE;

            RubikCube module = new RubikCube(up, left, front, right, bottom, bomb, io);

            string answer = module.Solve(true).Replace(",", "");
            io.Close();

            Assert.AreEqual("R U' B L F' B B R F B", answer);
        }

        [TestMethod]
        public void Test3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GR5EX6", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>());

            RubikCube.Face up = RubikCube.Face.ORANGE;
            RubikCube.Face left = RubikCube.Face.BLUE;
            RubikCube.Face front = RubikCube.Face.GREEN;
            RubikCube.Face right = RubikCube.Face.YELLOW;
            RubikCube.Face bottom = RubikCube.Face.RED;

            RubikCube module = new RubikCube(up, left, front, right, bottom, bomb, io);

            string answer = module.Solve(true).Replace(",", "");
            io.Close();

            Assert.AreEqual("B U' B' L' B L' B' R D L'", answer);
        }

        [TestMethod]
        public void Test4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "2E7AE4", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>());

            RubikCube.Face up = RubikCube.Face.RED;
            RubikCube.Face left = RubikCube.Face.WHITE;
            RubikCube.Face front = RubikCube.Face.BLUE;
            RubikCube.Face right = RubikCube.Face.ORANGE;
            RubikCube.Face bottom = RubikCube.Face.YELLOW;

            RubikCube module = new RubikCube(up, left, front, right, bottom, bomb, io);

            string answer = module.Solve(true).Replace(",", "");
            io.Close();

            Assert.AreEqual("U' B D U' B' F R L F L'", answer);
        }

        [TestMethod]
        public void Test5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "4G2CL5", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>());

            RubikCube.Face up = RubikCube.Face.RED;
            RubikCube.Face left = RubikCube.Face.ORANGE;
            RubikCube.Face front = RubikCube.Face.WHITE;
            RubikCube.Face right = RubikCube.Face.BLUE;
            RubikCube.Face bottom = RubikCube.Face.GREEN;

            RubikCube module = new RubikCube(up, left, front, right, bottom, bomb, io);

            string answer = module.Solve(true).Replace(",", "");
            io.Close();

            Assert.AreEqual("U' F R D' U' F R D' B' L'", answer);
        }
    }
}