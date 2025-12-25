namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тестирование домашнего кинотеатра с кинотеатральными креслами ===\n");
            var amplifier = new Amplifier();
            var dvdPlayer = new DVDPlayer();
            var projector = new Projector();
            var cinemaSeats = new CinemaSeats();
            Console.WriteLine("1. Создание фасада с кинотеатральными креслами:");
            var homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, cinemaSeats);
            Console.WriteLine("\n   Настройка высоты кресел:");
            homeTheater.AdjustSeatHeight(75);
            Console.WriteLine("\n2. Начало просмотра фильма:");
            homeTheater.WatchMovie("Матрица");
            Console.WriteLine($"   Кресла в режиме просмотра: {homeTheater.AreSeatsInViewingMode()}");
            Console.WriteLine("\n3. Завершение просмотра:");
            homeTheater.EndMovie();
            Console.WriteLine($"   Кресла в режиме просмотра: {homeTheater.AreSeatsInViewingMode()}");
            Console.WriteLine("\n4. Проверка обратной совместимости:");
            var legacyHomeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector);
            legacyHomeTheater.WatchMovie("Начало");
            legacyHomeTheater.EndMovie();

            Console.WriteLine("\n=== Тестирование завершено успешно ===");
            Console.ReadLine();
        }
    }
}
