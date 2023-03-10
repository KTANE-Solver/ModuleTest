using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace ModuleTest
{


    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=3f7ff4864ea036bb23e17ec08e8d2bffafc40e04;bomb=Z49EN6


    [TestClass]
    public class SillySlotsTest
    {
        Bomb bomb = new Bomb(Day.Sunday, "6K2EN0", 2, 1,
         new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", true, true),
         new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", true, true),
         new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
         new Indicator("SND", false, false), new Indicator("TRN", false, false),
         new List<Plate>() { new Plate(false, false, false, false, false, false),
                             new Plate(false, false, false, false, false, false)}
);
        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Test1()
        {
            SillySlots.Slot s1 = new SillySlots.Slot("Green", "Cherry");
            SillySlots.Slot s2 = new SillySlots.Slot("Green", "Grape");
            SillySlots.Slot s3 = new SillySlots.Slot("Red", "Coin");

            SillySlots module = new SillySlots("Sassy", s1, s2, s3, io);

            bool answer = module.Solve(1);
            io.Close();
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void Test2()
        {
            SillySlots.Slot stage1S1 = new SillySlots.Slot("Red", "Coin");
            SillySlots.Slot stage1S2 = new SillySlots.Slot("Red", "Bomb");
            SillySlots.Slot stage1S3 = new SillySlots.Slot("Green", "Coin");

            SillySlots.Slot stage2S1 = new SillySlots.Slot("Red", "Grape");
            SillySlots.Slot stage2S2 = new SillySlots.Slot("Green", "Bomb");
            SillySlots.Slot stage2S3 = new SillySlots.Slot("Blue", "Coin");

            SillySlots.Slot stage3S1 = new SillySlots.Slot("Red", "Grape");
            SillySlots.Slot stage3S2 = new SillySlots.Slot("Blue", "Bomb");
            SillySlots.Slot stage3S3 = new SillySlots.Slot("Green", "Cherry");

            SillySlots.Slot stage4S1 = new SillySlots.Slot("Blue", "Bomb");
            SillySlots.Slot stage4S2 = new SillySlots.Slot("Green", "Bomb");
            SillySlots.Slot stage4S3 = new SillySlots.Slot("Red", "Bomb");

            SillySlots module = new SillySlots("Steven", stage1S1, stage1S2, stage1S3, io);

            bool stage1Answer = module.Solve(1);

            module.UpdateModule(2, "Sassy", stage2S1, stage2S2, stage2S3);
            
            bool stage2Answer = module.Solve(2);

            module.UpdateModule(3, "Soggy", stage3S1, stage3S2, stage3S3);
            
            bool stage3Answer = module.Solve(3);

            module.UpdateModule(4, "Silly", stage4S1, stage4S2, stage4S3);

            bool stage4Answer = module.Solve(4);

            io.Close();

            Assert.IsFalse(stage1Answer);
            Assert.IsFalse(stage2Answer);
            Assert.IsFalse(stage3Answer);
            Assert.IsFalse(stage4Answer);
        }

        [TestMethod]
        public void Test3()
        {
            SillySlots.Slot stage1S1 = new SillySlots.Slot("Blue", "Coin");
            SillySlots.Slot stage1S2 = new SillySlots.Slot("Green", "Coin");
            SillySlots.Slot stage1S3 = new SillySlots.Slot("Green", "Grape");

            SillySlots.Slot stage2S1 = new SillySlots.Slot("Red", "Cherry");
            SillySlots.Slot stage2S2 = new SillySlots.Slot("Red", "Grape");
            SillySlots.Slot stage2S3 = new SillySlots.Slot("Red", "Bomb");

            SillySlots.Slot stage3S1 = new SillySlots.Slot("Green", "Grape");
            SillySlots.Slot stage3S2 = new SillySlots.Slot("Blue", "Coin");
            SillySlots.Slot stage3S3 = new SillySlots.Slot("Blue", "Grape");

            SillySlots.Slot stage4S1 = new SillySlots.Slot("Red", "Bomb");
            SillySlots.Slot stage4S2 = new SillySlots.Slot("Green", "Grape");
            SillySlots.Slot stage4S3 = new SillySlots.Slot("Red", "Bomb");

            SillySlots module = new SillySlots("Silly", stage1S1, stage1S2, stage1S3, io);

            bool stage1Answer = module.Solve(1);

            module.UpdateModule(2, "Soggy", stage2S1, stage2S2, stage2S3);

            bool stage2Answer = module.Solve(2);

            module.UpdateModule(3, "Sally", stage3S1, stage3S2, stage3S3);
            
            bool stage3Answer = module.Solve(3);

            module.UpdateModule(4, "Sausage", stage4S1, stage4S2, stage4S3);

            bool stage4Answer = module.Solve(4);

            io.Close();

            Assert.IsFalse(stage1Answer);
            Assert.IsFalse(stage2Answer);
            Assert.IsFalse(stage3Answer);
            Assert.IsTrue(stage4Answer);
        }

        [TestMethod]
        public void Test4()
        {
            SillySlots.Slot stage1S1 = new SillySlots.Slot("Red", "Coin");
            SillySlots.Slot stage1S2 = new SillySlots.Slot("Red", "Cherry");
            SillySlots.Slot stage1S3 = new SillySlots.Slot("Blue", "Coin");

            SillySlots.Slot stage2S1 = new SillySlots.Slot("Green", "Grape");
            SillySlots.Slot stage2S2 = new SillySlots.Slot("Blue", "Bomb");
            SillySlots.Slot stage2S3 = new SillySlots.Slot("Green", "Grape");

            SillySlots.Slot stage3S1 = new SillySlots.Slot("Green", "Coin");
            SillySlots.Slot stage3S2 = new SillySlots.Slot("Red", "Bomb");
            SillySlots.Slot stage3S3 = new SillySlots.Slot("Blue", "Grape");

            SillySlots.Slot stage4S1 = new SillySlots.Slot("Red", "Bomb");
            SillySlots.Slot stage4S2 = new SillySlots.Slot("Blue", "Cherry");
            SillySlots.Slot stage4S3 = new SillySlots.Slot("Green", "Bomb");

            SillySlots module = new SillySlots("Sassy", stage1S1, stage1S2, stage1S3, io);

            bool stage1Answer = module.Solve(1);

            module.UpdateModule(2, "Soggy", stage2S1, stage2S2, stage2S3);

            bool stage2Answer = module.Solve(2);

            module.UpdateModule(3, "Steven", stage3S1, stage3S2, stage3S3);

            bool stage3Answer = module.Solve(3);

            module.UpdateModule(4, "Silly", stage4S1, stage4S2, stage4S3);

            bool stage4Answer = module.Solve(4);

            io.Close();

            Assert.IsFalse(stage1Answer);
            Assert.IsFalse(stage2Answer);
            Assert.IsFalse(stage3Answer);
            Assert.IsTrue(stage4Answer);
        }

        [TestMethod]
        public void Test5()
        {
            SillySlots.Slot stage1S1 = new SillySlots.Slot("Red", "Grape");
            SillySlots.Slot stage1S2 = new SillySlots.Slot("Green", "Bomb");
            SillySlots.Slot stage1S3 = new SillySlots.Slot("Green", "Bomb");

            SillySlots.Slot stage2S1 = new SillySlots.Slot("Blue", "Coin");
            SillySlots.Slot stage2S2 = new SillySlots.Slot("Green", "Cherry");
            SillySlots.Slot stage2S3 = new SillySlots.Slot("Blue", "Bomb");

            SillySlots.Slot stage3S1 = new SillySlots.Slot("Blue", "Cherry");
            SillySlots.Slot stage3S2 = new SillySlots.Slot("Green", "Cherry");
            SillySlots.Slot stage3S3 = new SillySlots.Slot("Green", "Cherry");

            SillySlots module = new SillySlots("Silly", stage1S1, stage1S2, stage1S3, io);

            bool stage1Answer = module.Solve(1);

            module.UpdateModule(2, "Silly", stage2S1, stage2S2, stage2S3);

            bool stage2Answer = module.Solve(2);

            module.UpdateModule(3, "Soggy", stage3S1, stage3S2, stage3S3);

            bool stage3Answer = module.Solve(3);

            io.Close();

            Assert.IsFalse(stage1Answer);
            Assert.IsFalse(stage2Answer);
            Assert.IsTrue(stage3Answer);
        }
    }
}