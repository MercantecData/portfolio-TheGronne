using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace Computer_Teknologi_Projekt_Server
{
    class Server
    {
        public static int usersCounter;
        public static int arrayCounter;
        public static List<TcpClient> clients = new List<TcpClient>();
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Any;
            int port = 13356;
            TcpListener listener = new TcpListener(ip, port);
            listener.Start();

            AcceptClients(listener);

            Console.WriteLine("Server is up.");

            bool isRunning = true;
            while(isRunning)
            {
                //Send a Message
                string text = Console.ReadLine();
                byte[] buffer = Encoding.UTF8.GetBytes("Server writes: " + text);
                //stream.Write(buffer, 0, buffer.Length);
                foreach(TcpClient client in clients)
                {
                    client.GetStream().Write(buffer, 0, buffer.Length);
                }
            }
        }

        static async void ReceiveMessages(NetworkStream stream)
        {
            byte[] buffer = new byte[256];
            bool isRunning = true;
            while (isRunning) 
            {
                int read = await stream.ReadAsync(buffer, 0, buffer.Length);
                string text = Encoding.UTF8.GetString(buffer, 0, read);
                Console.WriteLine(text);

                if (text.Contains("ready"))
                {
                    arrayCounter++;
                }
                if (arrayCounter == usersCounter)
                {
                    teamBetting();
                }
            }
            
        }
        public static async void AcceptClients(TcpListener listener)
        {
            bool isRunning = true;
            while (isRunning)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                clients.Add(client);
                usersCounter++;
                NetworkStream stream = client.GetStream();
                ReceiveMessages(stream);
            }
        }
        public static void teamBetting()
        {
            Console.WriteLine("Game has started!");
        }
    }
}

