using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CinemaManager
    {
        private List<string> bookedSeats = new List<string>();

        public void BookSeat(string seat)
        {
            if (!bookedSeats.Contains(seat))
            {
                bookedSeats.Add(seat);
                Console.WriteLine($"Место {seat} успешно забронировано.");
            }
            else
            {
                Console.WriteLine($"Место {seat} уже занято.");
            }
        }

        public void CancelBooking(string seat)
        {
            if (bookedSeats.Contains(seat))
            {
                bookedSeats.Remove(seat);
                Console.WriteLine($"Бронирование места {seat} отменено.");
            }
            else
            {
                Console.WriteLine($"Место {seat} не было забронировано.");
            }
        }

        public void ShowAvailableSeats()
        {
            Console.WriteLine("Доступные места: " + string.Join(", ", bookedSeats));
        }
    }
}
