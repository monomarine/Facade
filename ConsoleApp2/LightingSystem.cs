using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LightingSystem
    {
        public void On() => Console.WriteLine("Освещение включено");
        public void Off() => Console.WriteLine("Освещение выключено");
        public void Dim(int level) => Console.WriteLine($"Яркость освещения установлена на {level}%");
    }
}