using LABA_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Делегат для обработки событий коллекции InternetShopCollection
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void CollectionHandler(object source, CollectionEventArgs e);

    public class CollectionEventArgs : EventArgs
    {
        /// <summary>
        /// Тип выполненного действия
        /// </summary>
        public string Action { get; }

        /// <summary>
        /// Объект InternetShop, с которым связано событие
        /// </summary>
        public InternetShop Item { get; }

        /// <summary>
        /// Ключ элемента в коллекции
        /// </summary>
        public int Key { get; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="action">Тип действия</param>
        /// <param name="key">Ключ элемента</param>
        /// <param name="item">Объект элемента</param>
        public CollectionEventArgs(string action, int key, InternetShop item)
        {
            Action = action;
            Key = key;
            Item = item;
        }
    }
}
