using System;
using System.IO;
using System.Net.Sockets;

namespace ConsoleApp2
{
    internal class HandleClient
    {
        private Service.ServiceClient service = new Service.ServiceClient();
        private TcpClient client;
        private StreamReader reader = null;
        private StreamWriter writer = null;

        public HandleClient(TcpClient newClient)
        {
            client = newClient;
        }

        public void InformationAboutDirectory()
        {
            try
            {
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;

                while (true)
                {
                    writer.WriteLine(service.GetData());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}