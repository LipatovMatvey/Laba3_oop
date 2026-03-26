using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class PremiumShopBuilder : ShopBuilder
    {
        /// <summary>
        /// Имя магазина
        /// </summary>
        private string name = "Премиум-магазин";

        /// <summary>
        /// Адрес магазина
        /// </summary>
        private string address = "Не указан";

        /// <summary>
        /// Число покупок в сутки
        /// </summary>
        private int purchaseCount = 2500;

        /// <summary>
        /// Количество товаров
        /// </summary>
        private int productCount = 5000;

        /// <summary>
        /// Средний чек
        /// </summary>
        private double averageCheck = 5000;

        /// <summary>
        /// Рейтинг магазина
        /// </summary>
        private double rating = 4.9;

        /// <summary>
        /// Активен ли магазин
        /// </summary>
        private bool isActive = true;

        public ShopBuilder InstallName(string name)
        {
            this.name = name;
            return this;
        }
        public ShopBuilder InstallAddress(string addr)
        {
            this.address = addr;
            return this;
        }
        public ShopBuilder InstallPurchaseCount(int count)
        {
            this.purchaseCount = count;
            return this;
        }
        public ShopBuilder InstallProductCount(int count)
        {
            this.productCount = count;
            return this;
        }
        public ShopBuilder InstallAverageCheck(double check)
        {
            this.averageCheck = check;
            return this;
        }
        public ShopBuilder InstallRating(double rating)
        {
            this.rating = rating;
            return this;
        }
        public ShopBuilder InstallIsActive(bool active)
        {
            this.isActive = active;
            return this;
        }

        public InternetShop Build()
        {
            if (productCount < 4000)
                throw new ArgumentException("Для премиум-магазина количество товаров не может " +
                    "быть меньше 4000.");
            if (averageCheck < 4850.5)
                throw new ArgumentException("Средний чек для премиум-магазина не может быть " +
                    "ниже 4850.5.");
            if (purchaseCount < 2000)
                throw new ArgumentException("Кол-во покупок в день в премиум-магазине должно " +
                    "быть не менее 2000.");
            if (rating < 4.85)
                throw new ArgumentException("Рейтинг в премиум-магазине не может быть менее 4.85 ");
            return new InternetShop(name, address, purchaseCount, productCount, averageCheck, rating, isActive);
        }
    }
}
