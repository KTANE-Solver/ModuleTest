﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class ComplicatedWiresTest
    {
        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = null;

        List<ComplicatedWire> wireList; 

        [TestMethod]
        public void TestMethod1()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Purple, false, true),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.White, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4. Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.Purple, false, true),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, true, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Dont, Cut, Cut, Cut, Dont*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Cut\n5. Cut\n6. Don't Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod3()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.Blue, false, true),
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, D, Cut, D */
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Don't Cut\n4. Cut\n5. Don't Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod4()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Red, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Don't Cut\n4. Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod5()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4. Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod6()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Don't Cut\n5. Don't Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod7()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod8()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Purple, false, false),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Red, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Don't Cut\n4. Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod9()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, true, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Don't Cut\n2. Don't Cut\n3. Cut\n4. Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod10()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Purple, true, false),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.White, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4. Don't Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod11()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4. Cut\n5. Cut\n6. Don't Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod12()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Purple, true, false),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Red, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Cut\n4. Cut\n5. Don't Cut\n6. Cut", module.Solve(true));
            io.Close();

        }


        [TestMethod]
        public void TestMethod13()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Purple, false, false),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.Red, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4. Don't Cut\n5. Don't Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod14()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Purple, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, Cut, D, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Don't Cut\n5. Cut\n6. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod15()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.Red, true, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*D, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Cut\n4. Cut\n5. Cut", module.Solve(true));
            io.Close();

        }

        [TestMethod]
        public void TestMethod16()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Blue, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, D, D*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Don't Cut\n4. Don't Cut", module.Solve(true));
            io.Close();

        }
    }
}
