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
        private Lighting _lighting;


        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, Lighting lighting)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _lighting = lighting;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");
            _lighting.Off();
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
            _lighting.On();
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _amplifier.Off();
            _projector.Off();
        }
    }
}
