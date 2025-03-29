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
        private AcousticsKit _acousticsKit;

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, AcousticsKit acousticsKit)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _acousticsKit = acousticsKit;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");
            _projector.On();
            _projector.SetInput("DVD");
            _amplifier.On();
            _amplifier.SetVolume(5);
            _acousticsKit.On();
            _acousticsKit.ConnectionAmplifier(_amplifier);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Заканчиваем фильм...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _amplifier.Off();
            _acousticsKit.OffConnectionAmplifier();
            _acousticsKit.Off();
            _projector.Off();
        }
    }
}
