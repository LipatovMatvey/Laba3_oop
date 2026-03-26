using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class DefaultShopBuilder : ShopBuilder
    {
        public ShopBuilder InstallName(string name) => this;
        public ShopBuilder InstallAddress(string addr) => this;
        public ShopBuilder InstallPurchaseCount(int count) => this;
        public ShopBuilder InstallProductCount(int count) => this;
        public ShopBuilder InstallAverageCheck(double check) => this;
        public ShopBuilder InstallRating(double rating) => this;
        public ShopBuilder InstallIsActive(bool active) => this;

        public InternetShop Build()
        {
            return new InternetShop();
        }
    }
}
