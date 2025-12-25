using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Servant
    {
        public void Bring() => Console.WriteLine("Слуга принес попкорн и напитки.Приятного просмотра!");
        public void Put() => Console.WriteLine("Слуга унес попкорн и напитки.Как вам фильм?");

        public void Grade() => Console.ReadLine();
    }
}
