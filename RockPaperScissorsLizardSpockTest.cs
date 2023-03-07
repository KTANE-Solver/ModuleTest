using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e99ac35350a6c2018f84c407a33fdcd41579a86f;bomb=BA5EE1


    [TestClass]
    public class RockPaperScissorsLizardSpockTest
    {
        Bomb bomb1 = new Bomb(Day.Sunday, "MR9FX4", 3, 3,
             new Indicator("BOB", false, false), new Indicator("CAR", true, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() { new Plate(true, false, true, false, false, false),
                                 new Plate(false, true, false, true, true, true)}
            );

        Bomb bomb2 = new Bomb(Day.Sunday, "U76CU6", 1, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", true, false),
             new List<Plate>() { new Plate(true, false, true, false, false, false),
                                 new Plate(false, false, true, false, false, false)}
            );

        Bomb bomb3 = new Bomb(Day.Sunday, "PJ1WH2", 0, 0,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, false),
             new Indicator("SND", true, false), new Indicator("TRN", false, false),
             new List<Plate>() { new Plate(true, false, false, false, false, false),
                                 new Plate(false, true, false, false, true, true),
                                 new Plate(false, false, false, false, false, false)}
            );

        Bomb bomb4 = new Bomb(Day.Sunday, "C04KZ4", 1, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", true, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", true, true), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() { new Plate(true, false, false, false, false, false),
                                 new Plate(false, true, false, true, false, true)}
            );

        Bomb bomb5 = new Bomb(Day.Sunday, "316KE7", 3, 3,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, false), new Indicator("IND", true, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>()
            );
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            RockPaperScissorsLizardSpock r = new RockPaperScissorsLizardSpock(RockPaperScissorsLizardSpock.Symbol.Lizard, bomb1, io);

            string answer = r.Solve(true);
            io.Close();

            Assert.AreEqual("Spock, Rock", answer);
        }

        [TestMethod]
        public void Test2()
        {
            RockPaperScissorsLizardSpock r = new RockPaperScissorsLizardSpock(RockPaperScissorsLizardSpock.Symbol.Paper, bomb2, io);

            string answer = r.Solve(true);
            io.Close();

            Assert.AreEqual("Paper, Lizard", answer);
        }

        [TestMethod]
        public void Test3()
        {
            RockPaperScissorsLizardSpock r = new RockPaperScissorsLizardSpock(RockPaperScissorsLizardSpock.Symbol.Paper, bomb3, io);

            string answer = r.Solve(true);
            io.Close();

            Assert.AreEqual("Rock, Scissors, Lizard, Spock", answer);
        }

        [TestMethod]
        public void Test4()
        {
            RockPaperScissorsLizardSpock r = new RockPaperScissorsLizardSpock(RockPaperScissorsLizardSpock.Symbol.Spock, bomb4, io);

            string answer = r.Solve(true);
            io.Close();

            Assert.AreEqual("Rock, Scissors", answer);
        }

        [TestMethod]
        public void Test5()
        {
            RockPaperScissorsLizardSpock r = new RockPaperScissorsLizardSpock(RockPaperScissorsLizardSpock.Symbol.Lizard, bomb5, io);

            string answer = r.Solve(true);
            io.Close();

            Assert.AreEqual("Paper, Lizard", answer);
        }


    }
}