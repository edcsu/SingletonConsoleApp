using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{
    public sealed class Singleton
    {
        private static Singleton _instance = default!;

        private static object _lock = new ();

        private static Singleton Instance 
        { 
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        _instance ??= new Singleton();

                        return _instance;
                    }
                }

                return _instance;
            }
        }

        private Singleton() { }
    }
}
