using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PorteBoshbo.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var data = PostService.Get();
            return View(data);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = PostService.Get(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PostDTO Post)
        {
            if (PostService.Add(Post))
            {
                Post.Date = DateTime.Now;

                ViewBag.Message = "Post Added.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Post Failed to Add.";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(PostService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(PostDTO Post)
        {
            if (PostService.Update(Post))
            {
                ViewBag.Message = "Post Updated.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Post Failed to Update.";
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (PostService.Delete(id))
            {
                ViewBag.Message = "Post Deleted.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Post Failed to Delete.";
            return View();
        }
    }
}