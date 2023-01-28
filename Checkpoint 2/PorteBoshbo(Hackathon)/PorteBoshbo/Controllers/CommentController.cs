using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PorteBoshbo.Controllers
{
    public class CommentController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var data = CommentService.Get();
            return View(data);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = CommentService.Get(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CommentDTO Comment)
        {
            if (CommentService.Add(Comment))
            {
                Comment.Date = DateTime.Now;

                ViewBag.Message = "Comment Added.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Comment Failed to Add.";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(CommentService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(CommentDTO Comment)
        {
            if (CommentService.Update(Comment))
            {
                ViewBag.Message = "Comment Updated.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Comment Failed to Update.";
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (CommentService.Delete(id))
            {
                ViewBag.Message = "Comment Deleted.";
                return RedirectToAction("Index");

            }
            ViewBag.Message = "Comment Failed to Delete.";
            return View();
        }
    }
}