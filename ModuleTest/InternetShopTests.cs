using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_oop;

namespace ModuleTest
{
    [TestClass]
    public sealed class InternetShopTests
    {
        /// <summary>
        /// Проверка конструктора по умолчанию
        /// </summary>
        [TestMethod]
        public void Constructor_Default_ShouldSetDefaultValues()
        {
            var shop = new InternetShop();
            Assert.AreEqual("NoName", shop.Name);
            Assert.AreEqual("NoAddress", shop.Address);
            Assert.AreEqual(0, shop.PurchaseCount);
            Assert.AreEqual(0, shop.ProductCount);
            Assert.AreEqual(0.0, shop.AverageCheck);
            Assert.AreEqual(0.0, shop.Rating);
            Assert.IsFalse(shop.IsActive);
        }

        /// <summary>
        /// Проверка конструктора с параметрами
        /// </summary>
        [TestMethod]
        public void Constructor_WithParameters_ShouldSetCorrectValues()
        {
            var shop = new InternetShop("TestName", "TestAddr", 10, 20, 100.5, 4.2, true);
            Assert.AreEqual("TestName", shop.Name);
            Assert.AreEqual("TestAddr", shop.Address);
            Assert.AreEqual(10, shop.PurchaseCount);
            Assert.AreEqual(20, shop.ProductCount);
            Assert.AreEqual(100.5, shop.AverageCheck);
            Assert.AreEqual(4.2, shop.Rating);
            Assert.IsTrue(shop.IsActive);
        }

        /// <summary>
        /// Проверка переопределенного метода ToString()
        /// </summary>
        [TestMethod]
        public void ToString_ShouldReturnFormattedString()
        {
            var shop = new InternetShop("Магазин", "Адрес", 5, 10, 200, 4.5, true);
            string result = shop.ToString();
            Assert.Contains("Интернет-магазин: Магазин", result);
            Assert.Contains("Адрес: Адрес", result);
            Assert.Contains("Количество покупок в сутки: 5", result);
            Assert.Contains("Количество товаров: 10", result);
            Assert.Contains("Средний чек: 200", result);
            Assert.Contains("Рейтинг: 4,5", result);
            Assert.Contains("Статус: Активен", result);
        }
    }
}
