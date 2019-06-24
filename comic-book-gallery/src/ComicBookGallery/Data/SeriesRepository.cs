namespace ComicBookGallery.Data
{
    using ComicBookGallery.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class SeriesRepository
    {
        public Series[] GetSeries()
        {
            return Data.Series;
        }

        public Series GetSeriesDetail(int id)
        {
            Series series = null;

            foreach (var item in Data.Series)
            {
                if (item.Id == id)
                {
                    series = item;
                    break;
                }
            }

            if (series != null)
            {
                // Get the comic books for this series
                var comicBooks = new ComicBook[0];

                foreach (var comicBook in Data.ComicBooks)
                {
                    if (comicBook.Series != null && comicBook.Series.Id == id)
                    {
                        Array.Resize(ref comicBooks, comicBooks.Length + 1);
                        comicBooks[comicBooks.Length - 1] = comicBook;
                    }
                }

                series.Issues = comicBooks;
            }

            return series;
        }
    }
}