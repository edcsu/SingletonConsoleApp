using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{
    public sealed class Singleton
    {
        public static Singleton Instance => Nested.Instance;

        private class Nested
        {
            internal static Singleton Instance { get; } = new();
            
            static Nested()
            {
            }
        }

        private Singleton() 
        {
            Console.WriteLine("Instantiating singleton");
        }
        
        static Singleton() 
        {
        }
    }
}
