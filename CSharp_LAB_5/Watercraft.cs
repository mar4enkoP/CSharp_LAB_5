using System;

namespace CSharp_LAB_5
{
    /// <summary>
    /// Класс Watercraft содержит общую информацию о плавсредстве.
    /// </summary>
    public class Watercraft
    {
        private string _name;
        private string _type;
        private int _capacity;
        private string _manufacturer;
        private int _year;

        /// <summary>
        /// Установка и получение поля _name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _type.
        /// </summary>
        public string Type
        {
            get => _type;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _type = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect type.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _capacity.
        /// </summary>
        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value >= 0)
                {
                    _capacity = value;
                }
                else
                {
                    throw new FormatException("Incorrect capacity.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _manufacturer.
        /// </summary>
        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _manufacturer = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect manufacturer.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _year.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                if (value >= 0)
                {
                    _year = value;
                }
                else
                {
                    throw new FormatException("Incorrect year.");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Watercraft с заданными значениями.
        /// </summary>
        public Watercraft(string name, string type, int capacity, string manufacturer, int year)
        {
            Name = name;
            Type = type;
            Capacity = capacity;
            Manufacturer = manufacturer;
            Year = year;
        }

        /// <summary>
        /// Возвращает строковое представление объекта Watercraft.
        /// </summary>
        public override string ToString()
        {
            return $"Name: {Name}\nType: {Type}\nCapacity: {Capacity}\nManufacturer: {Manufacturer}\nYear: {Year}\n";
        }
    }
}
