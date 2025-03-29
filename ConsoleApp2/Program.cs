namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem soundSystem = new SoundSystem(); //наш новый компонент

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, soundSystem); //не забыть сюда добавить soundSystem

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.EndMovie();
        }
    }
}
