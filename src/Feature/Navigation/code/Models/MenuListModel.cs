using System.Collections.Generic;

namespace Coffee.Feature.Navigation.Models
{
    public class MenuListModel
    {
        public virtual INavigationItem NavigationItem { get; set; }

        public virtual List<MenuListModel> Children { get; set; }

    }

    public class MenuListViewModel
    {
        public virtual List<MenuListModel> MenuListModel { get; set; }
    }
}