using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Screen
    {
        public void Prepare() => Console.WriteLine("Экран подготовлен к показу");
        public void ShowMovie(string movie) => Console.WriteLine($"На экране показывается: {movie}");
        public void ShowTrailers() => Console.WriteLine("Показываются трейлеры");
        public void TurnOff() => Console.WriteLine("Экран выключен");
    }
}
