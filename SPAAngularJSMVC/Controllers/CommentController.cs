using SPAAngularJSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAAngularJSMVC.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllComments()
        {
            List<CommentsEntity> comments = new List<CommentsEntity>();

            comments.Add(
                new CommentsEntity
                {
                    id = 1,
                    Comments = "Good",
                    CommentRemarks = "Good",
                    Section = "Maths"
                });

            comments.Add(
                new CommentsEntity
                {
                    id = 1,
                    Comments = "Needs Improvement",
                    CommentRemarks = "Bad",
                    Section = "History"
            });
            return Json(comments, JsonRequestBehavior.AllowGet);
        }
    }
}