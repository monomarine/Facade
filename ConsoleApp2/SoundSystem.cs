using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SoundSystem
    {
        public void On() => Console.WriteLine("Акустика включена");
        public void Off() => Console.WriteLine("Акустика выключена");
        public void SetVolume(int  volume) => Console.WriteLine($"Уровень громкости: {volume}");
    }
}
