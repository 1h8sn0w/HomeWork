using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Chat_Client
{
    public partial class FormChat : Form
    {
        private const int port = 12345;
        private const string address = "127.0.0.1";
        private StreamReader _sr;
        private StreamWriter _sw;
        private TcpClient client;
        private bool autorized;

        public FormChat()
        {
            InitializeComponent();
        }

        private void TextBoxChatInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var message = textBoxChatInput.Text;

            //textBoxChat.AppendText("\r\nNot autorized, type login");
            //textBoxChat.AppendText("\r\nYour name is " + message);
            var auth = new Auth();
            if (autorized == false)
            {
                if (auth.AuthCheck(message))
                {
                    textBoxChat.AppendText("\r\nAutorized");
                    autorized = true;
                }
                else
                {
                    textBoxChat.AppendText("\r\nNot Autorized");
                }
            }
            else
            {
                _sw.WriteLine(message);
                _sw.Flush();
                var answer = _sr.ReadLine();
                textBoxChat.AppendText("\r\nAnswer: " + answer);
            }

            //        textBoxChat.AppendText("\r\nAutorized = true");
            //        autorized = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxIP.Text = address;
            textBoxIP.Text += @": " + port;
            textBoxName.Text = @"unautorized";
            try
            {
                button1.Enabled = false;
                client = new TcpClient(address, port);
                _sr = new StreamReader(client.GetStream());
                _sw = new StreamWriter(client.GetStream());
                textBoxChat.AppendText("\r\nConnected " + client.Client.RemoteEndPoint);
                textBoxChat.AppendText("\r\nType your nickname");
                textBoxChat.AppendText("\r\nThan type your password, if match found you will be connectad");
            }
            catch (Exception exception)
            {
                textBoxChat.Text = exception.ToString();
                throw;
            }
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            _sw.WriteLine("Exit");
            _sw.Flush();
            _sw.Close();
            _sr.Close();
        }
    }
}