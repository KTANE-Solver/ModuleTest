using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;
using static New_KTANE_Solver.CheapCheckout.ItemName;

namespace ModuleTest
{
    [TestClass]
    public class CheapCheckoutTest
    {

        StreamWriter io = new StreamWriter("dummy.txt");


        #region Sunday Tests
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=2c1616c693ef328d1c00d404f2e09de7236bf1f5;bomb=5B8HM7
        [TestMethod]
        public void Sunday1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GQ2EI1", 0, 0,
    new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
    new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
    new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
    new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
{
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true) });
            CheapCheckout module = new CheapCheckout(bomb, io, 19, ChocolateBar, CandyCanes, Honey, Deodorant, 1.5, Lemons, .5, Lettuce);

            decimal answer = module.Solve(true, 25);

            Assert.AreEqual(1.86m, answer);

            io.Close();
        }

        [TestMethod]
        public void Sunday2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GQ2EI1", 0, 0,
    new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
    new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
    new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
    new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
{
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true) });
            CheapCheckout module = new CheapCheckout(bomb, io, 12, Shampoo, Deodorant, Mayonnaise, Mustard, .5, Lettuce, .5, Bananas);

            decimal answer = module.Solve(true, 31);

            Assert.AreEqual(8.26m, answer);


            io.Close();
        }

        [TestMethod]
        public void Sunday3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GQ2EI1", 0, 0,
     new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
     new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
     new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
     new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
 {
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true) });
            CheapCheckout module = new CheapCheckout(bomb, io, 34, WhiteMilk, Tea, CoffeeBeans, FruitPunch, .5, Lemons, 1.5, Turkey);

            decimal answer = module.Solve(true, 34);

            Assert.AreEqual(10.61m, answer);

            io.Close();
        }

        [TestMethod]
        public void Sunday4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GQ2EI1", 0, 0,
    new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
    new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
    new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
    new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
{
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true) });
            CheapCheckout module = new CheapCheckout(bomb, io, 21, Soda, Cookies, CanolaOil, PeanutButter, .5, Turkey, .5, Steak);

            decimal answer = module.Solve(true, 21);

            Assert.AreEqual(1.39m, answer);

            io.Close();
        }

        [TestMethod]
        public void Sunday5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GQ2EI1", 0, 0,
     new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
     new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
     new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, true),
     new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
 {
            new Plate(false, false, false, false, false, false),
            new Plate(false, true, false, true, false, true) });
            CheapCheckout module = new CheapCheckout(bomb, io, 30, Mayonnaise, PastaSauce, Lollipops, PeanutButter, 1, Broccoli, .5, Lemons);

            decimal answer = module.Solve(true, 30);

            Assert.AreEqual(7.39m, answer);

            io.Close();
        }
        #endregion

        #region Monday Tests
        #endregion

        #region Tuesday Tests
        #endregion

        #region Wednesday Tests
        #endregion

        #region Thursday Tests
        #endregion

        #region Friday Tests
        #endregion

        #region Saturday Tests
        #endregion


    }
}