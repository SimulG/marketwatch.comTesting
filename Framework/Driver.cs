using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void setDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");


            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }
        public static void open(string url)
        {
            driver.Url = url;
        }
        public static void takeScreenshot()
        {
            string screenshotPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotPath}\\src-{Guid.NewGuid()}.png";

            Directory.CreateDirectory(screenshotPath);
            Screenshot screenshot = ((ITakesScreenshot)getDriver()).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }
        public static void wait(int x)
        {
            Thread.Sleep(x);
        }
        public static void closeDriver()
        {
            driver.Quit();
        }
    }
}
