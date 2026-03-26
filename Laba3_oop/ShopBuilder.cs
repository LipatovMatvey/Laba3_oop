using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_oop
{
    public interface ShopBuilder
    {
        /// <summary>
        /// Устанавливает название магазина
        /// </summary>
        /// <param name="_name">Название магазина</param>
        /// <returns>Тот же строитель для цепочки вызовов</returns>
        public ShopBuilder InstallName(string _name);

        /// <summary>
        /// Устанавливает адрес магазина
        /// </summary>
        /// <param name="addr">Адрес магазина</param>
        /// <returns>Тот же строитель для цепочки вызовов</returns>
        public ShopBuilder InstallAddress(string addr);

        /// <summary>
        /// Устанавливает кол-во покупок в день
        /// </summary>
        /// <param name="purchaseCount">Кол-во покупок в день</param>
        /// <returns>Тот же строитель для цепочки вызовов</returns>
        public ShopBuilder InstallPurchaseCount(int purchaseCount);

        /// <summary>
        /// Устанавливает кол-во продуктов в ассортименте магазина
        /// </summary>
        /// <param name="productCount">Кол-во продуктов</param>
        /// <returns></returns>
        public ShopBuilder InstallProductCount(int productCount);

        /// <summary>
        /// Устанавливает средний чек
        /// </summary>
        /// <param name="averageCheck">Средний чек</param>
        /// <returns>Тот же строитель для цепочки вызовов</returns>
        public ShopBuilder InstallAverageCheck(double averageCheck);

        /// <summary>
        /// Устанавливает рейтинг магазина
        /// </summary>
        /// <param name="rating">Рейтинг магазина</param>
        /// <returns>Тот же строитель для цепочки вызовов</returns>
        public ShopBuilder InstallRating(double rating);

        /// <summary>
        /// Устанавливает параметр активности магазина
        /// </summary>
        /// <param name="isActive">Активность магазина</param>
        /// <returns>Тот же строитель для цепочки вызовов</returns>
        public ShopBuilder InstallIsActive(bool isActive);

        /// <summary>
        /// Создает объект класса посредством цепочки вызовов методов установки значений
        /// </summary>
        /// <returns>Созданный объект <see cref="InternetShop"/>.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если параметры не соответствуют ограничениям конкретного строителя</exception>
        public InternetShop Build();
    }
}
