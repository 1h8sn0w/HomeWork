using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyHash
{
    class ReverseDict
    {
        public ReverseDict(Dictionary<string, string> dict , Dictionary<string,string> revDict)
        {
            var file = new FileWorker(dict);
            foreach (var item in dict)
            {
                revDict.Add(item.Value.Trim(), item.Key.Trim());
            }
        }
    }
}
