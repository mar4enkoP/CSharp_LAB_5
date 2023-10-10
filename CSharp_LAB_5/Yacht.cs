using System;

namespace CSharp_LAB_5
{
    public class Yacht : Watercraft
    {
        private int _passengerCapacity;
        private string _owner;
        private string _registrationNumber;

        /// <summary>
        /// Вместимость пассажиров яхты.
        /// </summary>
        public int PassengerCapacity
        {
            get => _passengerCapacity;
            set
            {
                if (value >= 0)
                {
                    _passengerCapacity = value;
                }
                else
                {
                    throw new FormatException("Incorrect passenger capacity.");
                }
            }
        }

        /// <summary>
        /// Владелец яхты.
        /// </summary>
        public string Owner
        {
            get => _owner;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _owner = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect owner name.");
                }
            }
        }

        /// <summary>
        /// Регистрационный номер яхты.
        /// </summary>
        public string RegistrationNumber
        {
            get => _registrationNumber;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _registrationNumber = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect registration number.");
                }   
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Yacht, представляющий яхта.
        /// </summary>
        /// <param name="name">Название яхты</param>
        /// <param name="type">Тип яхты</param>
        /// <param name="capacity">Грузоподъемность яхты (в тонах)</param>
        /// <param name="manufacturer">Производитель яхты</param>
        /// <param name="year">Год выпуска яхты</param>
        /// <param name="passengerCapacity">Вместимость пассажиров яхты</param>
        /// <param name="owner">Владелец яхты</param>
        /// <param name="registrationNumber">Регистрационный номер яты</param>
        public Yacht(string name, string type, int capacity, string manufacturer, int year, int passengerCapacity, string owner, string registrationNumber) : base(name, type, capacity, manufacturer, year)
        {
            PassengerCapacity = passengerCapacity;
            Owner = owner;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return "Yacht:\n" + base.ToString() + $"Passenger Capacity: {PassengerCapacity}\nOwner: {Owner}\nRegistration Number: {RegistrationNumber}\n";
        }
    }
}