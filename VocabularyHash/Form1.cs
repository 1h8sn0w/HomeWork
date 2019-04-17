using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace VocabularyHash
{
    public partial class Form1 : Form
    {
        public string Userinput;
        public Dictionary<string, string> vocab = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            Userinput = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var file = new FileWorker(vocab);

            label1.Text = vocab.TryGetValue(textBox1.Text.Trim(), out var result) ? result : "А Ш Ы Б К А ! ! !";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var file = new SaveToFile(vocab, @"D:\task\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var revDict = new Dictionary<string, string>();
            var reverse = new ReverseDict(vocab, revDict);
            var file = new SaveToFile(revDict, @"D:\task\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var vocab2 = new Dictionary<string, string>();
            var exist = new FileWorker(new DirectoryInfo(@"D:\task\"), vocab2);
            foreach (var variable in vocab2)
            {
                label3.Text = label3.Text + variable.Key.ToString() + " ";
                label3.Text = label3.Text + variable.Value.ToString() + "\n"; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var file = new SaveToFile(vocab);
        }
    }
}