using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_oop;

namespace ModuleTest
{
    [TestClass]
    public class ShopDirectorTests
    {
        /// <summary>
        /// Использует тестовый строитель для проверки корректности вызовов методов директором
        /// </summary>
        [TestMethod]
        public void Director_ShouldCallAllInstallMethods()
        {
            var builder = new TestShopBuilder();
            var director = new ShopDirector(builder);
            var shop = director.CreateShop("Name", "Addr", 1, 2, 3.0, 4.0, true);
            Assert.IsTrue(builder.NameSet);
            Assert.IsTrue(builder.AddressSet);
            Assert.IsTrue(builder.PurchaseCountSet);
            Assert.IsTrue(builder.ProductCountSet);
            Assert.IsTrue(builder.AverageCheckSet);
            Assert.IsTrue(builder.RatingSet);
            Assert.IsTrue(builder.IsActiveSet);
        }

       /// <summary>
       /// Вспомогательный класс для проверки вызовов
       /// </summary>
        private class TestShopBuilder : ShopBuilder
        {
            /// <summary>
            /// Вспомогательное поле
            /// </summary>
            public bool NameSet, AddressSet, PurchaseCountSet, ProductCountSet, AverageCheckSet, RatingSet, IsActiveSet;

            public ShopBuilder InstallName(string name) { NameSet = true; return this; }
            public ShopBuilder InstallAddress(string addr) { AddressSet = true; return this; }
            public ShopBuilder InstallPurchaseCount(int count) { PurchaseCountSet = true; return this; }
            public ShopBuilder InstallProductCount(int count) { ProductCountSet = true; return this; }
            public ShopBuilder InstallAverageCheck(double check) { AverageCheckSet = true; return this; }
            public ShopBuilder InstallRating(double rating) { RatingSet = true; return this; }
            public ShopBuilder InstallIsActive(bool active) { IsActiveSet = true; return this; }
            public InternetShop Build() => new InternetShop();
        }
    }
}
