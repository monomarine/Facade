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
        private LightingSystem _lightingSystem; // Новая зависимость

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer,
                               Projector projector, LightingSystem lightingSystem) // Обновлённый конструктор
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _lightingSystem = lightingSystem; // Инициализация новой зависимости
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");
            _lightingSystem.Dim(10); // Приглушаем свет перед просмотром
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
            _lightingSystem.On(); // Включаем свет после просмотра
        }
    }
}