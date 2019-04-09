using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    public class Node
    {
        public Node(Node left, Node right)
        {
            Left = left;
            Right = right;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
