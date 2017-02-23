using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookAdviser.Web.UI.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }
        public  ActionResult Edit(int id)
        {
            return View(id);
        }

        public ActionResult Create()
        {
            return View("~/Views/Author/Edit.cshtml");
        }
    }
}