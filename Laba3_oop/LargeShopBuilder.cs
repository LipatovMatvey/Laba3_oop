using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class LargeShopBuilder : ShopBuilder
    {
        /// <summary>
        /// Название магазина
        /// </summary>
        private string name = "Гипермаркет";

        /// <summary>
        /// Адрес магазина
        /// </summary>
        private string address = "Не указан";

        /// <summary>
        /// Кол-во покупок в день
        /// </summary>
        private int purchaseCount = 1500;

        /// <summary>
        /// Кол-во товара
        /// </summary>
        private int productCount = 5000;

        /// <summary>
        /// Средний чек
        /// </summary>
        private double averageCheck = 5000.0;

        /// <summary>
        /// Рейтинг магазина
        /// </summary>
        private double rating = 4.5;

        /// <summary>
        /// Активность магазина
        /// </summary>
        private bool isActive = true;

        /// <summary>
        /// Устанавливает название магазина
        /// </summary>
        /// <param name="name">Название магазина</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallName(string name) 
        { 
            this.name = name; 
            return this; 
        }

        /// <summary>
        /// Устанавливает адрес магазина
        /// </summary>
        /// <param name="addr">Адрес магазина</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallAddress(string addr) 
        { 
            this.address = addr; 
            return this; 
        }

        /// <summary>
        /// Устанавливает количество покупок в сутки
        /// </summary>
        /// <param name="count">Количество покупок</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallPurchaseCount(int count) 
        { 
            this.purchaseCount = count;
            return this; 
        }

        /// <summary>
        /// Устанавливает количество товаров в магазине
        /// </summary>
        /// <param name="count">Количество товаров</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallProductCount(int count) 
        {
            this.productCount = count; 
            return this; 
        }

        /// <summary>
        /// Устанавливает средний чек магазина
        /// </summary>
        /// <param name="check">Средний чек</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallAverageCheck(double check) 
        { 
            this.averageCheck = check; 
            return this; 
        }

        /// <summary>
        /// Устанавливает рейтинг магазина
        /// </summary>
        /// <param name="rating">Рейтинг магазина</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallRating(double rating) 
        { 
            this.rating = rating; 
            return this; 
        }

        /// <summary>
        /// Устанавливает флаг активности магазина
        /// </summary>
        /// <param name="active">Активен ли магазин</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallIsActive(bool active) 
        { 
            this.isActive = active; 
            return this; 
        }

        /// <summary>
        /// Строит объект с проверкой соответствия критериям крупного магазина
        /// </summary>
        /// <returns>Сконфигурированный интернет-магазин</returns>
        /// <exception cref="ArgumentException"></exception>
        public InternetShop Build()
        {
            if (productCount < 1000)
                throw new ArgumentException("Для крупного магазина количество товаров не может " +
                    "быть меньше 1000.");
            if (averageCheck < 1200.0)
                throw new ArgumentException("Средний чек для крупного магазина не может быть " +
                    "ниже 1200.");
            if (purchaseCount < 1500 )
                throw new ArgumentException("Кол-во покупок в день в крупном магазине должно " +
                    "быть не менее 150.");

            return new InternetShop(name, address, purchaseCount, productCount, averageCheck, 
                rating, isActive);
        }
    }
}
