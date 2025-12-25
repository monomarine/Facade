using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Music
    {
        public void On() => Console.WriteLine("Музыка включена!");
        public void Off() => Console.WriteLine("Музыка выключена!");
        public void SetMusic(string name) => Console.WriteLine($"Играет следующая мелодия: {name}");
    }
}
