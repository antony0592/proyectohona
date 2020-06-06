using System;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Authorization;
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
        string connectionString = "";

        public AdministratorPublicityController(IConfiguration configuration)
        {
            _configuration = configuration;
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
        public JsonResult Add(string content, IFormFile files)
        {
            var filestt = files.FileName;

            return Json(filestt);
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            ContentPageModel cp = new ContentPageModel(connectionString);
            return Json(cp.DeletePublicity(id));
        }

    }
}
