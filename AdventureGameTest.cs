using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class AdventureGameTest
    {
        //https://ktane.timwi.de/lfa#file=90f0a6d56e9477ae97f1e17ffea79de49dac6390

        StreamWriter io = new StreamWriter("dummy.txt");


        Bomb bomb = new Bomb(Day.Sunday, "A39QH2", 2, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", true, false), new Indicator("IND", true, true),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(false, false, true, false, false, false),
            new Plate(true, false, false, false, false, false) });

        [TestMethod]
        public void Test1()
        {
            AdventureGame.Item item1 = AdventureGame.Item.BELLOWS;
            AdventureGame.Item item2 = AdventureGame.Item.SMALLDOG;
            AdventureGame.Item item3 = AdventureGame.Item.LAMP;
            AdventureGame.Item item4 = AdventureGame.Item.FEATHER;
            AdventureGame.Item item5 = AdventureGame.Item.STEPLADDER;

            AdventureGame module = new AdventureGame(9, 8, 1, 67, 23, 10, 95, 
                                                    "NASTY KNIFE", "LONGBOW", " MAGIC ORB", 
                                                    item1, item2, item3, item4, item5, 
                                                    "LIZARD", bomb, io);

            string[] answer = module.Solve(true).Split('\n');

            Assert.IsTrue(answer.Contains("LONGBOW"));
            Assert.IsTrue(answer.Contains(item2.ToString()));
            Assert.IsTrue(answer.Contains(item4.ToString()));

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            AdventureGame.Item item1 = AdventureGame.Item.BALLOON;
            AdventureGame.Item item2 = AdventureGame.Item.CHEATCODE;
            AdventureGame.Item item3 = AdventureGame.Item.STEPLADDER;
            AdventureGame.Item item4 = AdventureGame.Item.MOONSTONE;
            AdventureGame.Item item5 = AdventureGame.Item.LAMP;

            AdventureGame module = new AdventureGame(10, 9, 10, 41, 43, 10.4, 93,
                                                    "NASTY KNIFE", "LONGBOW", "GRIMOIRE",
                                                    item1, item2, item3, item4, item5,
                                                    "TROLL", bomb, io);

            string[] answer = module.Solve(true).Split('\n');

            Assert.IsTrue(answer.Contains("GRIMOIRE"));
            Assert.IsTrue(answer.Contains(item3.ToString()));

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            AdventureGame.Item item1 = AdventureGame.Item.SMALLDOG;
            AdventureGame.Item item2 = AdventureGame.Item.BELLOWS;
            AdventureGame.Item item3 = AdventureGame.Item.BALLOON;
            AdventureGame.Item item4 = AdventureGame.Item.FEATHER;
            AdventureGame.Item item5 = AdventureGame.Item.SYMBOL;

            AdventureGame module = new AdventureGame(7, 6, 3, 50, 45, 10.2, 104,
                                                    "CABER", "BROADSWORD", "GRIMOIRE",
                                                    item1, item2, item3, item4, item5,
                                                    "LIZARD", bomb, io);

            string[] answer = module.Solve(true).Split('\n');

            Assert.IsTrue(answer.Contains("CABER"));
            Assert.IsTrue(answer.Contains(item1.ToString()));
            Assert.IsTrue(answer.Contains(item4.ToString()));
            Assert.IsTrue(answer.Contains(item5.ToString()));

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            AdventureGame.Item item1 = AdventureGame.Item.SYMBOL;
            AdventureGame.Item item2 = AdventureGame.Item.SMALLDOG;
            AdventureGame.Item item3 = AdventureGame.Item.CHEATCODE;
            AdventureGame.Item item4 = AdventureGame.Item.BATTERY;
            AdventureGame.Item item5 = AdventureGame.Item.POTION;

            AdventureGame module = new AdventureGame(1, 10, 3, 53, 0, 10.4, 100,
                                                    "NASTY KNIFE", "CABER", "BROADSWORD",
                                                    item1, item2, item3, item4, item5,
                                                    "EAGLE", bomb, io);

            string[] answer = module.Solve(true).Split('\n');

            Assert.IsTrue(answer.Contains("NASTY KNIFE"));
            Assert.IsTrue(answer.Contains(item2.ToString()));

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            AdventureGame.Item item1 = AdventureGame.Item.CRYSTALBALL;
            AdventureGame.Item item2 = AdventureGame.Item.HARDDRIVE;
            AdventureGame.Item item3 = AdventureGame.Item.LAMP;
            AdventureGame.Item item4 = AdventureGame.Item.BELLOWS;
            AdventureGame.Item item5 = AdventureGame.Item.FEATHER;

            AdventureGame module = new AdventureGame(1, 2, 8, 44, 8, 9.7, 107,
                                                    "MAGIC ORB", "LONGBOW", "GRIMOIRE",
                                                    item1, item2, item3, item4, item5,
                                                    "DEMON", bomb, io);

            string[] answer = module.Solve(true).Split('\n');

            Assert.IsTrue(answer.Contains("GRIMOIRE"));
            Assert.IsTrue(answer.Contains(item1.ToString()));
            Assert.IsTrue(answer.Contains(item3.ToString()));
            Assert.IsTrue(answer.Contains(item5.ToString()));

            io.Close();
        }
    }
}