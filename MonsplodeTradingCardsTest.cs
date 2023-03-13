using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Formats.Asn1;

namespace ModuleTest
{
    [TestClass]
    public class MonsplodeTradingCardsTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=f25dfa06904e9be3c5628b2b356da06483d4ee64;bomb=RV4BK2

        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "RV4BK2", 2, 2,
        new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
        new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
{
            new Plate(true, false, false, false, false, false),
            new Plate(false, true, false, false, false, false),
            new Plate(false, true, false, true, false, true),});

        [TestMethod]
        public void Test1()
        {
            MonsplodeTradingCard.Card card1 = new MonsplodeTradingCard.Card("Melbor, The Web Bug", "C4",MonsplodeTradingCard.Card.Rarity.Uncommon,true,1, bomb);
            MonsplodeTradingCard.Card card2 = new MonsplodeTradingCard.Card("Magmy", "B4",MonsplodeTradingCard.Card.Rarity.Uncommon,false,1, bomb);
            MonsplodeTradingCard.Card card3 = new MonsplodeTradingCard.Card("Mountoise", "C4", MonsplodeTradingCard.Card.Rarity.Common, false, 1, bomb);

            MonsplodeTradingCard.Card offeringCard1 = new MonsplodeTradingCard.Card("Lugirit", "H2", MonsplodeTradingCard.Card.Rarity.Ultra, false, 0, bomb);
            MonsplodeTradingCard.Card offeringCard2 = new MonsplodeTradingCard.Card("Lanaluff", "H1", MonsplodeTradingCard.Card.Rarity.Common, false, 1, bomb);
            MonsplodeTradingCard.Card offeringCard3 = new MonsplodeTradingCard.Card("Melbor, The Web Bug", "H1", MonsplodeTradingCard.Card.Rarity.Ultra, false, 0, bomb);


            MonsplodeTradingCard module = new MonsplodeTradingCard(bomb, io, card1, card2, card3);

            string answer1 = module.Solve(offeringCard1, true);
            string answer2 = module.Solve(offeringCard2, true);
            string answer3 = module.Solve(offeringCard3, true);

            io.Close();

            Assert.AreEqual("Trade Card 3 (Mountoise)", answer1);
            Assert.AreEqual("Press Keep", answer2);
            Assert.AreEqual("Trade Card 2 (Magmy)", answer3);
        }


        [TestMethod]
        public void Test2()
        {
            MonsplodeTradingCard.Card card1 = new MonsplodeTradingCard.Card("Lugirit", "G4", MonsplodeTradingCard.Card.Rarity.Ultra, true, 2, bomb);
            MonsplodeTradingCard.Card card2 = new MonsplodeTradingCard.Card("Bob, The Ancestor", "C4", MonsplodeTradingCard.Card.Rarity.Rare, false, 1, bomb);
            MonsplodeTradingCard.Card card3 = new MonsplodeTradingCard.Card("Flaurim", "G4", MonsplodeTradingCard.Card.Rarity.Uncommon, false, 1, bomb);

            MonsplodeTradingCard.Card offeringCard1 = new MonsplodeTradingCard.Card("Lugirit", "E2", MonsplodeTradingCard.Card.Rarity.Rare, true, 0, bomb);
            MonsplodeTradingCard.Card offeringCard2 = new MonsplodeTradingCard.Card("Myrchat", "E2", MonsplodeTradingCard.Card.Rarity.Uncommon, false, 0, bomb);
            MonsplodeTradingCard.Card offeringCard3 = new MonsplodeTradingCard.Card("Lugirit", "C4", MonsplodeTradingCard.Card.Rarity.Ultra, true, 0, bomb);


            MonsplodeTradingCard module = new MonsplodeTradingCard(bomb, io, card1, card2, card3);

            string answer1 = module.Solve(offeringCard1, true);
            string answer2 = module.Solve(offeringCard2, true);
            string answer3 = module.Solve(offeringCard3, true);

            io.Close();

            Assert.AreEqual("Trade Card 3 (Flaurim)", answer1);
            Assert.AreEqual("Press Keep", answer2);
            Assert.AreEqual("Trade Card 1 (Lugirit)", answer3);
        }

        [TestMethod]
        public void Test3()
        {
            MonsplodeTradingCard.Card card1 = new MonsplodeTradingCard.Card("Violan", "H4", MonsplodeTradingCard.Card.Rarity.Rare, false, 0, bomb);
            MonsplodeTradingCard.Card card2 = new MonsplodeTradingCard.Card("Zapra", "I9", MonsplodeTradingCard.Card.Rarity.Ultra, false, 0, bomb);
            MonsplodeTradingCard.Card card3 = new MonsplodeTradingCard.Card("Zenlad", "G4", MonsplodeTradingCard.Card.Rarity.Common, false, 1, bomb);

            MonsplodeTradingCard.Card offeringCard1 = new MonsplodeTradingCard.Card("Nibs", "A4", MonsplodeTradingCard.Card.Rarity.Common, false, 1, bomb);
            MonsplodeTradingCard.Card offeringCard2 = new MonsplodeTradingCard.Card("Flaurim", "F4", MonsplodeTradingCard.Card.Rarity.Common, false, 2, bomb);
            MonsplodeTradingCard.Card offeringCard3 = new MonsplodeTradingCard.Card("Asteran", "A4", MonsplodeTradingCard.Card.Rarity.Rare, true, 1, bomb);


            MonsplodeTradingCard module = new MonsplodeTradingCard(bomb, io, card1, card2, card3);

            string answer1 = module.Solve(offeringCard1, true);
            string answer2 = module.Solve(offeringCard2, true);
            string answer3 = module.Solve(offeringCard3, true);

            io.Close();

            Assert.AreEqual("Trade Card 2 (Zapra)", answer1);
            Assert.AreEqual("Press Keep", answer2);
            Assert.AreEqual("Trade Card 2 (Nibs)", answer3);
        }

        [TestMethod]
        public void Test4()
        {
            MonsplodeTradingCard.Card card1 = new MonsplodeTradingCard.Card("Cutie Pie", "E2", MonsplodeTradingCard.Card.Rarity.Ultra, true, 1, bomb);
            MonsplodeTradingCard.Card card2 = new MonsplodeTradingCard.Card("Bob", "H4", MonsplodeTradingCard.Card.Rarity.Ultra, true, 0, bomb);
            MonsplodeTradingCard.Card card3 = new MonsplodeTradingCard.Card("Flaurim", "G2", MonsplodeTradingCard.Card.Rarity.Rare, false, 0, bomb);

            MonsplodeTradingCard.Card offeringCard1 = new MonsplodeTradingCard.Card("Zenlad", "A4", MonsplodeTradingCard.Card.Rarity.Uncommon, true, 2, bomb);
            MonsplodeTradingCard.Card offeringCard2 = new MonsplodeTradingCard.Card("Pouse", "F4", MonsplodeTradingCard.Card.Rarity.Uncommon, false, 2, bomb);
            MonsplodeTradingCard.Card offeringCard3 = new MonsplodeTradingCard.Card("Lugirit", "A4", MonsplodeTradingCard.Card.Rarity.Ultra, false, 1, bomb);


            MonsplodeTradingCard module = new MonsplodeTradingCard(bomb, io, card1, card2, card3);

            string answer1 = module.Solve(offeringCard1, true);
            string answer2 = module.Solve(offeringCard2, true);
            string answer3 = module.Solve(offeringCard3, true);

            io.Close();

            Assert.AreEqual("Trade Card 3 (Flaurim)", answer1);
            Assert.AreEqual("Press Keep", answer2);
            Assert.AreEqual("Press Keep", answer3);
        }

        [TestMethod]
        public void Test5()
        {
            MonsplodeTradingCard.Card card1 = new MonsplodeTradingCard.Card("Buhar, The Protector", "E4", MonsplodeTradingCard.Card.Rarity.Rare, false, 1, bomb);
            MonsplodeTradingCard.Card card2 = new MonsplodeTradingCard.Card("Lugirit", "H4", MonsplodeTradingCard.Card.Rarity.Uncommon, false, 0, bomb);
            MonsplodeTradingCard.Card card3 = new MonsplodeTradingCard.Card("Aluga", "G2", MonsplodeTradingCard.Card.Rarity.Rare, false, 0, bomb);

            MonsplodeTradingCard.Card offeringCard1 = new MonsplodeTradingCard.Card("Melbor, The Web Bug", "A4", MonsplodeTradingCard.Card.Rarity.Ultra, false, 3, bomb);
            MonsplodeTradingCard.Card offeringCard2 = new MonsplodeTradingCard.Card("Docsplode", "F2", MonsplodeTradingCard.Card.Rarity.Ultra, false, 0, bomb);
            MonsplodeTradingCard.Card offeringCard3 = new MonsplodeTradingCard.Card("Bob, The Ancestor", "A4", MonsplodeTradingCard.Card.Rarity.Ultra, false, 1, bomb);


            MonsplodeTradingCard module = new MonsplodeTradingCard(bomb, io, card1, card2, card3);

            string answer1 = module.Solve(offeringCard1, true);
            string answer2 = module.Solve(offeringCard2, true);
            string answer3 = module.Solve(offeringCard3, true);

            io.Close();

            Assert.AreEqual("Press Keep", answer1);
            Assert.AreEqual("Trade Card 2 (Lugirit)", answer2);
            Assert.AreEqual("Trade Card 3 (Aluga)", answer3);
        }



    }



}