using DemoLoginNUnitPOM.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DemoLoginNUnitPOM.Pages
{
    public class HomePage : BaseCollection
    {
        public HomePage()
        {
            PageFactory.InitElements(webDriver, this);           
        }

        //Ekran Bileşenleri
        [FindsBy(How = How.Id, Using = "txtAd")]
        public IWebElement txtAd { get; set; }

        [FindsBy(How = How.Id, Using = "txtSoyad")]
        public IWebElement txtSoyad { get; set; }

        [FindsBy(How = How.Id, Using = "radio1")]
        public IWebElement rdErkek { get; set; }

        [FindsBy(How = How.Id, Using = "radio2")]
        public IWebElement rdKadin { get; set; }

        [FindsBy(How = How.Id, Using = "cboxUnvan")]
        public IWebElement cbxUnvan { get; set; }

        [FindsBy(How = How.Id, Using = "btnSubmit")]
        public IWebElement btnSubmit { get; set; }


        //Kullanıcı kaydetme methodu
        public void UserSave(string ad, string soyad, string unvan)
        {
            txtAd.SendKeys(ad);
            txtSoyad.SendKeys(soyad);
            rdKadin.Click();
            SelectElement selectElement = new SelectElement(cbxUnvan);
            selectElement.SelectByValue(unvan);
            btnSubmit.Click();
        }

    }
}
