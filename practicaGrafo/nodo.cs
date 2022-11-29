using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaGrafo
{
    internal class Node
    {
    

            public int data;
            public List<Node> children = new List<Node>();
            public List<Node> father = new List<Node>();
            public Node(Graph graph)
            {

                data = graph.assignNodeData;
                graph.assignNodeData++;
            }
    }
}
