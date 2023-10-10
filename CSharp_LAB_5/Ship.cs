using System;

namespace CSharp_LAB_5
{
    public class Ship : Watercraft
    {
        private string _shipType;
        private int _maxSpeed;
        private int _crewSize;

        /// <summary>
        /// Установка и получение поля _shipType, описывающего тип судна.
        /// </summary>
        public string ShipType
        {
            get => _shipType;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _shipType = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect ship type.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _maxSpeed, описывающего максимальную скорость судна.
        /// </summary>
        public int MaxSpeed
        {
            get => _maxSpeed;
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    throw new FormatException("Incorrect maximum speed.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _crewSize, описывающего размер экипажа судна.
        /// </summary>
        public int CrewSize
        {
            get => _crewSize;
            set
            {
                if (value >= 0)
                {
                    _crewSize = value;
                }
                else
                {
                    throw new FormatException("Incorrect crew size.");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Ship с заданными значениями.
        /// </summary>
        /// <param name="name">Имя плавсредства</param>
        /// <param name="type">Тип плавсредства</param>
        /// <param name="capacity">Вместимость плавсредства</param>
        /// <param name="manufacturer">Производитель плавсредства</param>
        /// <param name="year">Год выпуска плавсредства</param>
        /// <param name="shipType">Тип корабля ( грузовой, пассажирский .юю)</param>
        /// <param name="maxSpeed">Максимальная скорость корабля (в узах)</param>
        /// <param name="crewSize">Размер экипажа корабля</param>
        public Ship(string name, string type, int capacity, string manufacturer, int year, string shipType, int maxSpeed, int crewSize) : base(name, type, capacity, manufacturer, year)
        {
            ShipType = shipType;
            MaxSpeed = maxSpeed;
            CrewSize = crewSize;
        }

        /// <summary>
        /// Переопределение метода ToString() для получения строкового представления объекта Ship.
        /// </summary>
        public override string ToString()
        {
            return "Ship:\n" + base.ToString() + $"Ship Type: {ShipType}\nMaximum Speed: {MaxSpeed} knots\nCrew Size: {CrewSize}\n";
        }
    }
}
