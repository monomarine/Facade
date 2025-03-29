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
        private SoundSystem _soundSystem; // добавим новый компонент SoundSystem (устройства вывода)

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, SoundSystem soundSystem)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _soundSystem = soundSystem;//добавляем тот же компонент
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");
            _soundSystem.On();//прописываем вкючение
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
            _soundSystem.Off(); //выключение нашей звуковой системы
            _dvdPlayer.Off();
            _amplifier.Off();
            _projector.Off();
        }
    }
}
