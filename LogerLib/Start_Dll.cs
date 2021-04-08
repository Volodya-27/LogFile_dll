using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogerLib;
namespace LogerLib
{
    public static class Start_Dll
    {
        public static void st()
        {
            Message_Start message_Start = new Message_Start();
            message_Start.Start_program();
        }
    }
}
