using LABA_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class InternetShopCollection
    {
        /// <summary>
        /// Внутреннее хранилище коллекции на основе Dictionary
        /// </summary>
        public Dictionary<int, InternetShop> ShopsCollection { get; set; } = new Dictionary<int, InternetShop>();

        /// <summary>
        /// Событие, возникающее при добавлении нового элемента в коллекцию
        /// </summary>
        public event CollectionHandler ItemAdded;

        /// <summary>
        /// Событие, возникающее при удалении элемента из коллекции
        /// </summary>
        public event CollectionHandler ItemRemoved;

        /// <summary>
        /// Метод добавления элемента в коллекцию
        /// </summary>
        /// <param name="key">Уникальный ключ элемента</param>
        /// <param name="shop">Добавляемый объект магазина</param>
        public void Add(int key, InternetShop shop) 
        {
            ShopsCollection.Add(key, shop);
            OnItemAdded(key, shop);
        }

        /// <summary>
        /// Метод удаления элемента из коллекции
        /// </summary>
        /// <param name="key">Ключ удаляемого элемента</param>
        /// <returns>true - если элемент успешно удален, false - если ключ не найден</returns>
        public bool Remove(int key) 
        {
            if (ShopsCollection.TryGetValue(key, out InternetShop shop))
            {
                ShopsCollection.Remove(key);
                OnItemRemoved(key, shop);
                return true;
            }   
            return false;
        }

        /// <summary>
        /// Индексатор для обращения к элементу коллекции по ключу
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <returns>Элемент, найденный по ключу - объект InternetShop</returns>
        public InternetShop this[int key] => ShopsCollection[key];

        /// <summary>
        /// Метод позволяет получить все пары «ключ-значение» из словаря для перебора в цикле foreach
        /// </summary>
        /// <returns>Интерфейс IEnumerable</returns>
        public IEnumerable<KeyValuePair<int, InternetShop>> GetAll() => ShopsCollection;

        /// <summary>
        /// Слушатель события добавления объекта в коллекцию
        /// </summary>
        /// <param name="key">Ключ - id объекта</param>
        /// <param name="shop">Значение - сам объект</param>
        protected virtual void OnItemAdded(int key, InternetShop shop)
        {
            ItemAdded?.Invoke(this, new CollectionEventArgs("Added", key, shop));
        }

        /// <summary>
        /// Слушатель события удаления объекта из коллекции
        /// </summary>
        /// <param name="key">Ключ - id объекта</param>
        /// <param name="shop">Значение - сам объект</param>
        protected virtual void OnItemRemoved(int key, InternetShop shop)
        {
            ItemRemoved?.Invoke(this, new CollectionEventArgs("Removed", key, shop));
        }
    }
}
