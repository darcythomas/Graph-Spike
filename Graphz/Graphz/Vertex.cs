using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphz
{
   public struct Vertex
    {
       public int Ex { get; set; }
       public int Why { get; set; }

       public static Vertex New(int x, int y)
       {
           return new Vertex() {Ex = x, Why = y};
       }

       public override bool Equals(object obj)
       {
           if (obj == null || !(obj is Vertex))
           {
               return false;
           }
            Vertex B = (Vertex)obj;
           return this.Ex == B.Ex && this.Why == B.Why;
       }

       public static bool operator ==(Vertex A, Vertex B)
       {
           return A.Ex == B.Ex && A.Why == B.Why;
       }

       public static bool operator !=(Vertex A, Vertex B)
       {
           return !(A == B);
       }
    }
}
