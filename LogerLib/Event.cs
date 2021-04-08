using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogerLib
{
    class Event
    {
        public event Action<object> ev;
        public void Ev_start()
        {
            ev(this);
        }
    }
}
