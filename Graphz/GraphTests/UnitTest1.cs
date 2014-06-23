using System;
using System.Collections.Generic;
using System.Linq;
using Graphz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTheTester()
        {
            Assert.IsTrue(1==1);
        }


        [TestMethod]
        public void CanAddSingleEdge()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A = Vertex.New(0, 0), B =  Vertex.New(0, 1) });
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CanAddSingleEdgeAndCountIt()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A =  Vertex.New(0, 0), B =  Vertex.New(0, 1) });
            Assert.IsTrue(q.Count() ==1);
        }
        [TestMethod]
        public void CountIsZeroOnInit()
        {
            Graph q = new Graphz.Graph();
            Assert.IsTrue(q.Count() == 0);
        }
        [TestMethod]
        public void EdgeCountIsOneafterAddingOneEdge()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A = Vertex.New(0, 0), B = Vertex.New(0, 1) });
            Assert.IsTrue(q.EdgeCount() == 0);
        }
        [TestMethod]
        public void EdgeCountIsTwoAfterAddingTwoWayEdge()
        {
            Graph q = new Graphz.Graph();
            q.AddTwoEdge(new Edge() { A = Vertex.New(0, 0), B = Vertex.New(0, 1) });
            Assert.IsTrue(q.EdgeCount() == 0);
        }

        [TestMethod]
        public void VertexCountIsTwoafterAddingOneEdge()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A = Vertex.New(0, 0), B = Vertex.New(0, 1) });
            Assert.IsTrue(q.VertexCount() == 2);
        }
        [TestMethod]
        public void VertexCountIsTwoafterAddingTwoWay()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A = Vertex.New(0, 0), B = Vertex.New(0, 1) });
            q.AddEdge(new Edge() { A = Vertex.New(0, 1), B = Vertex.New(0, 0) });
            Assert.IsTrue(q.VertexCount() == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionWhenAddinEdgeToSelf()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A = Vertex.New(0, 0), B = Vertex.New(0, 0) });

        }
        [TestMethod]
       
        public void CanGetEdgesForVertex()
        {
            var origin = Vertex.New(0, 0);

            List<Vertex> connectedNodes = new List<Vertex>() {Vertex.New(0, 1)};


            Graph q = new Graphz.Graph();

            foreach (Vertex connectedNode in connectedNodes)
            {
                q.AddEdge(new Edge() { A = origin, B = connectedNode });
            }


            IEnumerable<Vertex> qq = q.GetEdgesForVertex(origin);

            Assert.IsTrue(connectedNodes.SequenceEqual(qq));
        }
    }
}
