using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;
using static System.Drawing.Color;
namespace ModuleTest
{
    [TestClass]
    public class ColorMathTest
    {
        //https://ktane.timwi.de/lfa#file=3137bde742c15517ab3846dc13c154cf653ec3b8


        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "Q82HP3", 2, 1,
        new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", true, false), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", true, true), new Indicator("SIG", false, false),
        new Indicator("SND", true, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(true, false, true, false, false, false),
        });

        [TestMethod]
        public void Test1()
        {
            Color[] left = new Color[] { Red, Orange, Black, Yellow };
            Color[] right = new Color[] { Yellow, Magenta, Black, Gray };

            ColorMath module = new ColorMath(left, right, 'D', bomb, io);

             string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Gray, Blue, Magenta, Blue", answer);
        }

        [TestMethod]
        public void Test2()
        {
            Color[] left = new Color[] { Orange, Orange, Magenta, Orange };
            Color[] right = null;

            ColorMath module = new ColorMath(left, right, 'S', bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Blue, Magenta, White, Gray", answer);
        }

        [TestMethod]
        public void Test3()
        {
            Color[] left = new Color[] { Red, Red, Gray, Blue };
            Color[] right = null;

            ColorMath module = new ColorMath(left, right, 'D', bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Gray, Black, Red, Magenta", answer);
        }


        [TestMethod]
        public void Test4()
        {
            Color[] left = new Color[] { Magenta, White, Yellow, Black };
            Color[] right = new Color[] { White, Black, Purple, Magenta };

            ColorMath module = new ColorMath(left, right, 'S', bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("White, Black, White, Yellow", answer);
        }

        [TestMethod]
        public void Test5()
        {
            Color[] left = new Color[] { Purple, Blue, Magenta, Green };
            Color[] right = new Color[] { Purple, Gray, Red, White };

            ColorMath module = new ColorMath(left, right, 'S', bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Orange, Purple, Purple, Gray", answer);
        }

    }
}
