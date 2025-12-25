namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            TheaterLights lights = new TheaterLights();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, lights);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");

            // Демонстрация
            homeTheater.PauseMovie();
            homeTheater.ResumeMovie();

            homeTheater.EndMovie();
        }
    }
}