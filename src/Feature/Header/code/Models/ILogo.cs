using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;
using Coffee.Foundation.GlassMapper.Models;

namespace Coffee.Feature.Header.Models
{
    [SitecoreType(TemplateId = "{46F36344-6280-4A90-8C0D-DD9AEDE31A06}")]
    public interface ILogo : IGlassBase
    {
        [SitecoreField(FieldId = "{62437AF3-3810-4032-B8B5-F3314CBF7D43}")]
        Image SiteLogo { get; set; }

        [SitecoreField(FieldId = "{B1751E34-AF15-4D77-9CC8-8C485430EB99}")]
        Link SiteLink { get; set; }
    }
}
