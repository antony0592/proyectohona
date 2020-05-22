using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorManageRoomsController : Controller
    {
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
            //***********************************************//
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            for (int i = 0; i < typeRoom.Count; i++)
            {
                TypeRoomModel typeRoomNew = new TypeRoomModel();
                typeRoomNew.description = typeRoom[i].description;                
                typeroomModel.Add(typeRoomNew);
            }
            return View(typeroomModel);
        }


        [HttpPost]
        public IActionResult ManageRooms(string description)
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            for (int i = 0; i < typeRoom.Count; i++)
            {
                if (typeRoom[i].description.Equals(description))
                {
                    ViewBag.description= typeRoom[i].description;
                    ViewBag.urlimage = typeRoom[i].urlimage;
                    ViewBag.descriptiontyperoom = typeRoom[i].descriptiontyperoom;
                    ViewBag.amount = typeRoom[i].amount;
                }
                TypeRoomModel typeRoomNew = new TypeRoomModel();
                typeRoomNew.description = typeRoom[i].description;
                typeroomModel.Add(typeRoomNew);
            }
            return View(typeroomModel);

            }


            //[HttpPost]
            //public ActionResult GetRoomUpdate(string description)
            //{
            //    RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            //    IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();

            //    for (int i = 0; i < typeRoom.Count; i++)
            //    {
            //        if (typeRoom[i].description.Equals(description))
            //        {
            //            ViewBag.urlimage = typeRoom[i].urlimage;
            //            ViewBag.descriptiontyperoom = typeRoom[i].descriptiontyperoom;
            //            ViewBag.amount = typeRoom[i].amount;
            //        }

            //    }
            //    return View();

            //}

            //public JsonResult Getroom(string description)
            //{
            //    {
            //        RepositoryTypeRoom typeRoomModel = new RepositoryTypeRoom(connectionString);
            //        var search = typeRoomModel.Getroom(description);
            //        return Json(search);
            //    }
            //}
        }
    }
