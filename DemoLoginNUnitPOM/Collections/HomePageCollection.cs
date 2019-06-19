using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoginNUnitPOM.Collections
{
    public class HomePageCollection : BaseCollection
    {
        public static string homePageUrl = "http://localhost:8383/DemoLogin/HomePage.html";
        public static string homePageTitle = "Home Page";
        public static string basariliMessage = "Kullanıcı kaydetme işlemi başarıyla tamamlandı.";
        public static string zorunluAlanBosMessage = "Lütfen zorunlu alanları doldurunuz / seçiniz.";

        public static string ad = "Ali";
        public static string soyad = "Bir";
        public static string unvanSeciniz = "0";
        public static string unvanProjeMuhendisi = "1";
        public static string unvanTestUzmani = "2";
    }
}
