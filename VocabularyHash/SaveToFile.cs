using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyHash
{
    class SaveToFile
    {

        public SaveToFile(Dictionary<string, string> dict, string path)
        {
            var file = new FileWorker(dict);
            foreach (var item in dict)
            {
                File.WriteAllText(path + item.Key + ".txt", item.Value.Trim());
            }

        }

        public SaveToFile(Dictionary<string, string> dict)
        {
            var vocab2 = new Dictionary<string, string>();
            var switching = new ReverseDict(dict, vocab2);
            foreach (var item in vocab2)
            {
                File.AppendAllText(@"D:\Rus.eng",  item.Key + " " + item.Value);
                File.AppendAllLines(@"D:\Rus.eng", new []{""});
            }
        }

    }
}
