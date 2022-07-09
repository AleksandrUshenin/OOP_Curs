using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTab
{
    public class Item<T>
    {
        /// <summary>
        /// Ключ.
        /// </summary>
        public string Key { get; private set; }
        /// <summary>
        /// Хранимые данные.
        /// </summary>
        public T Value { get; private set; }


        /// <summary>
        /// Создать новый экземпляр хранимых данных Item.
        /// </summary>
        /// <param name="key"> Ключ. </param>
        /// <param name="value"> Значение. </param>
        public Item(string key, T value)
        {
            // Проверяем входные данные на корректность.
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            // Устанавливаем значения.
            Key = key;
            Value = value;
        }

        private string nameof(T value)
        {
            throw new NotImplementedException();
        }

        private string nameof(string key)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Ключ объекта. </returns>
        public override string ToString()
        {
            return Key;
        }
    }
}
