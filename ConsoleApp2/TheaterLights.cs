using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TheaterLights
    {
        public void On() => Console.WriteLine("Освещение кинотеатра включено");
        public void Off() => Console.WriteLine("Освещение кинотеатра выключено");
        public void Dim(int level) => Console.WriteLine($"Освещение приглушено до уровня {level}%");

        // Крутое плавное изменение яроксти! Попов был шокирован увидя это!
        public void AdjustBrightness(int from, int to, int durationSeconds)
        {
            Console.WriteLine($"Плавное изменение яркости с {from}% до {to}% за {durationSeconds} секунд");
        }
    }
}