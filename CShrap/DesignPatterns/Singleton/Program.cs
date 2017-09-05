using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss.fff"));
            Console.WriteLine(Singleton.Instance.GenerateGuid());

            Console.WriteLine(Singleton.Instance.GenerateGuid());
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss.fff"));

            Console.ReadKey();
        }
    }
}
