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
    public class RatesController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public RatesController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        // GET: Facilities
        public ActionResult Home()
        {
            RepositoryTypeRoom repositoryTypeRoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTypeRoom.GetAllTypeRoom();
            List<TypeRoomModel> typeRoomModel = new List<TypeRoomModel>();
            DateTime date = DateTime.Today;
            for (int i = 0; i < typeRoom.Count; i++)
            {
                
                TypeRoomModel typeRoomNew = new TypeRoomModel();
                typeRoomNew.quantityperson = typeRoom[i].quantityperson;
                typeRoomNew.quantitybed = typeRoom[i].quantitybed;
                typeRoomNew.description = typeRoom[i].description;
                typeRoomNew.amount = typeRoom[i].amount;
                typeRoomNew.urlimage = typeRoom[i].urlimage;
                typeRoomNew.descriptiontyperoom = typeRoom[i].descriptiontyperoom;
                if (date.ToString("MM")=="12" || date.ToString("MM") == "01" || date.ToString("MM") == "02" || date.ToString("MM") == "03") {
                    typeRoomNew.amount += Convert.ToInt32(typeRoomNew.amount * 0.1);
                }

                    typeRoomModel.Add(typeRoomNew);

            }

            return View(typeRoomModel);
        }
    }
}