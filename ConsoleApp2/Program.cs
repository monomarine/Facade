namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            LightingSystem lightingSystem = new LightingSystem(); // Создаём новую сущность

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amplifier, dvdPlayer, projector, lightingSystem); // Передаём все компоненты

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.EndMovie();
        }
    }
}