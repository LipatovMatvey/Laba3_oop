using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public class DefaultShopBuilder : ShopBuilder
    {
        /// <summary>
        /// Устанавливает название магазина
        /// </summary>
        /// <param name="name">Название магазина</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallName(string name) => this;

        /// <summary>
        /// Устанавливает адрес магазина
        /// </summary>
        /// <param name="addr">Адрес магазина</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallAddress(string addr) => this;

        /// <summary>
        /// Устанавливает количество покупок в магазине
        /// </summary>
        /// <param name="count">Количество покупок</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallPurchaseCount(int count) => this;

        /// <summary>
        /// Устанавливает количество товаров в магазине
        /// </summary>
        /// <param name="count">Количество товаров</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallProductCount(int count) => this;

        /// <summary>
        /// Устанавливает средний чек магазина
        /// </summary>
        /// <param name="check">Средний чек</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallAverageCheck(double check) => this;

        /// <summary>
        /// Устанавливает рейтинг магазина
        /// </summary>
        /// <param name="rating">Рейтинг магазина</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallRating(double rating) => this;

        /// <summary>
        /// Устанавливает флаг активности магазина
        /// </summary>
        /// <param name="active">Активен ли магазин</param>
        /// <returns>Текущий экземпляр строителя для цепочки вызовов</returns>
        public ShopBuilder InstallIsActive(bool active) => this;

        /// <summary>
        /// Строит и возвращает объект с установленными параметрами
        /// </summary>
        /// <returns>Сконфигурированный интернет-магазин</returns>
        public InternetShop Build()
        {
            return new InternetShop();
        }
    }
}
