using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CinemaSeats : ICinemaSeats
    {
        private bool _isInViewingMode;
        private int _seatHeight;

        public bool IsInViewingMode => _isInViewingMode;

        public void AdjustToViewingPosition()
        {
            Console.WriteLine("Кинотеатральные кресла: Установка в режим просмотра");
            Console.WriteLine("Кинотеатральные кресла: Откидывание спинки на 45 градусов");
            Console.WriteLine("Кинотеатральные кресла: Выдвижение подставки для ног");
            _isInViewingMode = true;
            _seatHeight = 50;
        }

        public void AdjustToDefaultPosition()
        {
            Console.WriteLine("Кинотеатральные кресла: Возврат в исходное положение");
            Console.WriteLine("Кинотеатральные кресла: Возврат спинки в вертикальное положение");
            Console.WriteLine("Кинотеатральные кресла: Складывание подставки для ног");
            _isInViewingMode = false;
            _seatHeight = 40;
        }

        public void AdjustSeatHeight(int height)
        {
            if (height < 30 || height > 100)
            {
                Console.WriteLine($"Кинотеатральные кресла: Недопустимая высота {height}%. Допустимо от 30 до 100%");
                return;
            }

            _seatHeight = height;
            Console.WriteLine($"Кинотеатральные кресла: Установка высоты сиденья на {height}%");
        }
    }
}
