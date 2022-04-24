using Coffee.Foundation.GlassMapper.Models;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;


namespace Coffee.Feature.Carousel.Models
{
    [SitecoreType(TemplateId = "{C515F300-A3BC-42B8-B211-ED0E96912CE3}")]
    public interface ICarouselFolder : IGlassBase
    {
        [SitecoreField(FieldType = SitecoreFieldType.Treelist)]
        IEnumerable<ICarousel> Slides { get; set; }
    }
}
