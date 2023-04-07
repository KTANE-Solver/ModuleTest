using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class LionShareTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=ec12263106488e1f2182a916efc8556909bbb688;bomb=MK5JA4


        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "MK5JA4", 1, 1,
        new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", true, true),
        new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
        new Indicator("SND", true, true), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(true, false, false, false, false, false),
            new Plate(false, false, true, false, false, false),

        });

        [TestMethod]
        public void Test1()
        {
            Dictionary<string, bool> names = new Dictionary<string, bool>() 
            { 
                {"AHADI", false }, 
                {"MOHATU", false},
                {"TOJO", false },
                {"URU", true },
                {"MUFASA", false },
            };

            LionShare module = new LionShare(1, names, bomb, io);

            string answer = module.Solve(true);


            
            io.Close();

            Assert.IsTrue(answer.Contains("AHADI: 23"));
            Assert.IsTrue(answer.Contains("MOHATU: 46"));
            Assert.IsTrue(answer.Contains("TOJO: 7"));
            Assert.IsTrue(answer.Contains("URU: 24"));
            Assert.IsTrue(answer.Contains("MUFASA: 0"));
        }

        [TestMethod]
        public void Test2()
        {
            Dictionary<string, bool> names = new Dictionary<string, bool>()
            {
                {"ASKARI", false },
                {"KION", false},
                {"MALKA", false },
                {"NALA", true },
                {"SIMBA", false },
                {"VITANI", false },
                {"MOHATU", false },

            };

            LionShare module = new LionShare(14, names, bomb, io);

            string answer = module.Solve(true);



            io.Close();

            Assert.IsTrue(answer.Contains("ASKARI: 7"));
            Assert.IsTrue(answer.Contains("KION: 9"));
            Assert.IsTrue(answer.Contains("MALKA: 9"));
            Assert.IsTrue(answer.Contains("NALA: 22"));
            Assert.IsTrue(answer.Contains("SIMBA: 39"));
            Assert.IsTrue(answer.Contains("VITANI: 14"));
            Assert.IsTrue(answer.Contains("MOHATU: 0"));

        }

        [TestMethod]
        public void Test3()
        {
            Dictionary<string, bool> names = new Dictionary<string, bool>()
            {
                {"KIARA", true },
                {"RANI", false},
                {"KOPA", false },
                {"SARAFINA", false },
                {"ZAMA", false },
            };

            LionShare module = new LionShare(15, names, bomb, io);

            string answer = module.Solve(true);

            io.Close();

            Assert.IsTrue(answer.Contains("KIARA: 78"));
            Assert.IsTrue(answer.Contains("RANI: 2"));
            Assert.IsTrue(answer.Contains("KOPA: 0"));
            Assert.IsTrue(answer.Contains("SARAFINA: 0"));
            Assert.IsTrue(answer.Contains("ZAMA: 0"));
        }

        [TestMethod]
        public void Test4()
        {
            Dictionary<string, bool> names = new Dictionary<string, bool>()
            {
                {"AHADI", false },
                {"MOHATU", false},
                {"MUFASA", false},
                {"SARABI", false },
                {"SARAFINA", false },
                {"SHEENA", false },
                {"ZAMA", true },
            };

            LionShare module = new LionShare(2, names, bomb, io);

            string answer = module.Solve(true);

            io.Close();

            Assert.IsTrue(answer.Contains("AHADI: 13"));
            Assert.IsTrue(answer.Contains("MOHATU: 27"));
            Assert.IsTrue(answer.Contains("MUFASA: 11"));
            Assert.IsTrue(answer.Contains("SARABI: 11"));
            Assert.IsTrue(answer.Contains("SHEENA: 6"));
            Assert.IsTrue(answer.Contains("ZAMA: 21"));
        }

        [TestMethod]
        public void Test5()
        {
            Dictionary<string, bool> names = new Dictionary<string, bool>()
            {
                {"CHUMVI", false },
                {"DIKU", false},
                {"MUFASA", false },
                {"SARABI", false },
                {"SARAFINA", false },
                {"URU", true },
                {"NALA", false },
            };

            LionShare module = new LionShare(5, names, bomb, io);

            string answer = module.Solve(true);

            io.Close();

            Assert.IsTrue(answer.Contains("CHUMVI: 5"));
            Assert.IsTrue(answer.Contains("DIKU: 10"));
            Assert.IsTrue(answer.Contains("MUFASA: 31"));
            Assert.IsTrue(answer.Contains("SARABI: 18"));
            Assert.IsTrue(answer.Contains("URU: 15"));
            Assert.IsTrue(answer.Contains("NALA: 0"));

        }

    }
}
