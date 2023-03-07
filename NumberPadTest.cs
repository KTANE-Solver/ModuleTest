using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e99ac35350a6c2018f84c407a33fdcd41579a86f;bomb=BA5EE1


    [TestClass]
    public class NumberPadTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "KR9XI7", 7, 4,
             new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>()
            );

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            NumberPad module = new NumberPad(Color.White, Color.Red, Color.White,
                                             Color.Red, Color.Green, Color.Blue,
                                             Color.White, Color.White, Color.Blue,
                                             Color.White, bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("1839", answer);
        }

        [TestMethod]
        public void Test2()
        {
            NumberPad module = new NumberPad(Color.Green, Color.Blue, Color.Blue,
                                             Color.Green, Color.Blue, Color.Red,
                                             Color.Yellow, Color.Green, Color.Yellow,
                                             Color.Red, bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("9851", answer);
        }

        [TestMethod]
        public void Test3()
        {
            NumberPad module = new NumberPad(Color.Blue, Color.Red, Color.White,
                                             Color.Red, Color.White, Color.Red,
                                             Color.Red, Color.White, Color.Red,
                                             Color.Green, bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("3679", answer);
        }

        [TestMethod]
        public void Test4()
        {
            NumberPad module = new NumberPad(Color.White, Color.Blue, Color.Yellow,
                                             Color.Red, Color.Blue, Color.Yellow,
                                             Color.Red, Color.Blue, Color.Red,
                                             Color.Yellow, bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("4236", answer);
        }

        [TestMethod]
        public void Test5()
        {
            NumberPad module = new NumberPad(Color.Green, Color.Green, Color.Blue,
                                             Color.Red, Color.Yellow, Color.Red,
                                             Color.Yellow, Color.White, Color.Yellow,
                                             Color.Red, bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("4236", answer);
        }
    }
}