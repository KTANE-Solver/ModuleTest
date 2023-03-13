using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
namespace ModuleTest
{
    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=6c3b0e75524aa6af8fefb1593bf1da06acf4209e;bomb=HH6IF1

    

    [TestClass]
    public class PokerTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "HH6IF1", 2, 2,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() { 
             new Plate(false, false, true, false, false, false),
             new Plate(false, false, false, false, true, false)
             });

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            Poker module = new Poker(bomb, io, "FIVE");
            Poker.Card.Suite[] cards = { 
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND };
        
            module.response = "Terrible play!";

            string stage1Answer = module.GetStage1Answer(true);
            string stage2Answer = module.BluffTruth(true);
            string stage3Answer = module.CardAnswer(50, cards, true);
           
            
            io.Close();

            Assert.AreEqual("Check", stage1Answer);
            Assert.AreEqual("Truth", stage2Answer);
            Assert.AreEqual("Card 3", stage3Answer);
        }

        [TestMethod]
        public void Test2()
        {
            Poker module = new Poker(bomb, io, "KING");
            Poker.Card.Suite[] cards = {
                 Poker.Card.Suite.HEART,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND };

            module.response = "Terrible play";

            string stage1Answer = module.GetStage1Answer(true);
            string stage2Answer = module.BluffTruth(true);
            string stage3Answer = module.CardAnswer(100, cards, true);


            io.Close();

            Assert.AreEqual("Max Raise", stage1Answer);
            Assert.AreEqual("Truth", stage2Answer);
            Assert.AreEqual("Card 4", stage3Answer);
        }

        [TestMethod]
        public void Test3()
        {
            Poker module = new Poker(bomb, io, "ACE");
            Poker.Card.Suite[] cards = {
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND };

            module.response = "Sure about that?";

            string stage1Answer = module.GetStage1Answer(true);
            string stage2Answer = module.BluffTruth(true);
            string stage3Answer = module.CardAnswer(100, cards, true);


            io.Close();

            Assert.AreEqual("Max Raise", stage1Answer);
            Assert.AreEqual("Truth", stage2Answer);
            Assert.AreEqual("Card 3", stage3Answer);
        }

        [TestMethod]
        public void Test4()
        {
            Poker module = new Poker(bomb, io, "KING");
            Poker.Card.Suite[] cards = {
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND,
                 Poker.Card.Suite.DIAMOND };

            module.response = "Sure about that?";

            string stage1Answer = module.GetStage1Answer(true);
            string stage2Answer = module.BluffTruth(true);
            string stage3Answer = module.CardAnswer(100, cards, true);


            io.Close();

            Assert.AreEqual("Max Raise", stage1Answer);
            Assert.AreEqual("Bluff", stage2Answer);
            Assert.AreEqual("Card 3", stage3Answer);
        }

        [TestMethod]
        public void Test5()
        {
            Poker module = new Poker(bomb, io, "KING");
            Poker.Card.Suite[] cards = {
                 Poker.Card.Suite.CLUB,
                 Poker.Card.Suite.CLUB,
                 Poker.Card.Suite.CLUB,
                 Poker.Card.Suite.CLUB};

            module.response = "Sure about that?";

            string stage1Answer = module.GetStage1Answer(true);
            string stage2Answer = module.BluffTruth(true);
            string stage3Answer = module.CardAnswer(100, cards, true);


            io.Close();

            Assert.AreEqual("Max Raise", stage1Answer);
            Assert.AreEqual("Bluff", stage2Answer);
            Assert.AreEqual("Card 2", stage3Answer);
        }

    }
}