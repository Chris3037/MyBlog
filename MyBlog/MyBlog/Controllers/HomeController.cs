using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        //Step 1. Set up database access
        Models.myBlogEntities db = new Models.myBlogEntities();


        //
        // GET: /Home/

        public ActionResult Index()
        {
            var list = db.Posts.OrderByDescending(x => x.PostedOn);
            return View(list);
        }

    }
}
