using System;

namespace CSharp_LAB_5
{
    /// <summary>
    /// Менеджер для работы с плавсредствами
    /// </summary>
    public class WatercraftManager
    {
        private Watercraft[] _watercraftArray;

        /// <summary>
        /// Создает новый экземпляр класса WatercraftManager.
        /// </summary>
        public WatercraftManager()
        {
            _watercraftArray = new Watercraft[0];
        }

        /// <summary>
        /// Добавление плавсредства в массив.
        /// </summary>
        public void AddWatercraft(Watercraft watercraft)
        {
            Array.Resize(ref _watercraftArray, _watercraftArray.Length + 1);
            _watercraftArray[_watercraftArray.Length - 1] = watercraft;
        }

        /// <summary>
        /// Удаление плавсредства из массива по индексу.
        /// </summary>
        public void RemoveWatercraft(int index)
        {
            if (index >= 0 && index < _watercraftArray.Length)
            {
                Array.Copy(_watercraftArray, index + 1, _watercraftArray, index, _watercraftArray.Length - index - 1);
                Array.Resize(ref _watercraftArray, _watercraftArray.Length - 1);
            }
        }

        /// <summary>
        /// Редактирование плавсредства в массиве по индексу.
        /// </summary>
        public void EditWatercraft(int index, Watercraft watercraft)
        {
            if (index >= 0 && index < _watercraftArray.Length)
            {
                _watercraftArray[index] = watercraft;
            }
        }

        /// <summary>
        /// Возвращает массив плавсредств.
        /// </summary>
        public Watercraft[] GetWatercraftArray()
        {
            return _watercraftArray;
        }
    }
}