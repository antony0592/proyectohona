using Business;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Presentation.Models
{
    public class ContentPageModel:ContentPage
    {
        ContentPageBusiness contentepageBusiness;
        private readonly IHostingEnvironment environment;

        public ContentPageModel(string connectionString)
        {
            this.contentepageBusiness = new ContentPageBusiness(connectionString);
        }
        public ContentPageModel(IHostingEnvironment environment)
        {
            this.environment = environment;
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

        public int SaveImage(IFormFile file, string folderFiles)
        {
            var filePath = Path.Combine(folderFiles, file.FileName);
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    fileStream.Close();
                }
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }

        }



        //PUBLICITY
        public List<ContentPage> GetContentPagePublicity(string reference)
        {
            return contentepageBusiness.GetContentPagePublicity(reference);
        }

        public int AddPublicity(ContentPage contentPage)
        {
            return contentepageBusiness.AddPublicity(contentPage);
        }

        public int UpdatePublicity(ContentPage contentPage)
        {
            return contentepageBusiness.UpdatePublicity(contentPage);
        }

        public int UpdatePublicityContent(ContentPage contentPage)
        {
            return contentepageBusiness.UpdatePublicityContent(contentPage);
        }
        public int DeletePublicity(int id)
        {
            return contentepageBusiness.DeletePublicity(id);
        }

        //FACILITY
        public List<ContentPage> GetContentPageFacility(string reference)
        {
            return contentepageBusiness.GetContentPageFacility(reference);
        }

        public int AddFacility(ContentPage contentPage)
        {
            return contentepageBusiness.AddFacility(contentPage);
        }

        public int UpdateFacility(ContentPage contentPage)
        {
            return contentepageBusiness.UpdateFacility(contentPage);
        }
        public int DeleteFacility(int id)
        {
            return contentepageBusiness.DeleteFacility(id);
        }

    }

    public class PublicityModel : ContentPage
    {
        private readonly IHostingEnvironment environment;
        public PublicityModel(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public int SaveImage(IFormFile files, string folderFiles)
        {
            var filePath = Path.Combine(folderFiles, files.FileName);
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    files.CopyTo(fileStream);
                    fileStream.Close();
                }
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
           
        }
    }

    public class FacilityModel : ContentPage
    {
        private readonly IHostingEnvironment environment;
        public FacilityModel(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public int SaveImage(IFormFile files, string folderFiles)
        {
            var filePath = Path.Combine(folderFiles, files.FileName);
            if (filePath==null) { return 0; }
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    files.CopyTo(fileStream);
                    fileStream.Close();
                }
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}
