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

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();

            Dictionary<string, string> vocab = new Dictionary<string, string>();
            vocab.Add("World", "Мир");
            vocab.Add("Dog", "Пёс");
            vocab.Add("Cat", "Киска");
            vocab.Add("Car", "Машина");
            vocab.Add("Plane", "Самолёт");
            vocab.Add("Dick", "Член");
            vocab.Add("Boat", "Корабль");
            vocab.Add("Mobile", "Телефон");
            vocab.Add("Ass", "Жопа");
            vocab.Add("Door", "Двери");
            vocab.Add("Looser", "Лузер");
            vocab.Add("English", "Английский");

            watch.Stop();

            label3.Text = "сек на поиск " + (watch.Elapsed.TotalMilliseconds).ToString();
            label1.Text = vocab.TryGetValue(textBox1.Text.Trim(), out string result) ? result : "А Ш Ы Б К А ! ! !";

        }

    }
}
