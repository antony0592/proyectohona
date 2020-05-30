using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
    public class AdministratorManageRoomsController : Controller
    {
        public static string counter;
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public AdministratorManageRoomsController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            
        }

        // GET: /<controller>/
        public IActionResult ManageRooms()
        {
            //*******//
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            TypeRoomModel typeRoomModel = new TypeRoomModel(connectionString);
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();


            for (int i = 0; i < typeRoom.Count; i++)
            {
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[i].description;
                typeroomModel.Add(typeRoomNew);
            }

            return View(typeroomModel);
        }//

        public JsonResult GetManageRooms(string description)
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            List<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();            
         
            TypeRoom typeRoomNew = new TypeRoom();
            typeRoomNew = typeRoom.Find(r=>r.description==description);
            counter = description;
            return Json(typeRoomNew);
        }

        [HttpPost]
        public ActionResult Update(string file, string descriptionArea, string amount)
        {

            string destinationFile = "/images/TipoHabitacion/" + file;
            Console.WriteLine(destinationFile);
            String urlimage = "/images/TipoHabitacion/ " + file;
            String descriptionType = counter;

            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            int idTypeRoom = 0;

            for (int i = 0; i < typeRoom.Count; i++)
            {
                if (typeRoom[i].description==descriptionType) {
                    idTypeRoom = typeRoom[i].id;
                }
                if (file==null || file=="")
                {
                    urlimage = typeRoom[i].urlimage;
                    
                }
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[i].description;
                typeroomModel.Add(typeRoomNew);
            }
           
            repositoryTyperoom.UpdateTypeRoom(descriptionArea, amount, urlimage, idTypeRoom);
            return View("ManageRooms", typeroomModel);

        }


        [HttpPost]
        public ActionResult ManageRooms(string description)
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            for (int i = 0; i < typeRoom.Count; i++)
            {
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[i].description;
                typeroomModel.Add(typeRoomNew);
            }
            return View(typeRoom);
        }


    }

}