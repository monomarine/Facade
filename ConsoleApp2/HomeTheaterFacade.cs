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
        private ICinemaSeats _cinemaSeats; 

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, ICinemaSeats cinemaSeats)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _cinemaSeats = cinemaSeats;
        }
        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector)
            : this(amplifier, dvdPlayer, projector, new CinemaSeats())
        {
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");

            _cinemaSeats.AdjustToViewingPosition();

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
            _cinemaSeats.AdjustToDefaultPosition();
        }
        public void AdjustSeatHeight(int height)
        {
            _cinemaSeats.AdjustSeatHeight(height);
        }
        public bool AreSeatsInViewingMode()
        {
            return _cinemaSeats.IsInViewingMode;
        }
    }
}
