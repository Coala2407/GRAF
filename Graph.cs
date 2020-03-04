using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAF
{
    class Graph
    {
        public List<Node> nodeList = new List<Node>();
        public List<Edge> edgeList = new List<Edge>();

        public void AddNode()
        {
            Node nodeToAdd = new Node();
            nodeToAdd.Id = nodeList.Count + 1;
            nodeList.Add(nodeToAdd);
        }

        public void AddEdge(int startNodeID, int endNodeID)
        {
            try
            {
                Node startNode = nodeList[startNodeID - 1];
                Node endNode = nodeList[endNodeID - 1];
                Edge edgeToAdd = new Edge(startNode, endNode);
                edgeList.Add(edgeToAdd);
            }
            catch (Exception)
            {
                Exception ex = new Exception();
                Console.WriteLine("Error, boi");
            }
        }
    }
}
