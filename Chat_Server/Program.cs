using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            new ServerChat("127.0.0.1", 12345).Start();
        }
    }
    class ServerChat
    {
        TcpListener listener;

        public ServerChat(string ip, int port)
        {
            listener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public void Start()
        {
            listener.Start();
            Console.WriteLine("Waiting for client...");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                new ClientWorker(client);
            }
        }
    }
    class ClientWorker
    {
        private TcpClient client;
        public ClientWorker(TcpClient client)
        {
            this.client = client;
            new Thread(Run).Start();
            Console.WriteLine("Client RemoteEndPoint = " + client.Client.RemoteEndPoint);
        }

        public void Run()
        {
            string message = "";
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            while (true)
            {
                message = sr.ReadLine();
                Console.WriteLine(client.Client.RemoteEndPoint + " : " + message);

                sw.WriteLine(message);
                sw.Flush();
                if (message == "Exit") break;
            }
            sr.Close();
            sw.Close();
        }
    }
    
}
