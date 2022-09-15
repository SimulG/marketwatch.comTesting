using OpenQA.Selenium;

namespace Framework
{
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
        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }
    }
}
