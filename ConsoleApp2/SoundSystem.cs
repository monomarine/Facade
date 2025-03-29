using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SoundSystem //Новый класс SoundSystem и его функции(вкл, выкл)
    {
        public void On() => Console.WriteLine("Звуковая система включена");
        public void Off() => Console.WriteLine("Звуковая система выключена");
    }
}
