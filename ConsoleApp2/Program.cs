namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            CinemaManager cinemaManager = new CinemaManager(); // Новый объект

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, cinemaManager);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.BookSeat("A1");
            homeTheater.BookSeat("A2");
            homeTheater.ShowSeats();
            homeTheater.EndMovie();
        }
    }
}
