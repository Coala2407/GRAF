using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAF
{
    class Node
    {
        int id;
        string name;
        Node parent;
        bool visited;
        bool goal;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Node Parent { get => parent; set => parent = value; }
        public bool Visited { get => visited; set => visited = value; }
        public bool Goal { get => goal; set => goal = value; }

        public Node(string name)
        {
            this.name = name;
        }

        public Node(string name, bool isGoal)
        {
            this.name = name;
            this.goal = isGoal;
        }
    }
}
