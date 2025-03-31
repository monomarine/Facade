using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SoundSystem
    {
        public void On() => Console.WriteLine("Аудиосистема включена");
        public void Off() => Console.WriteLine("Аудиосистема выключена");
        public void SetMode(string mode) => Console.WriteLine($"Режим звука установлен на: {mode}");
    }
}
