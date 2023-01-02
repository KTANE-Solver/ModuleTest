using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class ChordQualitiesTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=1aa65aa2cd7a3016284ca62f8e61d85cc8d03664;bomb=RH7NG2


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
            List<string> notes = new List<string>() { "B", "C#", "D#", "F#" };
            ChordQualities module = new ChordQualities(bomb, io, notes);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("D#, F#, A#, C#", answer);
        }

        [TestMethod]
        public void Test2()
        {
            List<string> notes = new List<string>() { "G#", "C#", "D#", "F#" };
            ChordQualities module = new ChordQualities(bomb, io, notes);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("D, F#, A#, C", answer);
        }

        [TestMethod]
        public void Test3()
        {
            List<string> notes = new List<string>() { "D#", "G#", "A#", "C#" };
            ChordQualities module = new ChordQualities(bomb, io, notes);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("D, F, F#, C", answer);
        }

        [TestMethod]
        public void Test4()
        {
            List<string> notes = new List<string>() { "G", "B", "D#", "F#" };
            ChordQualities module = new ChordQualities(bomb, io, notes);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("C, D#, G, B", answer);
        }

        [TestMethod]
        public void Test5()
        {
            List<string> notes = new List<string>() { "A#", "D", "F", "A" };
            ChordQualities module = new ChordQualities(bomb, io, notes);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("A#, D, F#, A", answer);
        }

    }
}
