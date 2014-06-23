using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Graphz
{
    public class Graph
    {


        private readonly Dictionary<Vertex,List<Vertex>> _graph = new Dictionary<Vertex, List<Vertex>>();

        public void AddEdge(Edge edge)
        {

            if (edge.A == edge.B)
            {
                throw new InvalidOperationException("");
            }
            List<Vertex> a;
            if (!_graph.TryGetValue(edge.A , out a ))
            {
                a = new List<Vertex>();
            }
          _graph[edge.A] = a.Union(new List<Vertex>() {edge.B}).ToList();
        }

        public void RemoveEdge(Edge edge)
        {
            
        }

        public List<Vertex> GetShortestPath(Vertex start, Vertex finish)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
          return  _graph.Count();
        }
        //public int CountVertices()
        //{

        //}
        //public int CountEdges()
        //{

        //}

        public int EdgeCount()
        {
            throw new NotImplementedException();
        }

        public int VertexCount()
        {
            var allOriginVertexi = _graph.Keys;
            var allDestnationVertexi = _graph.SelectMany(ss => ss.Value.Select(m => m));
            var distinctVertexi = allDestnationVertexi.Union(allOriginVertexi);
            return distinctVertexi.Count();
        }

        public void AddTwoEdge(Edge edge)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vertex> GetEdgesForVertex(Vertex origin)
        {
            throw new NotImplementedException();
        }
    }
}
