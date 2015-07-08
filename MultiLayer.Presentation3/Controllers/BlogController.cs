using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiLayer.Domain.Entities;
using MultiLayer.Services.BlogServices;

namespace MultiLayer.Presentation.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        // GET: Blog
        public ActionResult Index()
        {
            return View(_blogService.GetBlogs());
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            return View(_blogService.Find(id));
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        public ActionResult Create(Blog model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _blogService.Insert(model);
                }
                else
                {
                    ModelState.AddModelError("","Error Creating blog");
                    return View(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_blogService.Find(id));
        }

        // POST: Blog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Blog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
