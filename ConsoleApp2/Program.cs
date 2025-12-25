namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            LightingSystem lighting = new LightingSystem();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, lighting);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.EndMovie();
        }
    }
}