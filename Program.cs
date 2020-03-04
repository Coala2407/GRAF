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

            for (int i = 0; i < 10; i++)
            {
                graph.AddNode();

            }
            for (int i = 0; i < 10; i++)
            {
                graph.AddEdge(i + 1, i + 2);
            }

            foreach (var item in graph.nodeList)
            {
                Console.WriteLine(item.Id);
            }

            Console.WriteLine("");

            foreach (var item in graph.edgeList)
            {
                Console.WriteLine(item.StartNode.Id + "-"  + item.EndNode.Id);
            }

            Console.Read();
        }
    }
}
