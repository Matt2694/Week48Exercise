using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceValueChanger
{
    class Program
    {
        private bool running = true;
        private Service.ServiceClient service = new Service.ServiceClient();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            string input = "";
            while (running)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "close": running = false; break;
                    default: service.AddData(input); break;
                }
            }
        }
    }
}
