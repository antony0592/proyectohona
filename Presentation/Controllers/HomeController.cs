using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;



namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }



        public IActionResult Index()
        {

            ClientModel clientModel = new ClientModel(connectionString);
            IList<Client> clients = clientModel.GetAllClients();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
