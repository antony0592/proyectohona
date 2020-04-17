using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContentPage
    {
        public ContentPage()
        {
        }

        public ContentPage(int id, string referentpage, string urlimage, string typeimage, string content)
        {
            this.id = id;
            this.referentpage = referentpage;
            this.urlimage = urlimage;
            this.typeimage = typeimage;
            this.content = content;
        }

        public int id { get; set; }
        public String referentpage { get; set; }
        public String urlimage { get; set; }
        public String typeimage { get; set; }
        public String content { get; set; }
        
    }
}
