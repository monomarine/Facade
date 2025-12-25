using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TicketSystem
    {
        public void Start() => Console.WriteLine("Система продажи билетов запущена");
        public void SellTicket(string movie, int seats) => Console.WriteLine($"Продано {seats} билетов на фильм '{movie}'");
        public void Stop() => Console.WriteLine("Система продажи билетов остановлена");
    }
}
