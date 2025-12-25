using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CinemaFacade
    {
        private Cinema _cinema;
        private Screen _screen;
        private TicketSystem _ticketSystem;
        private Lighting _lighting;
        private Amplifier _amplifier;
        private Projector _projector;

        public CinemaFacade(Cinema cinema, Screen screen, TicketSystem ticketSystem, 
                           Lighting lighting, Amplifier amplifier, Projector projector)
        {
            _cinema = cinema;
            _screen = screen;
            _ticketSystem = ticketSystem;
            _lighting = lighting;
            _amplifier = amplifier;
            _projector = projector;
        }

        public void StartMovieSession(string movie, int tickets)
        {
            Console.WriteLine("=== Начало киносеанса ===");
            _cinema.Open();
            _ticketSystem.Start();
            _ticketSystem.SellTicket(movie, tickets);
            _cinema.Announce($"Сеанс фильма '{movie}' начнется через 5 минут");
            _lighting.TurnOn();
            Console.WriteLine("\nПодготовка к показу...");
            _projector.On();
            _projector.SetInput("Cinema");
            _screen.Prepare();
            _amplifier.On();
            _amplifier.SetVolume(8);
            _screen.ShowTrailers();
            Console.WriteLine("\nНачинаем основной фильм...");
            _lighting.Dim(10);
            _screen.ShowMovie(movie);
        }

        public void EndMovieSession()
        {
            Console.WriteLine("\n=== Окончание киносеанса ===");
            _screen.TurnOff();
            _amplifier.Off();
            _projector.Off();
            _lighting.TurnOn();
            _cinema.Announce("Спасибо за посещение! До новых встреч!");
            _ticketSystem.Stop();
            _cinema.Close();
        }
    }
}
