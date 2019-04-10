using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    
    public partial class Form1 : Form
    {
        public string userinput;

        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            userinput = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();

            Vocab vocab = new Vocab();
            vocab.AddNode(new Word("World", "Мир"));            
            vocab.AddNode(new Word("Dog", "Пёс"));
            vocab.AddNode(new Word("Cat", "Киска"));
            vocab.AddNode(new Word("Car", "Машина"));
            vocab.AddNode(new Word("Plane", "Самолёт"));
            vocab.AddNode(new Word("Dick", "Член"));
            vocab.AddNode(new Word("Boat", "Корабль"));
            vocab.AddNode(new Word("Mobile", "Телефон"));
            vocab.AddNode(new Word("Ass", "Жопа"));
            vocab.AddNode(new Word("Door", "Двери"));
            vocab.AddNode(new Word("Looser", "Лузер"));
            vocab.AddNode(new Word("English", "Английский"));

            

            Node result = vocab.FindNode(new Word(textBox1.Text, null));

            watch.Stop();

            label3.Text = "сек на поиск " +  (watch.Elapsed.TotalMilliseconds).ToString();
            label1.Text = result.Data.Rus.ToString();

        }

    }
}
