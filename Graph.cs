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
            try
            {
                Node nodeToAdd = new Node();
                nodeToAdd.Id = nodeList.Count + 1;
                nodeList.Add(nodeToAdd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
