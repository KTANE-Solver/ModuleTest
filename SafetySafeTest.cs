using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class SafetySafeTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=a7c862fd0481f3972065176e88a2cdedb64b5639;bomb=SR6RJ2
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "NN1VF6", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
             new Indicator("MSA", true, true), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", true, true), new Indicator("TRN", false, false), new List<Plate>()
             { 
                new Plate(false, false, true, false, false, false)
             });

            SafetySafe module = new SafetySafe(bomb, io);
            int[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(answer[0], 2);
            Assert.AreEqual(answer[1], 10);
            Assert.AreEqual(answer[2], 3);
            Assert.AreEqual(answer[3], 1);
            Assert.AreEqual(answer[4], 6);
            Assert.AreEqual(answer[5], 9);

        }

        [TestMethod]
        public void Test2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "6U0MD5", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
             {
                new Plate(true, false, false, false, false, false),
                new Plate(false, false, true, false, false, false)
             });

            SafetySafe module = new SafetySafe(bomb, io);
            int[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(answer[0], 3);
            Assert.AreEqual(answer[1], 11);
            Assert.AreEqual(answer[2], 5);
            Assert.AreEqual(answer[3], 7);
            Assert.AreEqual(answer[4], 9);
            Assert.AreEqual(answer[5], 8);
        }

        [TestMethod]
        public void Test3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "KU6CH6", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
             {
                new Plate(true, false, false, false, false, false),
                new Plate(true, false, false, false, false, false)
             });

            SafetySafe module = new SafetySafe(bomb, io);
            int[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(answer[0], 0);
            Assert.AreEqual(answer[1], 4);
            Assert.AreEqual(answer[2], 0);
            Assert.AreEqual(answer[3], 0);
            Assert.AreEqual(answer[4], 1);
            Assert.AreEqual(answer[5], 5);
        }

        [TestMethod]
        public void Test4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "8B4ZZ8", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, false), new Indicator("IND", true, true),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
             {
                new Plate(false, false, true, false, false, false),
                new Plate(true, false, false, false, false, false)
             });

            SafetySafe module = new SafetySafe(bomb, io);
            int[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(answer[0], 7);
            Assert.AreEqual(answer[1], 3);
            Assert.AreEqual(answer[2], 2);
            Assert.AreEqual(answer[3], 0);
            Assert.AreEqual(answer[4], 2);
            Assert.AreEqual(answer[5], 8);
        }

        [TestMethod]
        public void Test5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SF4KF1", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", true, true), new List<Plate>()
             {
                new Plate(false, true, true, false, false, true)
             });

            SafetySafe module = new SafetySafe(bomb, io);
            int[] answer = module.Solve();
            io.Close();

            Assert.AreEqual(answer[0], 6);
            Assert.AreEqual(answer[1], 11);
            Assert.AreEqual(answer[2], 9);
            Assert.AreEqual(answer[3], 10);
            Assert.AreEqual(answer[4], 10);
            Assert.AreEqual(answer[5], 11);
        }

    }
}