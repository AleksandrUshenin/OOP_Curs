using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTab
{
    public class HashTable<T>
    {
        private readonly byte _maxSize = 255;
        private Dictionary<int, List<Item<T>>> _items = null;

        public IReadOnlyCollection<KeyValuePair<int, List<Item<T>>>> Items { get { return _items.ToList().AsReadOnly(); } }

        public HashTable()
        {
            // Инициализируем коллекцию максимальным количество элементов.
            _items = new Dictionary<int, List<Item<T>>>(_maxSize);
        }

        /// <summary>
        /// Добавить данные в хеш таблицу.
        /// </summary>
        /// <param name="key"> Ключ хранимых данных. </param>
        /// <param name="value"> Хранимые данные. </param>
        public void Add(string key, T value)
        {
            // Проверяем входные данные на корректность.
            CorrectData(key, value);

            // Создаем новый экземпляр данных.
            var item = new Item<T>(key, value);
            // Получаем хеш ключа
            var hash = GetHash(item.Key);

            List<Item<T>> hashTableItem = null;
            if (_items.ContainsKey(hash))
            {
                // Получаем элемент хеш таблицы.
                hashTableItem = _items[hash];
                // Проверяем наличие внутри коллекции значения с полученным ключом.
                // Если такой элемент найден, то сообщаем об ошибке.
                var oldElementWithKey = hashTableItem.SingleOrDefault(i => i.Key == item.Key);
                if (oldElementWithKey != null)
                {
                    throw new ArgumentException("Хеш-таблица уже содержит элемент с ключом " + key + ". Ключ должен быть уникален.", nameof(key));
                }
                // Добавляем элемент данных в коллекцию элементов хеш таблицы.
                _items[hash].Add(item);
            }
            else
            {
                // Создаем новую коллекцию.
                hashTableItem = new List<Item<T>> { item };
                // Добавляем данные в таблицу.
                _items.Add(hash, hashTableItem);
            }
        }

        /// <summary>
        /// Удаление из списка
        /// </summary>
        /// <param name="key">ключ</param>
        public void Delete(string key)
        {
            // Проверяем входные данные на корректность.
            CorrectData(key);
            // Получаем хеш ключа.
            var hash = GetHash(key);
            // Если значения с таким хешем нет в таблице,
            // то завершаем выполнение метода.
            if (!_items.ContainsKey(hash))
            {
                return;
            }

            // Получаем коллекцию элементов по хешу ключа.
            var hashTableItem = _items[hash];
            // Получаем элемент коллекции по ключу.
            var item = hashTableItem.SingleOrDefault(i => i.Key == key);
            // Если элемент коллекции найден,
            // то удаляем его из коллекции.
            if (item != null)
            {
                hashTableItem.Remove(item);
            }
        }
        /// <summary>
        /// выбор обьекта оп ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Search(string key)
        {
            // Проверяем входные данные на корректность.
            CorrectData(key);

            // Получаем хеш ключа.
            var hash = GetHash(key);
            // Если таблица не содержит такого хеша,
            // то завершаем выполнения метода вернув null.
            if (!_items.ContainsKey(hash))
            {
                return default(T);
            }
            // Если хеш найден, то ищем значение в коллекции по ключу.
            var hashTableItem = _items[hash];
            if (hashTableItem != null)
            {
                // Получаем элемент коллекции по ключу.
                var item = hashTableItem.SingleOrDefault(i => i.Key == key);
                // Если элемент коллекции найден,
                // то возвращаем хранимые данные.
                if (item != null)
                {
                    return item.Value;
                }
            }
            // Возвращаем null если ничего найдено.
            return default(T);
        }
        private int GetHash(string value)
        {
            // Проверяем входные данные на корректность.
            CorrectData(value);
            // Получаем длину строки.
            var hash = value.Length;
            return hash;
        }
        /// <summary>
        /// возвращает строки для вывода
        /// </summary>
        /// <typeparam name="T">тип</typeparam>
        /// <param name="title">заголовок</param>
        public List<string> Show(string title)
        {
            List<string> list = new List<string>();
            // Проверяем входные аргументы.
            if (Items == null)
            {
                throw new ArgumentNullException(nameof(Items));
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            list.Add(title);
            foreach (var item in Items)
            {
                list.Add($"item.Key:{item.Key}");
                foreach (var value in item.Value)
                {
                    list.Add($"\t Key: {value.Key} - {value.Value}");
                }
            }
            return list;
        }

        /// <summary>
        /// проверка данных на корректность
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void CorrectData(string key, T value)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
                //throw new ArgumentException(nameof(key));
            }
            if (key.Length > _maxSize)
            {
                throw new ArgumentException("Максимальная длинна ключа составляет " + _maxSize + " символов.", nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// проверка данных на корректность
        /// </summary>
        /// <param name="key"></param>
        private void CorrectData(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (key.Length > _maxSize)
            {
                throw new ArgumentException("Максимальная длинна ключа составляет " + _maxSize + " символов.", nameof(key));
            }
        }
        private string nameof(IReadOnlyCollection<KeyValuePair<int, List<Item<T>>>> Items)
        {
            throw new NotImplementedException();
        }
        private string nameof(string key)
        {
            return "Error in " + key;
        }
        private string nameof(T value)
        {
            throw new NotImplementedException();
        }
    }
}