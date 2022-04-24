using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Coffee.Feature.Navigation.Models;
using System.Collections.Generic;

namespace Coffee.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        public ActionResult Index()
        {
            var mvcContext = new MvcContext();

            var dataSource = mvcContext?.GetDataSourceItem<INavigationFolder>();


            var menuList = new List<MenuListModel>();

            if (dataSource != null && dataSource.NavigationItems != null)
            {
                foreach (var item in dataSource.NavigationItems)
                {
                    var menuData = new MenuListModel
                    {
                        NavigationItem = item
                    };

                    if (item?.Children != null)
                    {
                        var childMenuList = new List<MenuListModel>();

                        foreach (var childItem in item?.Children)
                        {
                            var childMenuData = new MenuListModel
                            {
                                NavigationItem = childItem
                            };
                            childMenuList?.Add(childMenuData);
                        }
                        menuData.Children = new List<MenuListModel>(childMenuList);
                    }
                    menuList?.Add(menuData);
                }
            }
            var model = new MenuListViewModel
            {
                MenuListModel = new List<MenuListModel>(menuList)
            };

            return View(model);

        }
    }
}