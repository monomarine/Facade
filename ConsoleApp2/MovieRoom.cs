using System;

namespace ConsoleApp2
{
    /// <summary>
    /// Представляет кинозал с его характеристиками(сам кинозал, его вместимость, подготовлен/не подготовлен и зрители)
    /// </summary>
    public class MovieRoom
    {
        private readonly string _roomName;
        private readonly int _capacity;
        private bool _isPrepared;
        private int _currentVisitors;

        public string RoomName => _roomName;
        public int Capacity => _capacity;
        public bool IsPrepared => _isPrepared;
        public int CurrentVisitors => _currentVisitors;

        public MovieRoom(string roomName, int capacity)
        {
            _roomName = roomName;
            _capacity = capacity;
            _isPrepared = true;
            _currentVisitors = 20;
        }

        public void ReadyToMovie()
        {
            if (_isPrepared)
            {
                Console.WriteLine($"Кинозал {_roomName} уже подготовлен");
                return;
            }

            Console.WriteLine($"Номер комнаты где бует просмотр фильма: {_roomName}");
            Console.WriteLine($"Вместимость мест: {_capacity}");
            Console.WriteLine("Кинозал готов к показу фильма");

            _isPrepared = true;
        }

        public void EndMovieRoom()
        {
            if (!_isPrepared)
            {
                Console.WriteLine($"Кинозал {_roomName} не был подготовлен");
                return;
            }

            Console.WriteLine($"Завершение сеанса в кинозале {_roomName}. Кинозал закрыт");
            _isPrepared = false;
            _currentVisitors = 0;
        }

  
        public void DisplayInfo()
        {
         
            Console.WriteLine($"Название: {_roomName}");
            Console.WriteLine($"Вместимость: {_capacity} мест");
            Console.WriteLine($"Текущее количество зрителей: {_currentVisitors}");
            Console.WriteLine($"Статус: {(_isPrepared ? "Подготовлен" : "Не подготовлен")}");
        }

  
    }
}