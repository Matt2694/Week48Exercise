using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ConsoleApp2
{
    internal class HandleClient
    {
        private Service.ServiceClient service = new Service.ServiceClient();
        private BroadcastService broadcastService;
        private TcpClient client;
        private StreamReader reader = null;
        private StreamWriter writer = null;
        private object o = new object();

        public HandleClient(TcpClient newClient, BroadcastService newBroadcastService)
        {
            client = newClient;
            broadcastService = newBroadcastService;
        }

        public void DoStuff()
        {
            try
            {
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;

                Dialog();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void SendMessageToClient(string text)
        {
            writer.WriteLine(text);
            writer.Flush();
        }

        private void Dialog()
        {
            try
            {
                SendMessageToClient("Enter: <bye> to end communication");
                broadcastService.BroadCastEvent += this.BroadcastAction; //Which method to fire when ready (subscription)

                while (ExecuteCommand()) ;
            }
            catch
            {
            }
            finally
            {
                broadcastService.BroadCastEvent -= this.BroadcastAction; //unsubscribe
            }
        }

        private bool ExecuteCommand()
        {
            int value = service.GetData();
            lock (o)
            {
                if (broadcastService.currentValue != value)
                {
                    broadcastService.currentValue = value;
                    string input = value.ToString();

                    broadcastService.BroadCastMessage(input); //Fire the event
                }
            }
            Thread.Sleep(5000);
            return true;
        }

        public void BroadcastAction(string msg)
        {
            SendMessageToClient("Broadcast:" + msg);
        }
    }
}