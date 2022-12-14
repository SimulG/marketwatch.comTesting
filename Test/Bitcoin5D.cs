using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasess;
using Framework;
using System;

namespace Test
{
    internal class Bitcoin5D : BaseTest
    {
        [SetUp]
        public static void Preparation()
        {
            Driver.open($"{Constants.Urls.MarketWatch.Domain}");
            MainPage.clickAcceptCookies();
        }
        [Test]
        public static void fiveDayPreformancePositive()
        {
            //expected result: More than 0 (x > 0)
            string preformance5D = string.Empty;

            MainPage.clickSearchButton();
            MainPage.enterTextBitcoin();
            MainPage.clickSearchSecondButton();
            MainPage.clickBitcoinUSD();
            preformance5D = (string)MainPage.checkPreformance5D();
            preformance5D = preformance5D.Remove(preformance5D.Length - 1);
         
            Assert.IsTrue(Convert.ToDouble(preformance5D) > 0);
        }
        [Test]
        public static void fiveDayPreformanceSecondAproachPositive()
        {
            //expected result: More than 0 (x > 0)
            string preformance5D = string.Empty;

            MainPage.clickCrypto();
            MainPage.clickBitcoin();
            preformance5D = (string)MainPage.checkPreformance5D();
            preformance5D = preformance5D.Remove(preformance5D.Length - 1);

            Assert.IsTrue(Convert.ToDouble(preformance5D) > 0);
        }

    }
}
