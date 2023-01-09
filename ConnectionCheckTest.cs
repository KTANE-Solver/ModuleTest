using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class ConnectionCheckTest
    {
        //https://ktane.timwi.de/lfa#file=de57655e36f71b851dff8bcc3a339738dbdc2da0


        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "E82HS9", 1, 1,
        new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
        new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(true, false, true, false, false, false),
            new Plate(false, false, false, false, false, false),
            new Plate(false, false, false, false, false, false),
            new Plate(false, false, false, false, false, false),

        });

        [TestMethod]
        public void Test1()
        {
            int[] tl = new int[] { 2,3 };
            int[] tr = new int[] { 4,6};
            int[] bl = new int[] {1,5 };
            int[] br = new int[] {4,2 };

            ConnectionCheck module = new ConnectionCheck(tl, tr, bl, br, bomb, io);
            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("\nTop Left: Red\nTop Right: Green\nBottom Left: Red\nBottom Right: Green", answer);
        }

        [TestMethod]
        public void Test2()
        {
            int[] tl = new int[] { 7, 5 };
            int[] tr = new int[] { 4, 1 };
            int[] bl = new int[] { 8, 4 };
            int[] br = new int[] { 6, 1 };

            ConnectionCheck module = new ConnectionCheck(tl, tr, bl, br, bomb, io);
            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("\nTop Left: Green\nTop Right: Red\nBottom Left: Red\nBottom Right: Green", answer);
        }

        [TestMethod]
        public void Test3()
        {
            int[] tl = new int[] { 7, 8 };
            int[] tr = new int[] { 5, 3 };
            int[] bl = new int[] { 7, 4 };
            int[] br = new int[] { 6, 3 };

            ConnectionCheck module = new ConnectionCheck(tl, tr, bl, br, bomb, io);
            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("\nTop Left: Green\nTop Right: Red\nBottom Left: Red\nBottom Right: Green", answer);
        }

        [TestMethod]
        public void Test4()
        {
            int[] tl = new int[] { 6, 8 };
            int[] tr = new int[] { 3, 1 };
            int[] bl = new int[] { 1, 4 };
            int[] br = new int[] { 7, 1 };

            ConnectionCheck module = new ConnectionCheck(tl, tr, bl, br, bomb, io);
            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("\nTop Left: Red\nTop Right: Green\nBottom Left: Red\nBottom Right: Red", answer);
        }

        [TestMethod]
        public void Test5()
        {
            int[] tl = new int[] { 7, 8 };
            int[] tr = new int[] { 6, 7 };
            int[] bl = new int[] { 8, 1 };
            int[] br = new int[] { 4, 7 };

            ConnectionCheck module = new ConnectionCheck(tl, tr, bl, br, bomb, io);
            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("\nTop Left: Green\nTop Right: Green\nBottom Left: Green\nBottom Right: Red", answer);
        }


    }
}
