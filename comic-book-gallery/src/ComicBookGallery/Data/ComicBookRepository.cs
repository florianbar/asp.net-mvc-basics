namespace ComicBookGallery.Data
{
    using ComicBookGallery.Models;

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