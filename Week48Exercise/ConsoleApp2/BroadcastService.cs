using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BroadcastService
    {
        public delegate void BroadCastEventHandler(string msg);
        public event BroadCastEventHandler BroadCastEvent;
        public int currentValue;

        public BroadcastService(string name)
        {
            this.name = name;
            currentValue = -1;
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        public void BroadCastMessage(string msg)
        {
            if (this.BroadCastEvent != null)
                BroadCastEvent(msg); //fire the event (whatever it was) to all subscribers
        }
    }
}
