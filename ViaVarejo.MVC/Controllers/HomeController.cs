using System;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ViaVarejo.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Token = (HttpContext.Request.Cookies.Get("ApiToken")?.Value != null) ? true : false;

            return View();
        }

        [HttpPost]
        public ActionResult SalvarToken(string Token)
        {
            var token = new HttpCookie("ApiToken", Convert.ToBase64String(Encoding.UTF8.GetBytes(Token)));
            token.Expires.AddDays(1);
            token.HttpOnly = true;
            HttpContext.Response.Cookies.Remove("ApiToken");
            HttpContext.Response.Cookies.Set(token);

            return RedirectToAction("Index");
        }
    }
}