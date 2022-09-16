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

        public static void clickBitcoin()
        {
            Common.click("//a[contains(text(),'Bitcoin USD')]");
        }

        public static void clickBitcoinUSD()
        {
            Common.click("//tr[1]/td[2]/a/span[contains(text(),\"BTCUSD\")]");
        }

        public static void clickCrypto()
        {
            Common.click("//ul/li[7]/a[contains(text(),'Crypto')]");
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
