﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;
using WebStoreUI.Models;

namespace WebStoreUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int pageSize = 4;

        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        // GET: Book
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult List(int page = 1)
        {
            //return View(repository.Books.OrderBy(book => book.BookId).Skip((page - 1) * pageSize).Take(pageSize));

            BooksListViewModel model = new BooksListViewModel
            {
                Books = repository.Books
                    .OrderBy(game => game.BookId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Books.Count()
                }
            };
            return View(model);
        }
    }
}