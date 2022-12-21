using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ModuleTest
{
    [TestClass]
    public class AnamgramTest
    {
        //https://ktane.timwi.de/lfa#file=90f0a6d56e9477ae97f1e17ffea79de49dac6390

        StreamWriter io = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Stream()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "MASTER",
                "TAMERS"
            };


            string output = module.Solve("STREAM", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Master()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "STREAM",
                "TAMERS"
            };


            string output = module.Solve("MASTER", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Tamers()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "MASTER",
                "STREAM"
            };


            string output = module.Solve("TAMERS", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Looped()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "POODLE",
                "POOLED"
            };


            string output = module.Solve("LOOPED", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Poodle()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "LOOPED",
                "POOLED"
            };


            string output = module.Solve("POODLE", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Pooled()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "LOOPED",
                "POODLE"
            };


            string output = module.Solve("POOLED", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Cellar()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "CALLER",
                "RECALL"
            };


            string output = module.Solve("CELLAR", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Caller()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "CELLAR",
                "RECALL"
            };


            string output = module.Solve("CALLER", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Recall()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "CELLAR",
                "CALLER"
            };


            string output = module.Solve("RECALL", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Seated()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "SEDATE",
                "TEASED"
            };


            string output = module.Solve("SEATED", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Sedate()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "SEATED",
                "TEASED"
            };


            string output = module.Solve("SEDATE", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Teased()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "SEATED",
                "SEDATE"
            };


            string output = module.Solve("TEASED", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Rescue()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "SECURE",
                "RECUSE"
            };


            string output = module.Solve("RESCUE", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Secure()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "RESCUE",
                "RECUSE"
            };


            string output = module.Solve("SECURE", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Recuse()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "RESCUE",
                "SECURE"
            };


            string output = module.Solve("RECUSE", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Rashes()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "SHEARS",
                "SHARES"
            };


            string output = module.Solve("RASHES", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Shears()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "RASHES",
                "SHARES"
            };


            string output = module.Solve("SHEARS", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void SHARES()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "RASHES",
                "SHEARS"
            };


            string output = module.Solve("SHARES", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Barely()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "BARLEY",
                "BLEARY"
            };


            string output = module.Solve("BARELY", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Barley()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "BARELY",
                "BLEARY"
            };


            string output = module.Solve("BARLEY", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Bleary()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "BARELY",
                "BARLEY"
            };

            string output = module.Solve("BLEARY", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Duster()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "RUSTED",
                "RUDEST"
            };


            string output = module.Solve("DUSTER", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Rusted()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "DUSTER",
                "RUDEST"
            };


            string output = module.Solve("RUSTED", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }

        [TestMethod]
        public void Rudest()
        {
            Anagrams module = new Anagrams(null, io);


            List<string> answers = new List<string>
            {
                "DUSTER",
                "RUSTED"
            };


            string output = module.Solve("RUDEST", true);

            Assert.IsTrue(answers.Contains(output));

            io.Close();
        }
    }
}