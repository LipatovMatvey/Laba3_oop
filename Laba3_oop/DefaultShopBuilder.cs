using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class DefaultShopBuilder : ShopBuilder
    {
        private string name = "Noname";
        private string address = "Noaddress";
        private int purchaseCount = 0;
        private int productCount = 0;
        private double averageCheck = 0.0;
        private double rating = 0.0;
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


        /// <summary>
        /// Строит и возвращает объект с установленными параметрами
        /// </summary>
        /// <returns>Сконфигурированный интернет-магазин</returns>
        public InternetShop Build()
        {
            return new InternetShop(name, address, purchaseCount, productCount, averageCheck, rating, isActive);
        }
    }
}
