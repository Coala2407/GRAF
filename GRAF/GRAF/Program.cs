using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAF
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddNode("Entrance"); //1
            graph.AddNode("Slot Machines"); //2
            graph.AddNode("Ice Blaster"); //3
            graph.AddNode("Funhouse"); //4
            graph.AddNode("Hotdogs"); //5
            graph.AddNode("Rocket Ships"); //6
            graph.AddNode("3D Cinema"); //7
            graph.AddNode("Log Flume"); //8
            graph.AddNode("Big Dipper"); //9
            graph.AddNode("Ghost Train", true); //10
            graph.AddNode("Pirate Ship"); //11
            graph.AddNode("Rollercoaster"); //12
            graph.AddNode("Carousel"); //13
            graph.AddNode("Flying Chairs"); //14

            //Edges
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);

            graph.AddEdge(3, 2);
            graph.AddEdge(3, 6);
            graph.AddEdge(3, 7);
            graph.AddEdge(3, 4);

            graph.AddEdge(2, 6);
            graph.AddEdge(6, 7);
            graph.AddEdge(7, 4);

            graph.AddEdge(2, 5);
            graph.AddEdge(5, 8);
            graph.AddEdge(8, 9);
            graph.AddEdge(9, 10);
            graph.AddEdge(6, 10);

            graph.AddEdge(9, 12);
            graph.AddEdge(10, 13);
            graph.AddEdge(10, 14);

            graph.AddEdge(13, 14);

            DFS(graph, graph.nodeList[0]);

            Console.ReadLine();
        }

        public static void DFS(Graph graph, Node startNode)
        {
            Stack<Edge> edgeStack = new Stack<Edge>();
            edgeStack.Push(new Edge(startNode, startNode));
            startNode.Visited = true;
            startNode.Parent = startNode;
            while (edgeStack.Count > 0)
            {
                Edge e = edgeStack.Pop();
                if (!e.EndNode.Visited)
                {
                    e.EndNode.Visited = true;
                    e.EndNode.Parent = e.StartNode;
                    Console.WriteLine(e.StartNode.Name);
                }
                foreach (Edge item in graph.edgeList.Where(x => x.StartNode.Id == e.EndNode.Id))
                {
                    if (!item.EndNode.Visited)
                    {
                        edgeStack.Push(item);
                    }
                }
            }
        }
    }
}
