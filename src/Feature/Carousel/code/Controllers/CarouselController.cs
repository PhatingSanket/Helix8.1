using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Coffee.Feature.Carousel.Models;
using System.Collections.Generic;

namespace Coffee.Feature.Carousel.Controllers
{
    public class CarouselController : Controller
    {
        public ActionResult Index()
        {
            var mvcContext = new MvcContext();

            var datasource = mvcContext.GetDataSourceItem<ICarouselFolder>();

            return View(datasource);
        }
    }
}