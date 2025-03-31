using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private DVDPlayer _dvdPlayer;
        private Projector _projector;
        private CinemaManager _cinemaManager;

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, CinemaManager cinemaManager)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _cinemaManager = cinemaManager;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");
            _projector.On();
            _projector.SetInput("DVD");
            _amplifier.On();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Заканчиваем фильм...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _amplifier.Off();
            _projector.Off();
        }

        public void BookSeat(string seat)
        {
            _cinemaManager.BookSeat(seat);
        }

        public void CancelSeat(string seat)
        {
            _cinemaManager.CancelBooking(seat);
        }

        public void ShowSeats()
        {
            _cinemaManager.ShowAvailableSeats();
        }
    }
}
