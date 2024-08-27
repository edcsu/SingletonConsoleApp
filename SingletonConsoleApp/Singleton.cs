using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _lazyInstance = new(() => new Singleton());

        public static Singleton Instance => _lazyInstance.Value;

        private Singleton() 
        {
            Console.WriteLine("Instantiating singleton");
        }
    }
}
