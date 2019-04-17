using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VocabularyHash
{
    class FileWorker
    {
        private const string Path = @"D:\Eng.rus";

        public FileWorker(Dictionary<string, string> vocab)
        {
            if (File.Exists(Path))
            {
                var lines = File.ReadAllLines(Path);
                foreach (var variable in lines)
                {
                    var values = variable.Split(',');
                    if (!vocab.ContainsKey(values[0]))
                    {
                        vocab.Add(values[0], values[1]);
                    }

                }
            }
            else
            {
                MessageBox.Show(@"File don't exist", @"File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FileWorker(DirectoryInfo path, Dictionary<string, string> dict)
        {
            var getDict = new Dictionary<string, string>();
            MessageBox.Show(path.GetFiles().Any() ? "Exist" : "No files found");
            if (path.GetFiles().Any())
            {
                foreach (var item in path.GetFiles())
                {
                    dict.Add(item.Name.Replace(".txt",""), item.OpenText().ReadToEnd());
                }
            }
        }
    }
}
