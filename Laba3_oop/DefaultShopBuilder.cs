using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class DefaultShopBuilder : ShopBuilder
    {
        /// <summary>
        /// Название магазина
        /// </summary>
        private string name = "Noname";

        /// <summary>
        /// Адрес склада магазина
        /// </summary>
        private string address = "Noaddress";

        /// <summary>
        /// Число покупок в сутки
        /// </summary>
        private int purchaseCount = 0;

        /// <summary>
        /// Количество товаров
        /// </summary>
        private int productCount = 0;

        /// <summary>
        /// Средний чек
        /// </summary>
        private double averageCheck = 0.0;

        /// <summary>
        /// Рейтинг магазина
        /// </summary>
        private double rating = 0.0;

        /// <summary>
        /// Активен ли магазин
        /// </summary>
        private bool isActive = false;

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
            return new InternetShop(name, address, purchaseCount, productCount, averageCheck, rating, isActive);
        }
    }
}
