using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{

    class Tree
    {
        private Node _node;
        private static Node _root;

        public void AddNode(Vehicle input)
        {
            _node = new Node(input, null, null);
            Node currentRoot = _root;

            if (_root == null)
            {
                _root = _node;
            }
            else
            {
                Find(currentRoot, _node);
            }

        }

        private static void Find(Node currentRoot, Node node)
        {
            if (currentRoot.GetHashCode() > node.GetHashCode())
            {
                if (currentRoot.left == null)
                {
                    currentRoot.left = node;
                }
                else Find(currentRoot.left, node);
            }
            else if (currentRoot.GetHashCode() < node.GetHashCode())
            {
                if (currentRoot.right == null)
                {
                    currentRoot.right = node;
                }
                else Find(currentRoot.right, node);
            }
        }
        public void Print()
        {
            Console.WriteLine("d {0},l {1},r {2}", _root.data, _root.left, _root.right);
        }


    }
}
