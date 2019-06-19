using DemoLoginNUnitPOM.Collections;
using DemoLoginNUnitPOM.Pages;
using NUnit.Framework;

namespace DemoLoginNUnitPOM.Tests
{
    [TestFixture]
    //[Parallelizable]
    public class HomePageTest : BaseTest
    {
        public HomePageTest():base(BrowserType.Chrome)
        {

        }

        public void UserSave(string ad, string soyad, string unvan)
        {
            GotoUrl(HomePageCollection.homePageUrl);
            HomePage homePage = new HomePage();
            homePage.UserSave(ad, soyad, unvan);
        }

        [Test, Category("Fonksiyonel Test"), Description("Başarılı Kullanıcı Kaydetme")]
        public void SuccessUserSave()
        {
            UserSave(HomePageCollection.ad, HomePageCollection.soyad, HomePageCollection.unvanProjeMuhendisi);
            Assert.AreEqual(HomePageCollection.basariliMessage, webDriver.SwitchTo().Alert().Text);
            AlertAccept();
        }

        [Test, Category("Fonksiyonel Test"), Description("Zorunlu Alanların Boş Bırakılması")]
        public void MandatoryFieldEmpty()
        {
            UserSave(HomePageCollection.ad, HomePageCollection.soyad, HomePageCollection.unvanSeciniz);
            Assert.AreEqual(HomePageCollection.zorunluAlanBosMessage, webDriver.SwitchTo().Alert().Text);
            AlertAccept();
        }

    }
}
