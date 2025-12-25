using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SoundSystem
    {
        public void On() => Console.WriteLine("Музыкальная система включена");
        public void Off() => Console.WriteLine("Музыкальная система выключена");
        public void Play(string music) => Console.WriteLine($"Музыка играет: {music}");
        public void Stop() => Console.WriteLine("Музыка не играет");
    }
}
