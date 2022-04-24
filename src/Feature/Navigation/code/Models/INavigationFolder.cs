using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Coffee.Foundation.GlassMapper.Models;


namespace Coffee.Feature.Navigation.Models
{
    [SitecoreType(TemplateId = "{9BDCD218-CDE0-4C1B-AF3F-FB91553274C9}")]
    public interface INavigationFolder : IGlassBase
    {
        [SitecoreChildren(InferType = true)]
        IEnumerable<INavigationItem> NavigationItems { get; set; }
    }
}
