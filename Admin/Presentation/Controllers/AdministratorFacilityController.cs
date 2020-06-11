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
    public class AdministratorFacilityController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment environment;
        string connectionString = "";

        public AdministratorFacilityController(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            this.environment = environment;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }


        // GET: /<controller>/
        [Authorize]
        public ActionResult Facility()
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            List<ContentPage> contentfacility = cp.GetContentPageFacility("facility");

            ViewBag.contentPage = contentfacility;
            return View();
        }

        public JsonResult GetFacilityById(int id)
        {

            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.GetContentPageFacility("facility").Find(p => p.id == id));

        }

        public JsonResult ListAll()
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.GetContentPageFacility("facility"));

        }



        [HttpPost]
        public JsonResult AddUpdateFacility(int idFacility, string content, IFormFile files)
        {

            ContentPageModel contentPageModel = new ContentPageModel(connectionString);
            FacilityModel facilityModel = new FacilityModel(environment);

            var path = "./images/Facilidades/";
            var pathClient = "../../../Client/Presentation/wwwroot/images/Facilidades/";
            string folderFiles = Path.Combine(environment.WebRootPath, path);
            string folderFilesClient = Path.Combine(environment.WebRootPath, pathClient);
            int resultSaveImage = facilityModel.SaveImage(files, folderFiles);

            int resultSaveImage2 = facilityModel.SaveImage(files, folderFilesClient);

            int resultSaveFacility = 0;

            if (resultSaveImage > 0)
            {
                ContentPage facility = new ContentPage()
                {
                    id = idFacility,
                    referentpage = "facility",
                    urlimage = "/images/Facilidades/" + files.FileName,
                    typeimage = "1",
                    content = content
                };

                //save or update Facility
                if (idFacility == 0)
                {
                    resultSaveFacility = contentPageModel.AddFacility(facility);
                }
                else
                {
                    resultSaveFacility = contentPageModel.UpdateFacility(facility);
                }

            }

            if (resultSaveImage < 1 || resultSaveFacility < 1 || resultSaveImage2 < 1)
            {
                return null;
            }

            return Json(1);
        }

        public JsonResult DeleteFacility(int id)
        {
            ContentPageModel publicityModel = new ContentPageModel(connectionString);
            return Json(publicityModel.DeleteFacility(id));
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.DeleteFacility(id));
        }

    }
}
