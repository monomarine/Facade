using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lighting
    {
        public void TurnOn() => Console.WriteLine("Освещение включено");
        public void TurnOff() => Console.WriteLine("Освещение выключено");
        public void Dim(int level) => Console.WriteLine($"Освещение приглушено до уровня {level}%");
    }
}
