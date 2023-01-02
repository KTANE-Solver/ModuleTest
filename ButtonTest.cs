using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class ButtonTest
    {

        StreamWriter io = new StreamWriter("dummy.txt");

        string holdAnswer = "Hold Button\nBlue: 4\nYellow: 5\nElse: 1";

        [TestMethod]
        public void BlueAbort()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() {
             });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Blue, "Abort", true));

            io.Close();
        }

        [TestMethod]
        public void Detonate1Battery()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>()
             {
             });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.Blue, "Detonate", true));

            io.Close();
        }

        [TestMethod]
        public void WhiteLitCar()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 1, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>()
             {
             });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.White, "Abort", true));

            io.Close();
        }

        [TestMethod]
        public void LitFRK2Battery()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 3, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false),
            new List<Plate>()
            {
            });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.White, "Abort", true));

            io.Close();
        }

        [TestMethod]
        public void Yellow()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 3, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false),
            new List<Plate>()
            {
            });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Yellow, "Abort", true));

            io.Close();
        }

        [TestMethod]
        public void RedHold()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 3, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false),
            new List<Plate>()
            {
            });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.Red, "Hold", true));

            io.Close();
        }

        [TestMethod]
        public void Other()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A33WG2", 3, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false),
            new List<Plate>()
            {
            });

            New_KTANE_Solver.Button module = new New_KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Red, "Abort", true));

            io.Close();
        }
    }
}