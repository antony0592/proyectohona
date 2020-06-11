using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Domain;

namespace Business
{
    public class ContentPageBusiness
    {
        private ContentPageData contentPageData;

        public ContentPageBusiness(String connString)
        {
            this.contentPageData = new ContentPageData(connString);
        }//Fin del constructor.


        public List<ContentPage> GetAllContentPage()
        {
            return this.contentPageData.GetAllContentPage();
        }

        public void UpdateContentPageHotel(string referentpage, string urlimage)
        {
            this.contentPageData.UpdateContentPageHotel(referentpage,urlimage);
        }


        //PUBLICITY
        public List<ContentPage> GetContentPagePublicity(string reference)
        {
            List<ContentPage> publicity = new List<ContentPage>();
            publicity = this.contentPageData.GetAllContentPage().FindAll(cp => cp.referentpage == reference);

            return publicity;
        }

        public int AddPublicity(ContentPage contentPage)
        {
            return contentPageData.AddPublicity(contentPage);
        }

        public int UpdatePublicity(ContentPage contentPage )
        {
            return contentPageData.UpdatePublicity(contentPage);
        }
        public int DeletePublicity(int id)
        {
            return this.contentPageData.DeletePublicity(id); 
        }



    }
}
