using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class ShopDirector
    {
        /// <summary>
        /// Объект интерфейса билдера
        /// </summary>
        private ShopBuilder builder;

        /// <summary>
        /// Конструктор с параметором
        /// </summary>
        /// <param name="builder">Объект интерфейса билдера</param>
        public ShopDirector(ShopBuilder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// Создает объект класса <see cref="InternetShop"/> с помощью билдера
        /// </summary>
        /// <param name="name">Имя магазина</param>
        /// <param name="address">Адрес магазина</param>
        /// <param name="purchaseCount">Кол-во покупок в день</param>
        /// <param name="productCount">Кол-во товара на складе</param>
        /// <param name="avgCheck">Средний чек</param>
        /// <param name="rating">Рейтинг магазина</param>
        /// <param name="isActive">Активен ли</param>
        /// <returns>Объект класса <see cref="InternetShop"/></returns>
        public InternetShop CreateShop(string name, string address, int purchaseCount,
            int productCount, double avgCheck, double rating, bool isActive)
        {
            return builder.InstallName(name)
                          .InstallAddress(address)
                          .InstallPurchaseCount(purchaseCount)
                          .InstallProductCount(productCount)
                          .InstallAverageCheck(avgCheck)
                          .InstallRating(rating)
                          .InstallIsActive(isActive)
                          .Build();
        }
    }
}