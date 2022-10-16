using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTest
{
    [TestClass]
    public class ChessTest
    {
        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "R03ST1", 3, 2,
          new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
          new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
          new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
          new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 0,
          new Port("DVID", 0), new Port("Parallel", 0), new Port("ps", 0),
          new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));


        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=d03654fe7736a07e87324889dc1a6d11f1c2aac3;bomb=R03ST1

        [TestMethod]
        public void Test1()
        {
            Chess module = new Chess("F3", "C4", "F5", "A1", "E3", "B2", bomb, io);

            Assert.AreEqual(module.Solve(true), "D6");

            io.Close();
        }

        [TestMethod]
        public void Test10()
        {
            Chess module = new Chess("E6", "E1", "B2", "F5", "B4", "D3", bomb, io);

            Assert.AreEqual(module.Solve(true), "C6");
            io.Close();
        }

        [TestMethod]
        public void Test100()
        {
            Chess module = new Chess("F4", "B1", "E4", "D6", "F2", "A3", bomb, io);

            Assert.AreEqual(module.Solve(true), "C4");
            io.Close();
        }

        [TestMethod]
        public void Test11()
        {
            Chess module = new Chess("F5", "F1", "C5", "A1", "C2", "E6", bomb, io);

            Assert.AreEqual(module.Solve(true), "E3");
            io.Close();
        }

        [TestMethod]
        public void Test12()
        {
            Chess module = new Chess("D4", "A2", "E5", "E3", "A1", "B4", bomb, io);

            Assert.AreEqual(module.Solve(true), "C6");
            io.Close();
        }

        [TestMethod]
        public void Test13()
        {
            Chess module = new Chess("C6", "F6", "D4", "C1", "C5", "B2", bomb, io);

            Assert.AreEqual(module.Solve(true), "A6");
            io.Close();
        }

        [TestMethod]
        public void Test14()
        {
            Chess module = new Chess("C3", "D5", "B2", "A6", "F1", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "E4");
            io.Close();
        }

        [TestMethod]
        public void Test15()
        {
            Chess module = new Chess("E6", "E1", "A5", "D3", "F6", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "B2");
            io.Close();
        }

        [TestMethod]
        public void Test16()
        {
            Chess module = new Chess("C2", "D2", "A3", "B6", "E5", "F1", bomb, io);

            Assert.AreEqual(module.Solve(true), "C3");
            io.Close();
        }

        [TestMethod]
        public void Test17()
        {
            Chess module = new Chess("B6", "F6", "F2", "C5", "D2", "A4", bomb, io);

            Assert.AreEqual(module.Solve(true), "B1");
            io.Close();
        }

        [TestMethod]
        public void Test18()
        {
            Chess module = new Chess("E3", "A5", "E5", "F4", "C3", "C2", bomb, io);

            Assert.AreEqual(module.Solve(true), "E1");
            io.Close();
        }

        [TestMethod]
        public void Test19()
        {
            Chess module = new Chess("D3", "D4", "D6", "F3", "C1", "A2", bomb, io);

            Assert.AreEqual(module.Solve(true), "B6");
            io.Close();
        }

        [TestMethod]
        public void Test2()
        {
            Chess module = new Chess("C3", "D2", "A2", "F1", "A3", "C6", bomb, io);

            Assert.AreEqual(module.Solve(true), "E3");
            io.Close();
        }

        [TestMethod]
        public void Test20()
        {
            Chess module = new Chess("E3", "B3", "A4", "C2", "F6", "D4", bomb, io);

            Assert.AreEqual(module.Solve(true), "E1");
            io.Close();
        }

        [TestMethod]
        public void Test21()
        {
            Chess module = new Chess("D2", "D6", "D5", "F2", "B6", "B3", bomb, io);

            Assert.AreEqual(module.Solve(true), "A1");
            io.Close();
        }

        [TestMethod]
        public void Test22()
        {
            Chess module = new Chess("E4", "B6", "B2", "A6", "E2", "B1", bomb, io);

            Assert.AreEqual(module.Solve(true), "C5");
            io.Close();
        }

        [TestMethod]
        public void Test23()
        {
            Chess module = new Chess("E5", "E6", "B4", "E1", "A2", "C5", bomb, io);

            Assert.AreEqual(module.Solve(true), "F3");
            io.Close();
        }

        [TestMethod]
        public void Test24()
        {
            Chess module = new Chess("E1", "A1", "D6", "F1", "D2", "B4", bomb, io);

            Assert.AreEqual(module.Solve(true), "E3");
            io.Close();
        }

        [TestMethod]
        public void Test25()
        {
            Chess module = new Chess("A1", "B1", "F3", "C5", "E5", "A6", bomb, io);

            Assert.AreEqual(module.Solve(true), "D2");
            io.Close();
        }

        [TestMethod]
        public void Test26()
        {
            Chess module = new Chess("B3", "D1", "C5", "F2", "E6", "A4", bomb, io);

            Assert.AreEqual(module.Solve(true), "A5");
            io.Close();
        }

        [TestMethod]
        public void Test27()
        {
            Chess module = new Chess("E5", "C3", "F5", "B2", "F4", "A1", bomb, io);

            Assert.AreEqual(module.Solve(true), "D5");
            io.Close();
        }

        [TestMethod]
        public void Test28()
        {
            Chess module = new Chess("E6", "A2", "D2", "B6", "C3", "D4", bomb, io);

            Assert.AreEqual(module.Solve(true), "F1");
            io.Close();
        }

        [TestMethod]
        public void Test29()
        {
            Chess module = new Chess("F6", "F5", "E1", "B6", "F4", "C3", bomb, io);

            Assert.AreEqual(module.Solve(true), "A2");
            io.Close();
        }

        [TestMethod]
        public void Test3()
        {
            Chess module = new Chess("F2", "F4", "B2", "D6", "E1", "A3", bomb, io);

            Assert.AreEqual(module.Solve(true), "B5");
            io.Close();
        }

        [TestMethod]
        public void Test30()
        {
            Chess module = new Chess("D2", "A2", "C5", "E3", "F3", "D4", bomb, io);

            Assert.AreEqual(module.Solve(true), "B1");
            io.Close();
        }

        [TestMethod]
        public void Test31()
        {
            Chess module = new Chess("A6", "B2", "C5", "F6", "A1", "E2", bomb, io);

            Assert.AreEqual(module.Solve(true), "C3");
            io.Close();
        }

        [TestMethod]
        public void Test32()
        {
            Chess module = new Chess("E4", "B6", "A1", "C5", "E2", "A3", bomb, io);

            Assert.AreEqual(module.Solve(true), "A4");
            io.Close();
        }

        [TestMethod]
        public void Test33()
        {
            Chess module = new Chess("A5", "F4", "D6", "B6", "D2", "E1", bomb, io);

            Assert.AreEqual(module.Solve(true), "A3");
            io.Close();
        }

        [TestMethod]
        public void Test34()
        {
            Chess module = new Chess("F6", "D6", "A5", "F3", "C1", "B2", bomb, io);

            Assert.AreEqual(module.Solve(true), "E4");
            io.Close();
        }

        [TestMethod]
        public void Test35()
        {
            Chess module = new Chess("B4", "C6", "A2", "D5", "F1", "D1", bomb, io);

            Assert.AreEqual(module.Solve(true), "E4");
            io.Close();
        }

        [TestMethod]
        public void Test36()
        {
            Chess module = new Chess("C4", "B1", "F3", "F5", "D6", "A3", bomb, io);

            Assert.AreEqual(module.Solve(true), "C2");
            io.Close();
        }

        [TestMethod]
        public void Test37()
        {
            Chess module = new Chess("D3", "A6", "F3", "B2", "D2", "C5", bomb, io);

            Assert.AreEqual(module.Solve(true), "E1");
            io.Close();
        }

        [TestMethod]
        public void Test38()
        {
            Chess module = new Chess("D3", "B1", "F6", "A4", "D5", "A2", bomb, io);

            Assert.AreEqual(module.Solve(true), "F2");
            io.Close();
        }

        [TestMethod]
        public void Test39()
        {
            Chess module = new Chess("A5", "E2", "A3", "B1", "F6", "D6", bomb, io);

            Assert.AreEqual(module.Solve(true), "C4");
            io.Close();
        }

        [TestMethod]
        public void Test4()
        {
            Chess module = new Chess("D4", "C1", "A6", "B1", "A3", "E5", bomb, io);

            Assert.AreEqual(module.Solve(true), "D2");
            io.Close();
        }

        [TestMethod]
        public void Test40()
        {
            Chess module = new Chess("F5", "B4", "C2", "E6", "A3", "F3", bomb, io);

            Assert.AreEqual(module.Solve(true), "C5");
            io.Close();
        }

        [TestMethod]
        public void Test41()
        {
            Chess module = new Chess("A6", "C1", "A3", "C2", "E3", "E5", bomb, io);

            Assert.AreEqual(module.Solve(true), "B6");
            io.Close();
        }

        [TestMethod]
        public void Test42()
        {
            Chess module = new Chess("D1", "A6", "F3", "F2", "B5", "F5", bomb, io);

            Assert.AreEqual(module.Solve(true), "C3");
            io.Close();
        }

        [TestMethod]
        public void Test43()
        {
            Chess module = new Chess("B5", "F1", "B6", "C3", "D2", "D6", bomb, io);

            Assert.AreEqual(module.Solve(true), "E4");
            io.Close();
        }

        [TestMethod]
        public void Test44()
        {
            Chess module = new Chess("C5", "E6", "A2", "A5", "C3", "F3", bomb, io);

            Assert.AreEqual(module.Solve(true), "D2");
            io.Close();
        }

        [TestMethod]
        public void Test45()
        {
            Chess module = new Chess("E4", "F6", "C1", "D2", "A5", "C3", bomb, io);

            Assert.AreEqual(module.Solve(true), "E1");
            io.Close();
        }

        [TestMethod]
        public void Test46()
        {
            Chess module = new Chess("B5", "B6", "B1", "D5", "E3", "E1", bomb, io);

            Assert.AreEqual(module.Solve(true), "F4");
            io.Close();
        }

        [TestMethod]
        public void Test47()
        {
            Chess module = new Chess("A4", "A5", "E3", "F1", "F2", "B4", bomb, io);

            Assert.AreEqual(module.Solve(true), "E6");
            io.Close();
        }

        [TestMethod]
        public void Test48()
        {
            Chess module = new Chess("F1", "F2", "C4", "A6", "C5", "C1", bomb, io);

            Assert.AreEqual(module.Solve(true), "E4");
            io.Close();
        }

        [TestMethod]
        public void Test49()
        {
            Chess module = new Chess("E5", "E1", "B2", "B5", "F6", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "D2");
            io.Close();
        }

        [TestMethod]
        public void Test5()
        {
            Chess module = new Chess("D4", "F1", "E2", "D6", "B2", "A4", bomb, io);

            Assert.AreEqual(module.Solve(true), "E4");
            io.Close();
        }

        [TestMethod]
        public void Test50()
        {
            Chess module = new Chess("C6", "C3", "B5", "D2", "E5", "F5", bomb, io);

            Assert.AreEqual(module.Solve(true), "A1");
            io.Close();
        }

        [TestMethod]
        public void Test51()
        {
            Chess module = new Chess("A5", "F1", "A3", "E6", "D3", "F5", bomb, io);

            Assert.AreEqual(module.Solve(true), "C5");
            io.Close();
        }

        [TestMethod]
        public void Test52()
        {
            Chess module = new Chess("D5", "F3", "A6", "E1", "D2", "B5", bomb, io);

            Assert.AreEqual(module.Solve(true), "D6");
            io.Close();
        }

        [TestMethod]
        public void Test53()
        {
            Chess module = new Chess("F1", "E4", "B4", "F6", "D2", "C2", bomb, io);

            Assert.AreEqual(module.Solve(true), "A1");
            io.Close();
        }

        [TestMethod]
        public void Test54()
        {
            Chess module = new Chess("B4", "E4", "C2", "F3", "E6", "B3", bomb, io);

            Assert.AreEqual(module.Solve(true), "A2");
            io.Close();
        }

        [TestMethod]
        public void Test55()
        {
            Chess module = new Chess("C3", "D5", "B2", "A2", "F4", "B6", bomb, io);

            Assert.AreEqual(module.Solve(true), "E2");
            io.Close();
        }

        [TestMethod]
        public void Test56()
        {
            Chess module = new Chess("D2", "C2", "A6", "F3", "E1", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "D6");
            io.Close();
        }

        [TestMethod]
        public void Test57()
        {
            Chess module = new Chess("C2", "C5", "B3", "D2", "F6", "C1", bomb, io);

            Assert.AreEqual(module.Solve(true), "E3");
            io.Close();
        }

        [TestMethod]
        public void Test58()
        {
            Chess module = new Chess("D1", "D2", "B5", "E2", "F6", "C3", bomb, io);

            Assert.AreEqual(module.Solve(true), "B1");
            io.Close();
        }

        [TestMethod]
        public void Test59()
        {
            Chess module = new Chess("C5", "A4", "C2", "B6", "C1", "D5", bomb, io);

            Assert.AreEqual(module.Solve(true), "E2");
            io.Close();
        }

        [TestMethod]
        public void Test6()
        {
            Chess module = new Chess("E1", "B6", "C2", "D5", "A5", "D3", bomb, io);

            Assert.AreEqual(module.Solve(true), "F4");
            io.Close();
        }

        [TestMethod]
        public void Test60()
        {
            Chess module = new Chess("D5", "B1", "F3", "A2", "F4", "A3", bomb, io);

            Assert.AreEqual(module.Solve(true), "E5");
            io.Close();
        }


        [TestMethod]
        public void Test61()
        {
            Chess module = new Chess("E2", "B1", "C1", "A4", "D5", "F6", bomb, io);

            Assert.AreEqual(module.Solve(true), "C3");
            io.Close();
        }

        [TestMethod]
        public void Test62()
        {
            Chess module = new Chess("D2", "F4", "C2", "B6", "E1", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "A3");
            io.Close();
        }

        [TestMethod]
        public void Test63()
        {
            Chess module = new Chess("A1", "C1", "B5", "E3", "F6", "D4", bomb, io);

            Assert.AreEqual(module.Solve(true), "A2");
            io.Close();
        }

        [TestMethod]
        public void Test64()
        {
            Chess module = new Chess("B5", "A2", "C5", "E1", "A5", "F6", bomb, io);

            Assert.AreEqual(module.Solve(true), "B3");
            io.Close();
        }

        [TestMethod]
        public void Test65()
        {
            Chess module = new Chess("F4", "E6", "D4", "B3", "B2", "A1", bomb, io);

            Assert.AreEqual(module.Solve(true), "F5");
            io.Close();
        }

        [TestMethod]
        public void Test66()
        {
            Chess module = new Chess("F5", "D2", "A4", "C6", "D1", "B5", bomb, io);

            Assert.AreEqual(module.Solve(true), "E3");
            io.Close();
        }

        [TestMethod]
        public void Test67()
        {
            Chess module = new Chess("D5", "A2", "B1", "B4", "F3", "C1", bomb, io);

            Assert.AreEqual(module.Solve(true), "E1");
            io.Close();
        }

        [TestMethod]
        public void Test68()
        {
            Chess module = new Chess("E1", "B3", "D2", "E5", "A6", "E6", bomb, io);

            Assert.AreEqual(module.Solve(true), "F6");
            io.Close();
        }

        [TestMethod]
        public void Test69()
        {
            Chess module = new Chess("B2", "F1", "E5", "C2", "A5", "D4", bomb, io);

            Assert.AreEqual(module.Solve(true), "B3");
            io.Close();
        }

        [TestMethod]
        public void Test7()
        {
            Chess module = new Chess("A5", "A3", "C6", "F1", "E2", "B1", bomb, io);

            Assert.AreEqual(module.Solve(true), "D4");
            io.Close();
        }


        [TestMethod]
        public void Test70()
        {
            Chess module = new Chess("D2", "A4", "B5", "B6", "F5", "C1", bomb, io);

            Assert.AreEqual(module.Solve(true), "B2");
            io.Close();
        }
        [TestMethod]
        public void Test71()
        {
            Chess module = new Chess("C4", "F6", "D4", "D6", "E1", "B4", bomb, io);

            Assert.AreEqual(module.Solve(true), "C2");
            io.Close();
        }

        [TestMethod]
        public void Test72()
        {
            Chess module = new Chess("F5", "B1", "E1", "C4", "A1", "E6", bomb, io);

            Assert.AreEqual(module.Solve(true), "F3");
            io.Close();
        }

        [TestMethod]
        public void Test73()
        {
            Chess module = new Chess("E5", "F1", "A3", "B6", "E2", "E4", bomb, io);

            Assert.AreEqual(module.Solve(true), "A5");
            io.Close();
        }

        [TestMethod]
        public void Test74()
        {
            Chess module = new Chess("A1", "B4", "E4", "F6", "C5", "D2", bomb, io);

            Assert.AreEqual(module.Solve(true), "A3");
            io.Close();
        }

        [TestMethod]
        public void Test75()
        {
            Chess module = new Chess("C5", "E4", "F6", "D1", "C3", "B5", bomb, io);

            Assert.AreEqual(module.Solve(true), "A2");
            io.Close();
        }

        [TestMethod]
        public void Test76()
        {
            Chess module = new Chess("C3", "C6", "B5", "E1", "F2", "A2", bomb, io);

            Assert.AreEqual(module.Solve(true), "D3");
            io.Close();

        }

        [TestMethod]
        public void Test77()
        {
            Chess module = new Chess("B6", "C2", "B4", "C6", "E1", "F3", bomb, io);

            Assert.AreEqual(module.Solve(true), "A6");
            io.Close();
        }

        [TestMethod]
        public void Test78()
        {
            Chess module = new Chess("C4", "E2", "C2", "F3", "B6", "A1", bomb, io);

            Assert.AreEqual(module.Solve(true), "C5");
            io.Close();
        }

        [TestMethod]
        public void Test79()
        {
            Chess module = new Chess("B2", "E6", "E2", "D5", "B3", "A2", bomb, io);

            Assert.AreEqual(module.Solve(true), "F4");
            io.Close();
        }

        [TestMethod]
        public void Test8()
        {
            Chess module = new Chess("D5", "B3", "E6", "A5", "D1", "E2", bomb, io);

            Assert.AreEqual(module.Solve(true), "F2");
            io.Close();
        }

        [TestMethod]
        public void Test80()
        {
            Chess module = new Chess("B1", "C1", "A4", "C4", "D6", "E2", bomb, io);

            Assert.AreEqual(module.Solve(true), "A1");
            io.Close();
        }

        [TestMethod]
        public void Test81()
        {
            Chess module = new Chess("A2", "C2", "E4", "C6", "B5", "B2", bomb, io);

            Assert.AreEqual(module.Solve(true), "E1");
            io.Close();
        }

        [TestMethod]
        public void Test82()
        {
            Chess module = new Chess("F6", "C2", "B3", "E6", "E1", "D5", bomb, io);

            Assert.AreEqual(module.Solve(true), "F4");
            io.Close();
        }

        [TestMethod]
        public void Test83()
        {
            Chess module = new Chess("F5", "E1", "D5", "A3", "B1", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "F2");
            io.Close();
        }

        [TestMethod]
        public void Test84()
        {
            Chess module = new Chess("D6", "B2", "E5", "D3", "A1", "F4", bomb, io);

            Assert.AreEqual(module.Solve(true), "C6");
            io.Close();
        }

        [TestMethod]
        public void Test85()
        {
            Chess module = new Chess("C3", "F2", "B5", "D6", "B4", "E1", bomb, io);

            Assert.AreEqual(module.Solve(true), "A3");
            io.Close();
        }

        [TestMethod]
        public void Test86()
        {
            Chess module = new Chess("C2", "A6", "B4", "F2", "E3", "D1", bomb, io);

            Assert.AreEqual(module.Solve(true), "B2");
            io.Close();
        }

        [TestMethod]
        public void Test87()
        {
            Chess module = new Chess("F5", "A5", "C6", "B6", "C1", "E3", bomb, io);

            Assert.AreEqual(module.Solve(true), "F6");
            io.Close();
        }

        [TestMethod]
        public void Test88()
        {
            Chess module = new Chess("B5", "C5", "E4", "F1", "A2", "A1", bomb, io);

            Assert.AreEqual(module.Solve(true), "D6");
            io.Close();
        }

        [TestMethod]
        public void Test89()
        {
            Chess module = new Chess("D5", "F2", "B4", "C4", "A1", "E3", bomb, io);

            Assert.AreEqual(module.Solve(true), "D6");
            io.Close();
        }

        [TestMethod]
        public void Test9()
        {
            Chess module = new Chess("F1", "C3", "B1", "D2", "E5", "F4", bomb, io);

            Assert.AreEqual(module.Solve(true), "B6");
            io.Close();
        }

        [TestMethod]
        public void Test90()
        {
            Chess module = new Chess("B1", "F5", "C3", "D6", "E6", "B2", bomb, io);

            Assert.AreEqual(module.Solve(true), "A3");
            io.Close();
        }
        [TestMethod]
        public void Test91()
        {
            Chess module = new Chess("A4", "C1", "D6", "A3", "B2", "E5", bomb, io);

            Assert.AreEqual(module.Solve(true), "A6");
            io.Close();
        }

        [TestMethod]
        public void Test92()
        {
            Chess module = new Chess("C5", "E5", "B6", "D3", "A1", "C1", bomb, io);

            Assert.AreEqual(module.Solve(true), "F6");
            io.Close();
        }

        [TestMethod]
        public void Test93()
        {
            Chess module = new Chess("E1", "D6", "B2", "A5", "F6", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "E3");
            io.Close();

        }

        [TestMethod]
        public void Test94()
        {
            Chess module = new Chess("B3", "F3", "B5", "B1", "F2", "F4", bomb, io);

            Assert.AreEqual(module.Solve(true), "A3");
            io.Close();
        }

        [TestMethod]
        public void Test95()
        {
            Chess module = new Chess("C1", "E3", "E6", "B4", "A1", "C2", bomb, io);

            Assert.AreEqual(module.Solve(true), "F1");
            io.Close();
        }

        [TestMethod]
        public void Test96()
        {
            Chess module = new Chess("E3", "F1", "E5", "B2", "A5", "D4", bomb, io);

            Assert.AreEqual(module.Solve(true), "C6");
            io.Close();
        }

        [TestMethod]
        public void Test97()
        {
            Chess module = new Chess("E5", "B1", "D4", "C2", "A6", "C4", bomb, io);

            Assert.AreEqual(module.Solve(true), "F3");
            io.Close();
        }

        [TestMethod]
        public void Test98()
        {
            Chess module = new Chess("B4", "C1", "E5", "E2", "B5", "E1", bomb, io);

            Assert.AreEqual(module.Solve(true), "F1");
            io.Close();
        }

        [TestMethod]
        public void Test99()
        {
            Chess module = new Chess("D2", "D4", "C4", "F6", "E1", "A3", bomb, io);

            Assert.AreEqual(module.Solve(true), "C2");
            io.Close();
        }
    }
}