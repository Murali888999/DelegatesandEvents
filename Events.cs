using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    public delegate void linktoEventHandler();
    class Events2
    {
        string name;
        public Events2(string s)
        {
            name = s;
        }
        public void eventhandler()
        {
            Console.WriteLine("Notification from :" + name);
        }
    }
    class Events
    {
        public static event linktoEventHandler evt;
        public static void sendnotification()
        {
            if(evt != null)
            {
                evt();
            }
        }
        static void Main(string[] args)
        {
            Events2 obj1 = new Events2("object1");
            evt = new linktoEventHandler(obj1.eventhandler);

            Events2 obj2 = new Events2("object2");
            evt += new linktoEventHandler(obj2.eventhandler);

            Events2 obj3 = new Events2("object3");
            evt += new linktoEventHandler(obj3.eventhandler);

            sendnotification();
            Console.ReadKey();
        }
    }
}