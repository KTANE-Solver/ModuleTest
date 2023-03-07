using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=e99ac35350a6c2018f84c407a33fdcd41579a86f;bomb=BA5EE1


    [TestClass]
    public class MurderTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "BA5EE1", 3, 3,
             new Indicator("BOB", false, false), new Indicator("CAR", true, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() { new Plate(false, false, true, false, false, false) }
            );

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            Murder module = new Murder(new string[] { "Green", "Scarlett", "Peacock", "White" },
                                       new string[] { "Candle Stick", "Dagger", "Lead Pipe", "Revolver" }, "Library",bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Peacock with the Candle Stick in the Library", answer);
        }

        [TestMethod]
        public void Test2()
        {
            Murder module = new Murder(new string[] { "Green", "Plum", "Peacock", "White" },
                                       new string[] { "Candle Stick", "Rope", "Lead Pipe", "Revolverd" }, "Dining Room", bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Green with the Pipe in the Hall", answer);
        }

        [TestMethod]
        public void Test3()
        {
            Murder module = new Murder(new string[] { "Green", "Plum", "Mustard", "White" },
                                       new string[] { "Candle Stick", "Rope", "Dagger", "Spanner" }, "Study", bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Plum with the Rope in the Ballroom", answer);
        }

        [TestMethod]
        public void Test4()
        {
            Murder module = new Murder(new string[] { "Green", "Plum", "Peacock", "White" },
                                       new string[] { "Revolver", "Lead Pipe", "Dagger", "Spanner" }, "Dining Room", bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Green with the Pipe in the Hall", answer);
        }

        [TestMethod]
        public void Test5()
        {
            Murder module = new Murder(new string[] { "Green", "Plum", "Peacock", "White" },
                                       new string[] { "Revolver", "Lead Pipe", "Dagger", "Rope" }, "Dining Room", bomb, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("Green with the Pipe in the Hall", answer);
        }

    }
}