using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogerLib
{
    class Message_Start
    {
        public void foo(object sonder)
        {
            string text = Console.ReadLine();
            Loger.WriteStream(text);
        }
        public void Start_program()
        {
            Event eventt = new Event();
            Message_Start message_Start = new Message_Start();
            eventt.ev += message_Start.foo;
            eventt.Ev_start();
        }
    }
}
