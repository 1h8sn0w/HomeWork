using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{

    class Tree
    {
        public Node node;
        public static Node root;

        public void AddNode(Vehicle input)
        {
            node = new Node(input, null, null);
            Node currentroot = root;

            if (root == null)
            {
                root = node;
            }
            else
            {
                Find(currentroot, node);
            }

        }
        public void Find(Node currentroot, Node node)
        {
            if (currentroot.GetHashCode() > node.GetHashCode())
            {
                if (currentroot.left == null)
                {
                    currentroot.left = node;
                }
                else Find(currentroot.left, node);
            }
            else if (currentroot.GetHashCode() < node.GetHashCode())
            {
                if (currentroot.right == null)
                {
                    currentroot.right = node;
                }
                else Find(currentroot.right, node);
            }
        }
        public void Print(Tree node)
        {
            Console.WriteLine("d {0},l {1},r {2}", root.data, root.left, root.right);
        }


    }
}
