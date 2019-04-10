using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    public class Node
    {
        public Node(Word data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
        public Word Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString()
        {
            return $"{Data}, {Left},{Right}";
        }
    }
}
