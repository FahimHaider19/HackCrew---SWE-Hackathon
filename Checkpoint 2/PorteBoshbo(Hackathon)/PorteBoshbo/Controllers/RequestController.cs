using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PorteBoshbo.Controllers
{
    public class RequestController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var data = RequestService.Get();
            return View(data);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = RequestService.Get(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RequestDTO Request)
        {
            if (RequestService.Add(Request))
            {
                ViewBag.Message = "Request Added.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Request Failed to Add.";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(RequestService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(RequestDTO Request)
        {
            if (RequestService.Update(Request))
            {
                Request.Date = DateTime.Now;

                ViewBag.Message = "Request Updated.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Request Failed to Update.";
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (RequestService.Delete(id))
            {
                ViewBag.Message = "Request Deleted.";
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Request Failed to Delete.";
            return View();
        }
    }
}