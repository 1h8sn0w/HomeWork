using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    public class Word
    {
        public Word(string eng, string rus)
        {
            Eng = eng;
            Rus = rus;
        }
        public string Eng { get; set; }
        public string Rus { get; set; }
    }
}
