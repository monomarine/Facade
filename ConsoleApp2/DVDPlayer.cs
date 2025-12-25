using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD-плеер включен");
        public void Off() => Console.WriteLine("DVD-плеер выключен");
        public void Play(string movie) => Console.WriteLine($"Воспроизведение фильма: {movie}");
        public void Stop() => Console.WriteLine("Воспроизведение остановлено");
    }
}