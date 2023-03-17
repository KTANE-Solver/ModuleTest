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
        Bomb bomb = new Bomb(Day.Sunday, "GX4U62", 3, 2,
             new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
             new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
             new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
             new Indicator("SND", false, false), new Indicator("TRN", false, false), 
             new List<Plate>() { new Plate(true, false, false, false, false, false),
                                 new Plate(false, false, false, true, false, false),
                                 new Plate(false, true, false, true, true, true),
             }
            );

        StreamWriter io = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Test1()
        {
            string[] suspects = new string[] { "White", "Peacock", "Scarlett", "Plum", "Mustard" };
            string[] rooms = new string[] { "Lounge", "Hall", "Ballroom", "Study", "Conservatory", "Kitchen"};
            string red = "Lounge";
            NotMurder.Item[] weapons = new NotMurder.Item[] { NotMurder.Item.Spanner, NotMurder.Item.Dagger, 
                                                              NotMurder.Item.Candlestick, NotMurder.Item.Pipe, 
                                                              NotMurder.Item.Revolver };

            NotMurder module = new NotMurder(bomb, io, suspects, weapons, rooms, red);

            module.Solve();
            io.Close();
            Assert.IsFalse(true);
        }


    }
}