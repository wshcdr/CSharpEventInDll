using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace event_source1
{
    public class Class1
    {
        public delegate void del_type(string name);

        public event del_type evt_handler;


        public void Fun(string name) 
        {
            if (evt_handler != null) 
            {
                evt_handler(name + " from source");
            }
        }
    }
}
