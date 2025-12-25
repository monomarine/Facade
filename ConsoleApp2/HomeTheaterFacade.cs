using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private DVDPlayer dvdPlayer;
        private Projector projector;
        private LightingSystem lighting;

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, LightingSystem lighting)
        {
            this.amplifier = amplifier;
            this.dvdPlayer = dvdPlayer;
            this.projector = projector;
            this.lighting = lighting;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine($"\nНачинаем просмотр фильма");
            lighting.Dim(10);
            projector.On();
            projector.SetInput("DVD");
            amplifier.On();
            amplifier.SetVolume(25);
            dvdPlayer.On();
            dvdPlayer.Play(movie);
            Console.WriteLine($" Наслаждайтесь просмотром!\n");
        }

        public void EndMovie()
        {
            Console.WriteLine($"\nЗавершаем просмотр фильма");
            dvdPlayer.Stop();
            dvdPlayer.Off();
            amplifier.Off();
            projector.Off();
            lighting.On();
            Console.WriteLine($"Просмотр завершен\n");
        }
    }
}