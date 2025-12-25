using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PopcornMachine
    {
        public void On() => Console.WriteLine("Попкорница включена и начала готовить попкорн");
        public void Off() => Console.WriteLine("Попкорница выключена");
        public void AddButter() => Console.WriteLine("Добавлено масло в попкорн");
        public void AddSalt() => Console.WriteLine("Добавлена соль в попкорн");
    }
}
