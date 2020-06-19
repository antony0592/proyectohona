using System;
using System.Collections.Generic;
using System.IO;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorPublicityController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment environment;
        string connectionString = "";

        public AdministratorPublicityController(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            this.environment = environment;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }


        // GET: /<controller>/
        [Authorize]
        public ActionResult Publicity()
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            List<ContentPage> contentpublicity = cp.GetContentPagePublicity("publicity");
            ViewBag.contentPage = contentpublicity;
            return View();
        }

        public JsonResult GetPublicityById(int id) {

            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.GetContentPagePublicity("publicity").Find(p=>p.id==id));

        }

        public JsonResult ListAll()
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.GetContentPagePublicity("publicity"));

        }

    

        [HttpPost]
        public JsonResult AddUpdatePublicity(int idPublicity, string content, IFormFile files)
        {
            if (files == null & idPublicity==0 & content==null) 
            {
                return Json(0);
            }

            ContentPageModel contentPageModel = new ContentPageModel(connectionString);
            PublicityModel publicityModel = new PublicityModel(environment);

            var path = "./images/Publicidad/";
            var pathClient = "../../../Client/Presentation/wwwroot/images/Publicidad/";
            string folderFiles = Path.Combine(environment.WebRootPath, path);
            string folderFilesClient = Path.Combine(environment.WebRootPath, pathClient);
            int resultSaveImage = 0;
            int resultSaveImage2 = 0;
            int resultSavePublicity = 0;

            if (files != null) 
            {
                resultSaveImage = publicityModel.SaveImage(files, folderFiles);
                resultSaveImage2 = publicityModel.SaveImage(files, folderFilesClient);
                if (resultSaveImage > 0)
                {
                    ContentPage publicity = new ContentPage()
                    {
                        id = idPublicity,
                        referentpage = "publicity",
                        urlimage = "/images/Publicidad/" + files.FileName,
                        typeimage = "1",
                        content = content
                    };

                    //save or update publicity
                    if (idPublicity == 0 & files != null & content != null)
                    {
                        //save new publicity
                        resultSavePublicity = contentPageModel.AddPublicity(publicity);
                    }
                    else if (idPublicity > 0 & content != null)
                    {
                        //save complete update publicity
                        resultSavePublicity = contentPageModel.UpdatePublicity(publicity);
                    }
                }
            }

            if (idPublicity > 0 & content != null & files == null)
            {
                //save update publicity only content
                ContentPage publicity = new ContentPage()
                {
                    id = idPublicity,
                    referentpage = "publicity",
                    urlimage = "",
                    typeimage = "1",
                    content = content
                };
                resultSavePublicity = contentPageModel.UpdatePublicityContent(publicity);
            }

            if (resultSavePublicity < 1) 
            {
                return Json(0);
            }

            return Json(1);
        }

        public JsonResult DeletePublicity(int id) 
        {
            ContentPageModel  publicityModel = new ContentPageModel(connectionString);
            return Json(publicityModel.DeletePublicity(id));
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.DeletePublicity(id));
        }

    }
}
