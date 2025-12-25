using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cinema
    {
        public void Open() => Console.WriteLine(" инотеатр открыт");
        public void Close() => Console.WriteLine(" инотеатр закрыт");
        public void Announce(string message) => Console.WriteLine($"ќбъ€вление: {message}");
    }
}
