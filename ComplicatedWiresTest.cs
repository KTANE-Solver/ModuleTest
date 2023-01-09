using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class ComplicatedWiresTest
    {
        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=65a44f5a2fcaa5759c4760c4ad51ba765387ae18;bomb=NB3PU8


        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "NB3PU8", 1, 1,
        new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
        new Indicator("MSA", true, true), new Indicator("NSA", true, true), new Indicator("SIG", true, true),
        new Indicator("SND", false, false), new Indicator("TRN", false, false), new List<Plate>()
        );

        [TestMethod]
        public void Test1()
        {
            List<ComplicatedWire> list = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Purple, false, true),
                new ComplicatedWire(Color.White, true, false)

            };
            ComplicatedWires module = new ComplicatedWires(list, bomb, io);


            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Cut", answer);
        }

        [TestMethod]
        public void Test2()
        {
            List<ComplicatedWire> list = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Purple, false, true),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Red, false, true),


            };
            ComplicatedWires module = new ComplicatedWires(list, bomb, io);


            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1. Cut\n2. Cut\n3. Don't Cut\n4. Cut\n5. Don't Cut\n6. Don't Cut", answer);
        }

        [TestMethod]
        public void Test3()
        {
            List<ComplicatedWire> list = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Blue, true, false),

            };
            ComplicatedWires module = new ComplicatedWires(list, bomb, io);


            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Cut\n4. Don't Cut\n5. Don't Cut", answer);
        }

        [TestMethod]
        public void Test4()
        {
            List<ComplicatedWire> list = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Blue, false, true),

            };
            ComplicatedWires module = new ComplicatedWires(list, bomb, io);


            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Don't Cut\n5. Don't Cut", answer);
        }

        [TestMethod]
        public void Test5()
        {
            List<ComplicatedWire> list = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Red, true, false),



            };
            ComplicatedWires module = new ComplicatedWires(list, bomb, io);


            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Don't Cut\n4. Cut", answer);
        }


    }
}
