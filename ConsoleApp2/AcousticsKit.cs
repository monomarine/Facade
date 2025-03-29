using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AcousticsKit
    {
        public void On() => Console.WriteLine("Акустическая система включена");
        public void Off() => Console.WriteLine("Акустическая система выключена");

        public void ConnectionAmplifier(Amplifier amplifier) => Console.WriteLine($"К акустической системе подключен усилитель");

        public void OffConnectionAmplifier() => Console.WriteLine($"Усилитель отключен от акустической системы");

    }
}
