using Business;
using Domain;
using System.Collections.Generic;


namespace Presentation.Models
{
    public class ContentPageModel:ContentPage
    {
        ContentPageBusiness contentepageBusiness;
        public ContentPageModel(string connectionString)
        {
            this.contentepageBusiness = new ContentPageBusiness(connectionString);
        }

        public ContentPageModel()
        {
           
        }

        public List<ContentPage> GetAllContentPage()
        {
            return contentepageBusiness.GetAllContentPage();
        }

        public void UpdateContentPageHotel(string referentpage, string urlimage)
        {
            this.contentepageBusiness.UpdateContentPageHotel(referentpage, urlimage);
        }

    }
}
