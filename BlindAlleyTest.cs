using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/lfa#file=a91d428b68660c77dad939e15e8be8964763509c

    [TestClass]
    public class BlindAlleyTest
    {
        

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() {
            new Plate(false, false, false, true, true, true),
            new Plate(false, true, false, true, true, false),
            new Plate(false, false, false, false, false, false)

             });

            BlindAlley module = new BlindAlley(bomb, io);

            Assert.AreEqual("Bottom Right", module.Solve());

            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "EF5KE0", 6, 3,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() {
            new Plate(false, true, false, true, false, true)

             });

            BlindAlley module = new BlindAlley(bomb, io);

            Assert.AreEqual("Top Middle", module.Solve());

            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "P79IE1", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", true, true),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", true, false),
             new Indicator("SND", true, false), new Indicator("TRN", false, false),
             new List<Plate>() {
            new Plate(false, false, false, false, true, false),
            new Plate(false, true, false, true, false, true)

             });

            BlindAlley module = new BlindAlley(bomb, io);

            Assert.AreEqual("Middle", module.Solve());

            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "795MT1", 0, 0,
             new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() {
            new Plate(false, false, false, true, false, false),
            new Plate(false, true, false, true, false, true),
            new Plate(true, false, true, false, false, false)

             });

            BlindAlley module = new BlindAlley(bomb, io);

            Assert.AreEqual("Middle Right", module.Solve());

            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "NK8NM6", 4, 2,
             new Indicator("BOB", true, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() {
            new Plate(false, false, false, false, false, false)

             });

            BlindAlley module = new BlindAlley(bomb, io);

            Assert.AreEqual("Top Left", module.Solve());

            io.Close();
        }
    }
}