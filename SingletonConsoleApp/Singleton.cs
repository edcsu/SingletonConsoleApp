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

        private static Singleton Instance 
        { 
            get
            {
                _instance ??= new Singleton();

                return _instance;
            }
        }

        private Singleton() { }
    }
}
