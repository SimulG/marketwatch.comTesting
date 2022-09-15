using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasess;
using Framework;

namespace Test
{
    internal class Bitcoin5D : BaseTest
    {
        [SetUp]
        public static void Preparation()
        {
            Driver.open($"{Constants.Urls.MarketWatch.Domain}");
        }
        [Test]
        public static void fiveDayPreformance()
        {
            //expected result: More than 0 (x > 0)
            int preformance5D = 0; // null;

            MainPage.clickAcceptCoockies();
            MainPage.clickSearchButton();
            MainPage.enterTextBitcoin();
            MainPage.clickSearchSecondButton();
            MainPage.clickBitcoinUSD();
            //preformance5D =
            //MainPage.checkPreformance5D();
            preformance5D = 1;

            Assert.IsTrue(preformance5D < 0);
        }

    }
}
