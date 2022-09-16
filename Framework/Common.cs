using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework
{
    //commonly used functions
    internal class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }
        internal static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }
        public static void click(string locator)
        {
            getElement(locator).Click();
        }
        internal static string getElementAttribute(string locator)
        {
            string element;
            return element = getElement(locator).GetAttribute("alt");
        }
        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }
        internal static void waitForElementToBeVisable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }
    }
}
