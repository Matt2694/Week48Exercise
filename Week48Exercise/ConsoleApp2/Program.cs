using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private BroadcastService broadcastService = new BroadcastService("Broadcast");
        private TcpListener listener = null;
        private List<Thread> clientList = new List<Thread>();

        static void Main(string[] args)
        {
            Program server = new Program();

            server.Run();
        }

        private void Run()
        {
            try
            {
                listener = new TcpListener(5000);
                listener.Start();
                Console.WriteLine("Ready");
                ConnectClients();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                }
            }
        }

        private void ConnectClients()
        {
            Console.WriteLine("Waiting for incoming client connections...");
            HandleClient clientHandler;
            while (true)
            {
                clientHandler = new HandleClient(listener.AcceptTcpClient(), broadcastService);
                Console.WriteLine("Client Connected");
                clientList.Add(new Thread(new ThreadStart(clientHandler.DoStuff)));
                clientList[clientList.Count - 1].Start();
            }
        }
    }
}
