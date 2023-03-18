using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Security.Permissions;

namespace ModuleTest
{



    [TestClass]
    public class NotMurderTest
    {

        //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=3d8ce2d2210d4440d975c6021702959150fab1cd;bomb=VD1SX9

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "VD1SX9", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", true, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() { new Plate(false, true, false, false, true, false),
                                 new Plate(false, false, false, true, false, false),
             }
            );

            string[] suspects = new string[] { "White", "Peacock", "Green", "Mustard", "Scarlett" };
            string[] rooms = new string[] { "Study", "Ballroom", "Billiard", "Dining", "Conservatory", "Hall"};
            string red = "Dining";
            NotMurder.Item[] weapons = new NotMurder.Item[] { NotMurder.Item.Spanner, NotMurder.Item.Revolver, 
                                                              NotMurder.Item.Rope, NotMurder.Item.Dagger, 
                                                              NotMurder.Item.Pipe };

            NotMurder module = new NotMurder(bomb, io, suspects, weapons, rooms, red);
            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("White with the Pipe in the Ballroom\n" +
                            "Peacock with the Revolver in the Study\n" +
                            "Green with the Spanner in the Ballroom\n" +
                            "Mustard with the Rope in the Dining\n" +
                            "Scarlett with the Dagger in the Dining", answer);
        }

        [TestMethod]
        public void Test2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "QE2RC6", 2, 2,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() { new Plate(false, false, true, false, false, false),
                                 new Plate(false, true, false, false, true, true),
             }
            );

            string[] suspects = new string[] { "Peacock", "Green", "Mustard", "White", "Scarlett" };
            string[] rooms = new string[] { "Ballroom", "Lounge", "Hall", "Dining", "Kitchen", "Billiard" };
            string red = "Ballroom";
            NotMurder.Item[] weapons = new NotMurder.Item[] { NotMurder.Item.Candlestick, NotMurder.Item.Revolver,
                                                              NotMurder.Item.Rope, NotMurder.Item.Dagger,
                                                              NotMurder.Item.Pipe };

            NotMurder module = new NotMurder(bomb, io, suspects, weapons, rooms, red);
            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("Peacock with the Candlestick in the Hall\n" +
                            "Green with the Pipe in the Lounge\n" +
                            "Mustard with the Revolver in the Kitchen\n" +
                            "White with the Dagger in the Dining\n" +
                            "Scarlett with the Rope in the Kitchen", answer);
        }

        [TestMethod]
        public void Test3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SR5NL5", 2, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", true, false),
             new List<Plate>() { new Plate(false, false, true, false, false, false),
                                 new Plate(false, true, false, false, true, true),
             }
            );

            string[] suspects = new string[] { "Peacock", "Plum", "Green", "Scarlett", "Mustard" };
            string[] rooms = new string[] { "Dining", "Kitchen", "Billiard", "Study", "Conservatory", "Hall" };
            string red = "Dining";
            NotMurder.Item[] weapons = new NotMurder.Item[] { NotMurder.Item.Spanner, NotMurder.Item.Dagger,
                                                              NotMurder.Item.Rope, NotMurder.Item.Pipe,
                                                              NotMurder.Item.Revolver };

            NotMurder module = new NotMurder(bomb, io, suspects, weapons, rooms, red);
            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("Peacock with the Pipe in the Dining\n" +
                            "Mustard with the Dagger in the Kitchen\n" +
                            "Scarlett with the Revolver in the Conservatory\n" +
                            "Green with the Rope in the Study\n" +
                            "Plum with the Spanner in the Billiard", answer);
        }

        [TestMethod]
        public void Test4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "VG3ZS4", 1, 1,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false),
             new List<Plate>() { new Plate(false, false, true, false, false, false),
                                 new Plate(false, true, false, false, true, true),
             }
            );

            string[] suspects = new string[] { "Mustard", "White", "Green", "Peacock", "Scarlett" };
            string[] rooms = new string[] { "Kitchen", "Conservatory", "Ballroom", "Hall", "Study", "Billiard" };
            string red = "Ballroom";
            NotMurder.Item[] weapons = new NotMurder.Item[] { NotMurder.Item.Revolver, NotMurder.Item.Pipe,
                                                              NotMurder.Item.Spanner, NotMurder.Item.Rope,
                                                              NotMurder.Item.Candlestick };

            NotMurder module = new NotMurder(bomb, io, suspects, weapons, rooms, red);
            string answer = module.Solve(true);

            io.Close();

            Assert.AreEqual("Mustard with the Pipe in the Study\n" +
                            "White with the Spanner in the Kitchen\n" +
                            "Green with the Revolver in the Kitchen\n" +
                            "Peacock with the Rope in the Hall\n" +
                            "Scarlett with the Candlestick in the Kitchen", answer);
        }
    }
}