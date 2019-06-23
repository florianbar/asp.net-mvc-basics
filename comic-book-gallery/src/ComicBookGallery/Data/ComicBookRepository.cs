using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        public ComicBook[] GetComicBooks()
        {
            return Data.ComicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBook = null;

            foreach (var item in Data.ComicBooks)
            {
                if (item.Id == id)
                {
                    comicBook = item;
                    break;
                }
            }

            return comicBook;
        }
    }
}