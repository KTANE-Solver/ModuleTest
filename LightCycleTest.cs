using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class LightCycleTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e02185b319e748988b4896310a3e9634aedd4723;bomb=520BT3

        StreamWriter io = new StreamWriter("dummy.txt");


        Bomb bomb1 = new Bomb(Day.Sunday, "520BT3", 4, 3,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", true, true), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(true, false, true, false, false, false)
        });

        Bomb bomb2 = new Bomb(Day.Sunday, "2N5SP6", 1, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, true), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(false, false, true, false, false, false),
            new Plate(false, true, false, false, true, true),
            new Plate(false, false, false, false, true, false),

        });

        Bomb bomb3 = new Bomb(Day.Sunday, "5E5MH5", 1, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, true), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(false, false, true, false, false, false),
            new Plate(false, true, false, false, true, true),
            new Plate(false, false, false, false, true, false),

        });

        Bomb bomb4 = new Bomb(Day.Sunday, "I99NC3", 1, 1,
         new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
         new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
         new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
         new Indicator("SND", false, true), new Indicator("TRN", false, false), new List<Plate>()
     {
            new Plate(false, false, true, false, false, false),
            new Plate(false, true, false, false, true, true),
            new Plate(false, false, false, false, true, false),

     });

        Bomb bomb5 = new Bomb(Day.Sunday, "S08CI8", 1, 1,
 new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
 new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
 new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
 new Indicator("SND", false, true), new Indicator("TRN", false, false), new List<Plate>()
{
            new Plate(false, false, true, false, false, false),
            new Plate(false, true, false, false, true, true),
            new Plate(false, false, false, false, true, false),

});

        [TestMethod]
        public void Test1()
        {
            LightCycle i = new LightCycle(bomb1, io, "WGRBMY");
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("(1) White, (3) Red, (6) Yellow, \n(4) Blue, \n(2) Green, (5) Magenta", answer);
        }

        [TestMethod]
        public void Test2()
        {
            LightCycle i = new LightCycle(bomb2, io, "WGRBMY");
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("(1) White, (6) Yellow, \n(2) Green, (3) Red, (4) Blue, (5) Magenta", answer);
        }

        [TestMethod]
        public void Test3()
        {
            LightCycle i = new LightCycle(bomb3, io, "GMRWBY");
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("(6) Yellow, \n(2) Magenta, (3) Red, (5) Blue, \n(1) Green, (4) White", answer);
        }

        [TestMethod]
        public void Test4()
        {
            LightCycle i = new LightCycle(bomb4, io, "BRWGMY");
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("(5) Magenta, \n(2) Red, (4) Green, \n(1) Blue, (3) White, (6) Yellow", answer);
        }

        [TestMethod]
        public void Test5()
        {
            LightCycle i = new LightCycle(bomb5, io, "MGBYRW");
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("(6) White, \n(3) Blue, (5) Red, \n(1) Magenta, (2) Green, (4) Yellow", answer);
        }


    }
}