using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee.Feature.Header.Models
{
    public class HeaderViewModel
    {
        public ILogo Logo { get; set; }

        public ISearch Search { get; set; }
    }
}