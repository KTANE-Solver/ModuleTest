using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTests
{
    [TestClass]
    public class LetterKeysTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e8b692c145c1736e69223ccbca86ac9edeaac6d7;bomb=IE9JV0

        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "IE9JV0", 0, 0, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 3, new Port("DVID", 3), new Port("Parallel", 0),
        new Port("ps", 2), new Port("rj", 1), new Port("serial", 0), new Port("setero", 2));
        
        [TestMethod]
        public void TestMethod1()
        {
            LetterKeys module = new LetterKeys(bomb, streamWriter, 34);
            Assert.AreEqual(module.SolveDebug(), "B");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            LetterKeys module = new LetterKeys(bomb, streamWriter, 41);
            Assert.AreEqual(module.SolveDebug(), "B");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            LetterKeys module = new LetterKeys(bomb, streamWriter, 76);
            Assert.AreEqual(module.SolveDebug(), "B");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            LetterKeys module = new LetterKeys(bomb, streamWriter, 26);
            Assert.AreEqual(module.SolveDebug(), "B");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            LetterKeys module = new LetterKeys(bomb, streamWriter, 92);
            Assert.AreEqual(module.SolveDebug(), "C");
            streamWriter.Close();
        }

    }
}
