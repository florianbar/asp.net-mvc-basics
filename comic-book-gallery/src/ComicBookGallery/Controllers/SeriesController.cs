namespace ComicBookGallery.Controllers
{
    using ComicBookGallery.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class SeriesController : Controller
    {
        private SeriesRepository _seriesRepository = null;

        //constructor
        public SeriesController()
        {
            _seriesRepository = new SeriesRepository();
        }

        public ActionResult Index()
        {
            var series = _seriesRepository.GetSeries();

            return View(series);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var seriesDetail = _seriesRepository.GetSeriesDetail(id.Value);

            return View(seriesDetail);
        }
    }
}