using Glass.Mapper.Sc.Configuration.Attributes;
using Coffee.Foundation.GlassMapper.Models;
using Glass.Mapper.Sc.Fields;

namespace Coffee.Feature.Carousel.Models
{
    [SitecoreType(TemplateId = "{93ABC522-BEC6-4632-932A-9CAA9C21FBE9}")]
    public interface ICarousel : IGlassBase
    {
        [SitecoreField(FieldId = "{EF4A0A73-FB78-458B-A7D3-82BD54B9704E}")]
        string Title { get; set; }

        [SitecoreField(FieldId = "{6995EEC8-101D-4901-B3D2-09F6A88A8777}")]
        Image Image { get; set; }

        [SitecoreField(FieldId = "{A64C8B21-7D99-4F3C-96DC-AAB309B1C59B}")]
        Link CallToAction { get; set; }

    }
}
