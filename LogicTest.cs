using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTest
{
    //https://ktane.timwi.de/lfa#file=1c5e8afec1479c495dee626a21f040d55766ce95

    

    [TestClass]
    public class LogicTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "5N0PW2", 6, 4,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", true, true),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>());

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            Logic module = new Logic(bomb, false, 'S', true, 'C', true, 'Q', "|", "∧", false,
                                           true, 'C', false, 'I', false, 'G', "↓", "↔", false, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("TRUE TRUE",answer);

        }

        [TestMethod]
        public void Test2()
        {
            Logic module = new Logic(bomb, false, 'B', false, 'F', true, 'Q', "|", "⊻", true,
                                           true, 'E', false, 'I', true, 'Q', "∨", "↔", true, io);

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("FALSE TRUE", answer);

        }

        [TestMethod]
        public void Test3()
        {
            Logic module = new Logic(bomb, false, 'O', false, 'Q', false, 'W', "↔", "∧", true,
                                           false, 'C', true, 'W', false, 'L', "→", "←", true, io); ;

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("FALSE TRUE", answer);

        }

        [TestMethod]
        public void Test4()
        {
            Logic module = new Logic(bomb, false, 'F', false, 'O', false, 'Y', "⊻", "⊻", true,
                                           true, 'B', true, 'I', false, 'G', "⊻", "∧", false, io); ;

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("FALSE FALSE", answer);

        }

        [TestMethod]
        public void Test5()
        {
            Logic module = new Logic(bomb, false, 'E', true, 'L', true, 'Y', "⊻", "⊻", false,
                                           true, 'D', false, 'P', false, 'G', "|", "↔", false, io); ;

            string answer = module.Solve(true);
            io.Close();

            Assert.AreEqual("FALSE TRUE", answer);

        }
    }
}