using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace WebStoreUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;

        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        // GET: Book
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult List()
        {
            return View(repository.Books);
        }
    }
}