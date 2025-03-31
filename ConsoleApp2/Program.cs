namespace ConsoleApp2
{
    /// <summary>
    /// ФИО: Персиянцев Тимофей Сергеевич
    /// Задание: 1 внедрите в проект новую сущность для работы с кинотеатром.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem soundSystem = new SoundSystem();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amplifier,
                dvdPlayer,
                projector,
                soundSystem);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.EndMovie();

            Console.ReadKey();
        }
    }
}
