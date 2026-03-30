using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class SmallShopBuilder : ShopBuilder
    {
        /// <summary>
        /// Наименование магазина
        /// </summary>
        private string name = "Минимаркет";

        /// <summary>
        /// Адрес магазина
        /// </summary>
        private string address = "Не указан";

        /// <summary>
        /// Число покупок в сутки
        /// </summary>
        private int purchaseCount = 40;

        /// <summary>
        /// Количество товаров
        /// </summary>
        private int productCount = 150;

        /// <summary>
        /// Средний чек
        /// </summary>
        private double averageCheck = 400;

        /// <summary>
        /// Рейтинг магазина
        /// </summary>
        private double rating = 3.4;

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

        public ShopBuilder InstallPurchaseCount(int purchaseCount)
        {
            this.purchaseCount = purchaseCount;
            return this;
        }

        public ShopBuilder InstallProductCount(int productCount)
        {
            this.productCount = productCount;
            return this;
        }

        public ShopBuilder InstallAverageCheck(double averageCheck)
        {
            this.averageCheck = averageCheck;
            return this;
        }

        public ShopBuilder InstallRating(double rating)
        {
            this.rating = rating;
            return this;
        }

        public ShopBuilder InstallIsActive(bool isActive)
        {
            this.isActive = isActive;
            return this;
        }

        public InternetShop Build()
        {
            if (productCount > 150)
                throw new ArgumentException("Для маленького магазина количество товаров не может" +
                    " превышать 150.");
            if (averageCheck > 400.0)
                throw new ArgumentException("Средний чек для маленького магазина не должен быть" +
                    " выше 400.");
            if (purchaseCount > 40.0)
                throw new ArgumentException("Кол-во покупок в день для маленького магазина не " +
                    "должен быть выше 40.");

            return new InternetShop(name, address, purchaseCount, productCount, 
                averageCheck, rating, isActive);
        }       
    }
}
