using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class GamepadTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=d2de0dd632ff4c5b48e7c3d9a0f2718ee8afe109;bomb=934ES0

        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "934ES0", 4, 3,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", true, true), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>() { new Plate(false, false, false, false, false, false) });

        [TestMethod]
        public void Test1()
        {
            Gamepad g = new Gamepad(38, 18, bomb, io);
            string answer = g.Solve(true);
            io.Close();

            Assert.AreEqual("RIGHT, A, B, UP, B, UP, RIGHT, A", answer);
        }

        [TestMethod]
        public void Test2()
        {
            Gamepad g = new Gamepad(79, 96, bomb, io);
            string answer = g.Solve(true);
            io.Close();

            Assert.AreEqual("UP, UP, DOWN, DOWN, DOWN, UP, B, RIGHT", answer);
        }

        [TestMethod]
        public void Test3()
        {
            Gamepad g = new Gamepad(38, 54, bomb, io);
            string answer = g.Solve(true);
            io.Close();

            Assert.AreEqual("RIGHT, A, B, UP, B, UP, RIGHT, A", answer);
        }

        [TestMethod]
        public void Test4()
        {
            Gamepad g = new Gamepad(11, 22, bomb, io);
            string answer = g.Solve(true);
            io.Close();

            Assert.AreEqual("UP, UP, DOWN, DOWN, RIGHT, UP, B, A", answer);
        }

        [TestMethod]
        public void Test5()
        {
            Gamepad g = new Gamepad(14, 22, bomb, io);
            string answer = g.Solve(true);
            io.Close();

            Assert.AreEqual("LEFT, LEFT, UP, B, B, UP, RIGHT, A", answer);
        }
    }
}