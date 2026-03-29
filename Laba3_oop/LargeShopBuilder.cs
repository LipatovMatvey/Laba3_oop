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
        private string name = "Крупный интернет-магазин";

        /// <summary>
        /// Адрес склада магазина
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
            return this; }
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
            if (productCount < 1000)
                throw new ArgumentException("Для крупного интернет-магазина количество товаров не может " +
                    "быть меньше 1000.");
            if (averageCheck < 1200.0)
                throw new ArgumentException("Средний чек для крупного интернет-магазина не может быть " +
                    "ниже 1200.");
            if (purchaseCount < 1500 )
                throw new ArgumentException("Кол-во покупок в день в крупном интернет-магазине должно " +
                    "быть не менее 150.");

            return new InternetShop(name, address, purchaseCount, productCount, averageCheck, 
                rating, isActive);
        }
    }
}
