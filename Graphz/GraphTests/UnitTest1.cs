using System;
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
            q.AddEdge(new Edge() { A = Vertex.New(0, 1), B = Vertex.New(1,0) });
            Assert.IsTrue(q.VertexCount() == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionWhenAddinEdgeToSelf()
        {
            Graph q = new Graphz.Graph();
            q.AddEdge(new Edge() { A = Vertex.New(0, 0), B = Vertex.New(0, 0) });
           
        }
    }
}
