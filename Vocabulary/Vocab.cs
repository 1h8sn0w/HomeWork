using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    public class Vocab
    {
        public Node node;
        public static Node root;

        public void AddNode(Word input)
        {
            node = new Node(null, null);
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
                if (currentroot.Left == null)
                {
                    currentroot.Left = node;
                }
                else Find(currentroot.Left, node);
            }
            else if (currentroot.GetHashCode() < node.GetHashCode())
            {
                if (currentroot.Right == null)
                {
                    currentroot.Right = node;
                }
                else Find(currentroot.Right, node);
            }
        }
        public Word Search (Word input)
        {
            Word trans = null;

            return trans;
        }

    }
}
