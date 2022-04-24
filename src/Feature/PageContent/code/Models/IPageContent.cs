using Coffee.Foundation.GlassMapper.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Feature.PageContent.Models
{
    [SitecoreType(TemplateId = "{4354E038-A123-44C6-A8FD-F9B385EFBECD}")]
    public interface IPageContent : IGlassBase
    {
        [SitecoreField(FieldId = "{3B798374-49F7-4CB4-AE80-126F9C323AF2}")]
        string Title { get; set; }

        [SitecoreField(FieldId = "{015EA777-94B5-407B-BB37-1ECEBB3AA90C}")]
        string Description { get; set; }
    }
}
