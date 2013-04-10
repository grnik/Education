using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationWWW.Controllers
{
    using System.Text;

    using Providers;

    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Добро пожаловать в ASP.NET MVC!";

            return this.View();
        }

        public ActionResult About()
        {
            return View();
        }

        /// <summary>Кодировка спец символов
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string DecodingSearch(string a)
        {
            return a.Replace("?", "[x_1_x]").Replace("<", "[x_2_x]").Replace(">", "[x_3_x]").Replace("*", "[x_4_x]")
            .Replace("%", "[x_5_x]").Replace("&", "[x_6_x]").Replace(@"\", "[x_7_x]").Replace("|", "[x_8_x]")
            .Replace(":", "[x_9_x]").Replace("\"", "[x_10_x]").Replace(".", "[x_11_x]").Replace("/", "[x_12_x]");
        }
        /// <summary>Расшифровка спец символов
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string UndecodingSearch(string a)
        {
            return a.Replace("[x_1_x]", "?").Replace("[x_2_x]", "<").Replace("[x_3_x]", ">")
            .Replace("[x_4_x]", "*").Replace("[x_5_x]", "%").Replace("[x_6_x]", "&")
            .Replace("[x_7_x]", @"\").Replace("[x_8_x]", "|").Replace("[x_9_x]", ":")
            .Replace("[x_10_x]", "\"").Replace("[x_11_x]", ".").Replace("[x_12_x]", "/");
        }
    }
}
