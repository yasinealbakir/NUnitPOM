using DemoLoginNUnitPOM.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoLoginNUnitPOM.Pages
{
    public class LoginPage : BaseCollection
    {
        public LoginPage()
        {
            PageFactory.InitElements(webDriver, this);
        }

        //Ekran Bileşenleri
        [FindsBy(How = How.Id, Using = "kullaniciAdi")]
        public IWebElement txtKullaniciAdi { get; set; }

        [FindsBy(How = How.Id, Using = "parola")]
        public IWebElement txtParola { get; set; }

        [FindsBy(How = How.Id, Using = "btnGirisYap")]
        public IWebElement btnGirisYap { get; set; }


        //Oturum Açma Methodu
        public void SignIn(string kullaniciAdi, string parola)
        {
            txtKullaniciAdi.SendKeys(kullaniciAdi);
            txtParola.SendKeys(parola);
            btnGirisYap.Click();
        }
    }
}
