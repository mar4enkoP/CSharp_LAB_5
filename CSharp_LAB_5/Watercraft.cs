using System;

namespace CSharp_LAB_5
{
    /// <summary>
    /// Базовый класс "Плавсредство"
    /// </summary>
    public class Watercraft
    {
        private string _name;
        private string _type;
        private int _capacity;

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
                    _type = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
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
                if (value > 0)
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
        /// Создает новый экземпляр класса Watercraft с заданными значениями.
        /// </summary>
        public Watercraft(string name, string type, int capacity)
        {
            Name = name;
            Type = type;
            Capacity = capacity;
        }

        /// <summary>
        /// Возвращает строковое представление объекта Watercraft.
        /// </summary>
        public override string ToString()
        {
            return $"Name: {_name}\nType: {_type}\nCapacity: {_capacity}\n";
        }
    }
}
