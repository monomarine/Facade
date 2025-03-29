namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            AcousticsKit acousticsKit = new AcousticsKit();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, acousticsKit);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.EndMovie();
        }
    }
}
