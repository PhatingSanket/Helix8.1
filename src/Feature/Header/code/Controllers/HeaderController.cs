using Coffee.Feature.Header.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee.Feature.Header.Controllers
{
    public class HeaderController : Controller
    {
        public ActionResult Index()
        {
            var mvcContext = new MvcContext();

            var logo = mvcContext.GetDataSourceItem<ILogo>();
            var search = mvcContext.GetDataSourceItem<ISearch>();

            var headerViewModel = new HeaderViewModel
            {
                Logo = logo,
                Search = search
            };

            return View(headerViewModel);
        }
    }
}