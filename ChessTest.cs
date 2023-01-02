using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class ChessTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=83e59743cf009587d992a83a5bd244c21754c401;bomb=HE8DE2


        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "HE8DE2", 1, 1,
        new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", true, true), new Indicator("SIG", true, true),
        new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(false, false, false, false, true, false),
        });

        [TestMethod]
        public void Test1()
        {
            Chess module = new Chess("C4", "E1", "F2", "A1", "E2", "B4", bomb, io);

            Assert.AreEqual("C6", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            Chess module = new Chess("F5", "C4", "E2", "F1", "A5", "C3", bomb, io);

            Assert.AreEqual("C6", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void Test3()
        {
            Chess module = new Chess("C5", "C6", "E3", "A1", "F5", "E2", bomb, io);

            Assert.AreEqual("B2", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void Test4()
        {
            Chess module = new Chess("C5", "C3", "A2", "E6", "D1", "F4", bomb, io);

            Assert.AreEqual("F5", module.Solve(true));
            io.Close();
        }


        [TestMethod]
        public void Test5()
        {
            Chess module = new Chess("E6", "E5", "F2", "B1", "A4", "A5", bomb, io);

            Assert.AreEqual("A6", module.Solve(true));
            io.Close();
        }

    }
}
