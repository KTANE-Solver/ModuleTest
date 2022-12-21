using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ModuleTests
{
    [TestClass]
    public class ConnectionCheckTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        #region Neighbor Check

        [TestMethod]
        public void OneSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] {1, 1};
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);
            
            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));

            streamWriter.Close();
        }

        [TestMethod]
        public void TwoSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));

            streamWriter.Close();
        }

        [TestMethod]
        public void ThreeSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void FourSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void FiveSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void SixSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void SevenSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void EightSLIMNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight20DGTNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight7HPJNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight8CAKENeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight15BRONeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight34XYZNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }


        [TestMethod]
        public void One6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight6WUFNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight9QVNNeighborCheck()
        {
            Bomb bomb = null;


            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        #endregion

        #region Target Index
        [TestMethod]
        public void NumbersAllDifferent()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);

            
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThanOne1()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(0, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThanOne7()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 7, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThanTwo2()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 2, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(1, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void NoFive()
        {
            Bomb bomb = null;

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 2, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void Two8()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 8, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(2, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThan6Batteries()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void BatteryCount()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(bomb.Battery - 1, module.targetIndex);
            streamWriter.Close();
        }

        #endregion

        #region Target Gives Right Graph
        [TestMethod]
        public void Target0()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;

            

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target1()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target2()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target3()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target4()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target5()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target6()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target7()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target8()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target9()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;
            
            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();

        }

        [TestMethod]
        public void TargetA()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetB()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetC()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetD()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetE()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetF()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetG()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetH()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetI()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetJ()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetK()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetL()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetM()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetN()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;

            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetO()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetP()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetQ()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;

            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetR()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetS()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetT()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetU()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetV()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;

            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetW()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetX()
        {
            Bomb bomb = null;


            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetY()
        {
            Bomb bomb = null;



            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetZ()
        {
            Bomb bomb = null;

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }
        #endregion








    }
}
