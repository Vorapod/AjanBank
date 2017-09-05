using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private string Name { get; set; }
        string IP { get; set; }

        public Singleton()
        {
            Name = "ServerKobkiate";
            IP = "127.0.0.1";
        }

        static object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each
                // time the method is invoked
                lock (syncLock)
                {
                    if (_instance == null)
                        _instance = new Singleton();

                    return _instance;
                }
            }
        }
        public string GenerateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
