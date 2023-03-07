using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=00254b61b792966d77e3e5a3d6ee4c35fc6525a3;bomb=NF0QV4

    [TestClass]
    public class LetterKeysTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "NF0QV4", 0, 0,
             new Indicator("BOB", true, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", true, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>()
             { new Plate(false, false, true, false, false, false),
               new Plate(true, false, false, false, false, false),}
            );

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            LetterKeys module = new LetterKeys(bomb, io, 63);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("A", answer);
        }

        [TestMethod]
        public void Test2()
        {
            LetterKeys module = new LetterKeys(bomb, io, 6);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("A", answer);
        }

        [TestMethod]
        public void Test3()
        {
            LetterKeys module = new LetterKeys(bomb, io, 21);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("D", answer);
        }

        [TestMethod]
        public void Test4()
        {
            LetterKeys module = new LetterKeys(bomb, io, 73);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("A", answer);
        }

        [TestMethod]
        public void Test5()
        {
            LetterKeys module = new LetterKeys(bomb, io, 58);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("A", answer);
        }
    }
}