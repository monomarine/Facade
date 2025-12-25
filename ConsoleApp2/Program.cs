namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem soundSystem = new SoundSystem();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector,soundSystem);

            homeTheater.WatchMovie("Звездные воины III Месть ситхов");
            homeTheater.EndMovie();
        }
    }
}
