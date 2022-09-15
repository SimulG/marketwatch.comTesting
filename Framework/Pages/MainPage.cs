using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    public class MainPage
    {
        public static object checkPreformance5D()
        {
            string locator = "//*[@id='maincontent']//tbody/tr[1]/td[2]/ul/li[1]";
            return Common.getElementText(locator);
        }

        public static void clickAcceptCoockies()
        {
            //"sp_message_iframe_524529"
            Driver.wait(10);
            Driver.switchFrameID("sp_message_iframe_524529");
            Common.click("//*[@id='notice']//button[@title ='YES, I AGREE']");
            Driver.switchFrameDefault();
        }

        public static void clickBitcoinUSD()
        {
            Common.click("/html/body/main/div/div[2]/div[2]/div[1]/div[1]/div/table/tbody/tr[1]/td[2]/a/span");
        }

        public static void clickSearchButton()
        {
            Common.click("//header/button[1]");
        }

        public static void clickSearchSecondButton()
        {
            Common.click("//*[@id='btn-submit-search']");
        }

        public static void enterTextBitcoin()
        {
            Common.sendKeysToElement("//*[@id='mw-search']", "bitcoin");
        }
    }
}
