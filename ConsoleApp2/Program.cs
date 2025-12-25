namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            Music music = new Music();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, music);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка", "Белые ночи");
            homeTheater.EndMovie();
        }
    }
}
