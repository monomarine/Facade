using System;

namespace ConsoleApp2
{
    internal class LightingSystem
    {
        public void Dim(int percent) => Console.WriteLine($"Освещение затемнено до {percent}%");
        public void Bright() => Console.WriteLine("Освещение восстановлено");
    }
}