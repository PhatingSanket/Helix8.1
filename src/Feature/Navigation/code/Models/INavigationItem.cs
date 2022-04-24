using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;
using Coffee.Foundation.GlassMapper.Models;
using System.Collections.Generic;

namespace Coffee.Feature.Navigation.Models
{
    [SitecoreType(TemplateId = "{EEFE29BE-0AA0-4898-B953-8C0F2845CC80}")]
    public interface INavigationItem : IGlassBase
    {
        [SitecoreField(FieldId = "{9A676C67-AFEB-4A49-8BDF-A00B995EA194}")]
        string NavigationTitle { get; set; }

        [SitecoreField(FieldId = "{2CC2EB10-1CF6-4F94-AB8A-BC1253495D4E}")]
        Link NavigationLink { get; set; }

        [SitecoreField(FieldId = "{930075E4-FD83-483E-A144-19DD449F48F3}")]
        bool NavigationShowInHeader { get; set; }

        [SitecoreChildren(InferType = true)]
        IEnumerable<INavigationItem> Children { get; set; }

    }
}
