using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    [TestClass]
    public class _3DMazeTest
    {
        //https://bit.ly/3ATPjaM

        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "IN6HE3", 0, 0,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", true, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 1), new Port("Parallel", 0), new Port("ps", 0),
            new Port("rj", 1), new Port("serial", 0), new Port("setero", 0));

        [TestMethod]
        public void BCD_South_Test()
        {
            _3DMaze module = new _3DMaze(bomb, io);

            //finds correct cardinal space

            //finds correct wall to run into



            //Assert.AreEqual(holdAnswer, module.Solve(Color.Blue, "Abort"));

            io.Close();
        }
    }
}