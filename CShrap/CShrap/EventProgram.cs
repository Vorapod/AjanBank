using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrap
{
    class MyTestApp
    {
        //The Event Handler declaration
        public delegate void EventHandler();

        //The Event declaration
        public event EventHandler MyEvent;

        //The method to call
        public void Hello()
        {
            Console.WriteLine("Hello World of events!");
        }

        public void Process()
        {
            MyEvent();
        }

        public static void Main()
        {
            MyTestApp TestApp = new MyTestApp();

            //Assign the method to be called when the event is fired
            TestApp.MyEvent += TestApp_MyEvent;

            TestApp.Process();
            Console.ReadKey();



        }

        private static void TestApp_MyEvent()
        {
            Console.Write("Local Method");
        }
    }
}
