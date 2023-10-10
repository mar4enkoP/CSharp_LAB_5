using System;

namespace CSharp_LAB_5
{
    public class Barge : Watercraft
    {
        private int _cargoCapacity;
        private string _cargoType;
        private bool _hasCrane;

        /// <summary>
        /// Грузоподъемность баржи (в тоннах).
        /// </summary>
        public int CargoCapacity
        {
            get => _cargoCapacity;
            set
            {
                if (value >= 0)
                {
                    _cargoCapacity = value;
                }
                else
                {
                    throw new FormatException("Incorrect cargo capacity.");
                }
            }
        }

        /// <summary>
        /// Тип груза, который может перевозить баржа.
        /// </summary>
        public string CargoType
        {
            get => _cargoType;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _cargoType = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect cargo type.");
                }
            }
        }

        
        /// <summary>
        /// Наличие крана на барже.
        /// </summary>
        public bool HasCrane
        {
            get => _hasCrane;
            set => _hasCrane = value;
        }
        /// <summary>
        /// Создает новый экземпляр класса Barge, представляющий баржу.
        /// </summary>
        /// <param name="name">Название баржи</param>
        /// <param name="type">Тип баржи</param>
        /// <param name="capacity">Грузоподъемность баржи (в тоннах)</param>
        /// <param name="manufacturer">Производитель баржи</param>
        /// <param name="year">Год выпуска баржи</param>
        /// <param name="cargoCapacity">Грузоподъемность баржи (в тоннах)</param>
        /// <param name="cargoType">Тип груза, который может перевозить баржа</param>
        /// <param name="hasCrane">Наличие крана на барже</param>
        public Barge(string name, string type, int capacity, string manufacturer, int year, int cargoCapacity, string cargoType, bool hasCrane) : base(name, type, capacity, manufacturer, year)
        {
            CargoCapacity = cargoCapacity;
            CargoType = cargoType;
            HasCrane = hasCrane;
        }

        public override string ToString()
        {
            return "Barge:\n" + base.ToString() + $"Cargo Capacity: {CargoCapacity} tons\nCargo Type: {CargoType}\nHas Crane: {HasCrane}\n";
        }
    }
}