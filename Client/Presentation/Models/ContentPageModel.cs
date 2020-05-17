using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class ContentPageModel
    {
        public int id { get; set; }
        public String referentpage { get; set; }
        public String urlimage { get; set; }
        public String typeimage { get; set; }
        public String content { get; set; }
    }
}
