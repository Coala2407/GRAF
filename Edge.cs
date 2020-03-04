using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAF
{
    class Edge
    {
        Node startNode;

        Node endNode;

        public Edge(Node startNode, Node endNode)
        {
            this.startNode = startNode;
            this.endNode = endNode;
        }

        public Node StartNode { get => startNode; set => startNode = value; }
        public Node EndNode { get => endNode; set => endNode = value; }
    }
}
