using DemoLoginNUnitPOM.Collections;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using OpenQA.Selenium;

namespace DemoLoginNUnitPOM.Tests
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    public class BaseTest : BaseCollection
    {
        private BrowserType _browserType;
        public BaseTest(BrowserType browserType)
        {
            _browserType = browserType;
        }

        private void ChooseDriver(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                webDriver = new ChromeDriver();
            }
            else if (browserType == BrowserType.Firefox)
            {
                webDriver = new FirefoxDriver();
            }
            else
            {
                webDriver = new InternetExplorerDriver();
            }
        }

        [OneTimeSetUp]
        public void Open()
        {
            ChooseDriver(_browserType);
            webDriver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void Close()
        {
            TakeErrorScreenShot();
            webDriver.Quit();
        }

        public static void GotoUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public static void AlertAccept()
        {
            webDriver.SwitchTo().Alert().Accept();
        }

        public void TakeErrorScreenShot()
        {
            try
            {
                // Test senaryosunun başarı durumu testResult değişkenine atandı.
                var testResult = TestContext.CurrentContext.Result.Outcome.Status;

                // Başarı durumu Failed olduğunda yani hata anında aşağıdaki döngüye girer.
                if (testResult.ToString() == "Failed")
                {
                    // Alınan ekran görüntüsünün kaydedilmesi için dosya yolu ayarlandı.
                    var path = AppDomain.CurrentDomain.BaseDirectory + "ScreenShots\\" + webDriver.Title + "-" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".png";

                    //Ekran görüntüsü alındı ve belirtilen dosyanın içine atıldı.
                    ((ITakesScreenshot)webDriver).GetScreenshot().SaveAsFile(path, ScreenshotImageFormat.Png);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
