using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptResult_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        public JavaScriptResult button_click_method()
        {
            string js = "function js_button_click() { alert('Hello User');}";

            return JavaScript(js);
        }
    }
}