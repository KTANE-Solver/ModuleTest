using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class FastMathTest
    {
        //https://ktane.timwi.de/lfa#file=de57655e36f71b851dff8bcc3a339738dbdc2da0


        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "K11EN8", 2, 1,
        new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", true, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
        new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(true, false, false, false, false, false),
            new Plate(false, false, false, false, true, true),
            new Plate(false, false, false, false, false, false),

        });

        [TestMethod]
        public void Test1()
        {

            FastMath module = new FastMath(bomb, io);

            int answer1 = module.Solve('E', 'G', true);
            int answer2 = module.Solve('K', 'A', true);
            int answer3 = module.Solve('Z', 'Z', true);


            io.Close();
            Assert.AreEqual(5, answer1);
            Assert.AreEqual(88, answer2);
            Assert.AreEqual(99, answer3);

        }

        [TestMethod]
        public void Test2()
        {

            FastMath module = new FastMath(bomb, io);

            int answer1 = module.Solve('P', 'T', true);
            int answer2 = module.Solve('G', 'E', true);
            int answer3 = module.Solve('E', 'Z', true);


            io.Close();
            Assert.AreEqual(27, answer1);
            Assert.AreEqual(56, answer2);
            Assert.AreEqual(67, answer3);

        }

        [TestMethod]
        public void Test3()
        {

            FastMath module = new FastMath(bomb, io);

            int answer1 = module.Solve('E', 'P', true);
            int answer2 = module.Solve('D', 'Z', true);
            int answer3 = module.Solve('X', 'N', true);


            io.Close();
            Assert.AreEqual(44, answer1);
            Assert.AreEqual(80, answer2);
            Assert.AreEqual(37, answer3);

        }

        [TestMethod]
        public void Test4()
        {

            FastMath module = new FastMath(bomb, io);

            int answer1 = module.Solve('D', 'B', true);
            int answer2 = module.Solve('P', 'E', true);
            int answer3 = module.Solve('B', 'Z', true);
            int answer4 = module.Solve('K', 'P', true);


            io.Close();
            Assert.AreEqual(28, answer1);
            Assert.AreEqual(67, answer2);
            Assert.AreEqual(58, answer3);
            Assert.AreEqual(12, answer4);
        }

        [TestMethod]
        public void Test5()
        {

            FastMath module = new FastMath(bomb, io);

            int answer1 = module.Solve('D', 'S', true);
            int answer2 = module.Solve('E', 'T', true);
            int answer3 = module.Solve('X', 'E', true);
            int answer4 = module.Solve('G', 'T', true);


            io.Close();
            Assert.AreEqual(48, answer1);
            Assert.AreEqual(26, answer2);
            Assert.AreEqual(9, answer3);
            Assert.AreEqual(10, answer4);
        }
    }
}
