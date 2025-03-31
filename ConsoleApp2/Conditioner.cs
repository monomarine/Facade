using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Conditioner
    {
        public void On() => Console.WriteLine("Кондиционер включен");
        public void Off() => Console.WriteLine("Кондиционер выключен");
        public void SetTemperature(int temperature) => Console.WriteLine($"Установлена температура на {temperature} градуса(ов) по Цельсию");
    }
}
