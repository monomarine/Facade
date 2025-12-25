namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== ДОМАШНИЙ КИНОТЕАТР ==========\n");
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector);

            homeTheater.WatchMovie("Гарри Поттер и принц-полукровка");
            homeTheater.EndMovie();

            Console.WriteLine("\n\n========== КИНОТЕАТР ==========\n");
            
            Cinema cinema = new Cinema();
            Screen screen = new Screen();
            TicketSystem ticketSystem = new TicketSystem();
            Lighting lighting = new Lighting();
            Amplifier cinemaAmplifier = new Amplifier();
            Projector cinemaProjector = new Projector();

            CinemaFacade cinemaFacade = new CinemaFacade(cinema, screen, ticketSystem, 
                                                         lighting, cinemaAmplifier, cinemaProjector);

            cinemaFacade.StartMovieSession("Аватар: Путь воды", 150);
            cinemaFacade.EndMovieSession();
        }
    }
}
