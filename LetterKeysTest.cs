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

        Bomb bomb = null;
        
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
