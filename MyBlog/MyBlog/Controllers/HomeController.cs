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

        public ActionResult RespectDown(int id)
        {
            //Gets the post from the database
            var post = db.Posts.Where(x => x.PostID == id).First();
            //Increments the respects
            post.PostRespect -= 1;
            //Save changes to the database
            db.SaveChanges();
            //Return to index
            return RedirectToAction("Index");
        }

        public ActionResult RespectUp(int id)
        {
            //Gets the post from the database
            var post = db.Posts.Where(x => x.PostID == id).First();
            //Increments the respects
            post.PostRespect += 1;
            //Save changes to the database
            db.SaveChanges();
            //Return to index
            return RedirectToAction("Index");
        }

        public ActionResult AddComment(int id, FormCollection values)
        {
            //Making a new comment
            var comment = new Models.Comment();
            comment.PostID = id;
            comment.CommentAuthor = values["author"];
            comment.CommentBody = values["body"];
            comment.CommetedOn = DateTime.Now;
            comment.CommentRespect = 0;
            //Add the comment to the database
            db.Comments.Add(comment);
            db.SaveChanges();
            //Return to index
            return RedirectToAction("Index");
        }
    }
}
