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
    }
}
