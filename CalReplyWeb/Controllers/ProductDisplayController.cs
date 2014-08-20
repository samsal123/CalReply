using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalReplyWeb.Controllers
{
    /// <summary>
    /// Controller class to display product information
    /// </summary>
    public class ProductDisplayController : Controller
    {
        // GET: /ProductDisplay/
        public ActionResult Index()
        {
            return View();
        }
	}
}