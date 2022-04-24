using Glass.Mapper.Sc.Configuration.Attributes;
using Coffee.Foundation.GlassMapper.Models;

namespace Coffee.Feature.Header.Models
{
    [SitecoreType(TemplateId = "{B6ADAABB-7607-4AA9-ADDA-391580D31930}")]
    public interface ISearch : IGlassBase
    {
        [SitecoreField(FieldId = "{D617B0CC-5BB1-4A56-8601-15B7205C422B}")]
        string SearchPlaceholderText { get; set; }
    }
}
