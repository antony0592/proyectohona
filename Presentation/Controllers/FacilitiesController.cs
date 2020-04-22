using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using Domain;


namespace Presentation.Controllers
{
    public class FacilitiesController : Controller
    {

        private readonly IConfiguration _configuration;
        string connectionString = "";

        public FacilitiesController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        // GET: Facilities
        public ActionResult Home()
        {
            RepositoryContentPage contentpageModel = new RepositoryContentPage(connectionString);
            IList<ContentPage> content = contentpageModel.GetAllContentPage();
            List<ContentPageModel> contentPage = new List<ContentPageModel>();

            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].referentpage.Equals("facility"))
                {
                    ContentPageModel contentNew = new ContentPageModel();
                    contentNew.referentpage = content[i].referentpage;
                    contentNew.urlimage = content[i].urlimage;
                    contentNew.typeimage = content[i].typeimage;
                    contentNew.content = content[i].content;
                    contentPage.Add(contentNew);
                }
            }
            return View(contentPage);
        }
    }
}