using DemoLoginNUnitPOM.Collections;
using DemoLoginNUnitPOM.Pages;
using NUnit.Framework;

namespace DemoLoginNUnitPOM.Tests
{
    [TestFixture]
    //[Parallelizable]
    public class LoginPageTest : BaseTest
    {
        public LoginPageTest():base(BrowserType.Chrome)
        {

        }

        public void SignIn(string username, string password)
        {
            GotoUrl(LoginPageCollection.loginPageUrl);
            LoginPage loginPage = new LoginPage();
            loginPage.SignIn(username, password);
        }

        [Test, Category("Fonksiyonel Test"), Description("Başarılı Oturum Açma Senaryosu")]
        public void CorrectLoginTest()
        {
            SignIn(LoginPageCollection.correctUserName, LoginPageCollection.correctPassword);
            Assert.AreEqual(LoginPageCollection.homePageTitle, webDriver.Title);
        }

        [Test, Category("Fonksiyonel Test"), Description("Başarısız Oturum Açma Senaryosu")]
        public void IncorrectLoginTest()
        {
            SignIn(LoginPageCollection.incorrectUserName, LoginPageCollection.incorrectPassword);
            Assert.AreEqual(LoginPageCollection.basarisizOturumAcmaMessage, webDriver.SwitchTo().Alert().Text);
            AlertAccept();
        }
    }
}
