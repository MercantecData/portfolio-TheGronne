using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Computer_Teknologi_Projekt_Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            TcpClient client = new TcpClient();

            int port = 13356;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(ip, port);

            client.Connect(endPoint);

            NetworkStream stream = client.GetStream();

            byte[] buffer1 = Encoding.UTF8.GetBytes(username + " has connected.");

            stream.Write(buffer1, 0, buffer1.Length);
            
            while (true)
            {
                ReceiveMessage(stream);

                string text = Console.ReadLine();
                Console.WriteLine("You wrote: " + text);
                byte[] buffer = Encoding.UTF8.GetBytes(username + " says: " + text);

                stream.Write(buffer, 0, buffer.Length);
            }
        }
        public static async void ReceiveMessage(NetworkStream stream)
        {
            byte[] buffer = new byte[256];
            bool isRunning = true;
            while (isRunning)
            {
                int numberOfBytesRead = await stream.ReadAsync(buffer, 0, 256);
                string receiveMessage = Encoding.UTF8.GetString(buffer, 0, numberOfBytesRead);
                Console.WriteLine(receiveMessage);
            }
        }
    }
}
