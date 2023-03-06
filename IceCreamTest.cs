using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class IceCreamTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=7d070bbc58af457604d6444989aa0fba1ac6c4ba;bomb=3G3SK3

        StreamWriter io = new StreamWriter("dummy.txt");


        Bomb bomb = new Bomb(Day.Sunday, "3G3SK3", 3, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", true, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        {
            new Plate(true, false, false, false, false, false),
            new Plate(false, false, false, true, false, false) });

        [TestMethod]
        public void Test1()
        {
            IceCream i = new IceCream("Gary", "Neapolitan", "Mint Chocolate Chip", "Cookies and Cream", "Raspberry Ripple", bomb, io);
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("Cookies and Cream", answer);
        }

        [TestMethod]
        public void Test2()
        {
            IceCream i = new IceCream("Cheryl", "Raspberry Ripple", "Cookies and Cream", "Rocky Road", "Tutti Frutti", bomb, io);
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("Cookies and Cream", answer);
        }

        [TestMethod]
        public void Test3()
        {
            IceCream i = new IceCream("Tim", "Raspberry Ripple", "The Classic", "Neapolitan", "Cookies and Cream", bomb, io);
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("The Classic", answer);
        }

        [TestMethod]
        public void Test4()
        {
            IceCream i = new IceCream("Jessica", "Cookies and Cream", "Double Strawberry", "Neapolitan", "Raspberry Ripple", bomb, io);
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("Cookies and Cream", answer);
        }

        [TestMethod]
        public void Test5()
        {
            IceCream i = new IceCream("Simon", "Double Chocolate", "Tutti Frutti", "Double Strawberry", "Rocky Road", bomb, io);
            string answer = i.Solve(true);
            io.Close();
            Assert.AreEqual("Double Chocolate", answer);
        }
    }
}