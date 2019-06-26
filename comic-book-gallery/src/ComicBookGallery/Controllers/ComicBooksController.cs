﻿namespace ComicBookGallery.Controllers
{
    using ComicBookGallery.Data;
    using ComicBookGallery.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        //constructor
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id) 
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}