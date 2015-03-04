using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using event_sink001;

namespace event_sink001
{
    class test 
    {
        public void on_error(int i)
        {
            Console.WriteLine(i);
        }
        public void on_status(int i)
        {

        }

        public void test_evt()

        {
            event_source1.Class1 obj = new event_source1.Class1();
            obj.evt_handler += new event_source1.Class1.del_type(obj_evt_handler);
            obj.Fun("hello");
        }

        public void obj_evt_handler(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program 
    {
        
        static void Main(string[] args)
        {
            test obj = new test();
            obj.test_evt();
            
        }
    }
}
