using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    public class Vocab
    {
        public Node resulting;
        public Node node;
        public static Node root;

        public void AddNode(Word input)
        {
            node = new Node(input);
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
        private void Find(Node currentroot, Node node)
        {
            if (String.Compare(currentroot.Data.Eng, node.Data.Eng) > 0)
            {
                if (currentroot.Left == null)
                {
                    currentroot.Left = node;
                }
                else Find(currentroot.Left, node);
            }
            else if (String.Compare(currentroot.Data.Eng, node.Data.Eng) < 0)
            {
                if (currentroot.Right == null)
                {
                    currentroot.Right = node;
                }
                else Find(currentroot.Right, node);
            }
        }

        public Node FindNode(Word input)
        {
            WordFind(root, new Node(input));
            return resulting;

        }
        private void WordFind(Node currentroot, Node node)
        {
            if (String.Compare(currentroot.Data.Eng, node.Data.Eng, true) == 0)
            {
                resulting = currentroot;
            }
            else
            {
                if (String.Compare(currentroot.Data.Eng, node.Data.Eng) > 0)
                {
                    if (currentroot.Left != null)
                    {


                        if (String.Compare(currentroot.Left.Data.Eng, node.Data.Eng, true) == 0)
                        {
                            resulting = currentroot.Left;

                        }
                        else if (String.Compare(currentroot.Left.Data.Eng, node.Data.Eng, true) != 0)
                        {
                            WordFind(currentroot.Left, node);
                        }
                    }
                    else resulting = new Node(new Word("Думал я глупый? Не то слово. Пидор.", "Думал я глупый? Не то слово. Пидор."));

                }
                else if (String.Compare(currentroot.Data.Eng, node.Data.Eng) < 0)
                {
                    if (currentroot.Right != null)
                    {
                        if (String.Compare(currentroot.Right.Data.Eng, node.Data.Eng, true) == 0)
                        {
                            resulting = currentroot.Right;
                        }
                        else if (String.Compare(currentroot.Right.Data.Eng, node.Data.Eng, true) != 0)
                        {
                            WordFind(currentroot.Right, node);
                        }
                    }
                    else resulting = new Node(new Word("Думал я глупый? Не то слово. Пидор.", "Думал я глупый? Не то слово. Пидор."));
                }                
            }
            
        }
    }
}
