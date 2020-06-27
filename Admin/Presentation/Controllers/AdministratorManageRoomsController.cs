using System;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorManageRoomsController : Controller
    {
        public static string counter;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment environment;
        string connectionString = "";

        public AdministratorManageRoomsController(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            this.environment = environment;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        // GET: /<controller>/
        public IActionResult ManageRooms()
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            TypeRoomModel typeRoomModel = new TypeRoomModel(connectionString);
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            RoomModel room = new RoomModel(connectionString);
            IList<Room> listRoom = room.GetAllRoom();
            List<RoomModel> roomModel = new List<RoomModel>();

            ReservationModel reservation = new ReservationModel(connectionString);
            IList<Reservation> listReservation = reservation.GetAllReservation();
            List<ReservationModel> reservationModel = new List<ReservationModel>();

            for (int i = 0; i < listRoom.Count; i++)
            {
                RoomModel roomNew = new RoomModel(connectionString);
                roomNew.state = listRoom[i].state;
                roomNew.number = listRoom[i].number;
                roomNew.idtyperoom = listRoom[i].idtyperoom;
                roomModel.Add(roomNew);
            }
            for (int j = 0; j < typeRoom.Count; j++)
            {
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[j].description;
                typeRoomNew.id = typeRoom[j].id;
                typeroomModel.Add(typeRoomNew);
            }
            for (int j = 0; j < listReservation.Count; j++)
            {
                ReservationModel reservationNew = new ReservationModel(connectionString);
                reservationNew.idroom = listReservation[j].idroom;
                reservationModel.Add(reservationNew);
            }
            ViewBag.reservation = reservationModel;
            ViewBag.room = roomModel;
            return View(typeroomModel);
        }

        public JsonResult GetManageRooms(string description)
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            List<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();

            TypeRoom typeRoomNew = new TypeRoom();
            typeRoomNew = typeRoom.Find(r => r.description == description);
            counter = description;
            return Json(typeRoomNew);
        }

        [HttpPost]
        public ActionResult Update(IFormFile file, string descriptionArea, string amount)
        {            
            String descriptionType = counter;

            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            string urlimage = "";
            var path = "./images/TipoHabitacion/";
            var pathClient = "../../../Client/Presentation/wwwroot/images/TipoHabitacion/";
            string folderFiles = Path.Combine(environment.WebRootPath, path);
            string folderFilesClient = Path.Combine(environment.WebRootPath, pathClient);

            int idTypeRoom = 0;

            if (file != null)
            {
                repositoryTyperoom.SaveImage(file, folderFiles);
                repositoryTyperoom.SaveImage(file, folderFilesClient);
                urlimage = "/images/TipoHabitacion/" + file.FileName;
            }

            for (int i = 0; i < typeRoom.Count; i++)
            {
                if (typeRoom[i].description == descriptionType)
                {
                    idTypeRoom = typeRoom[i].id;
                }
                if (file == null)
                {
                    urlimage = typeRoom[i].urlimage;
                }
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[i].description;
                typeroomModel.Add(typeRoomNew);
            }
            repositoryTyperoom.UpdateTypeRoom(descriptionArea, amount, urlimage, idTypeRoom);
            
            RoomModel room = new RoomModel(connectionString);
            IList<Room> listRoom = room.GetAllRoom();
            List<RoomModel> roomModel = new List<RoomModel>();

            for (int i = 0; i < listRoom.Count; i++)
            {
                RoomModel roomNew = new RoomModel(connectionString);
                roomNew.state = listRoom[i].state;
                roomNew.number = listRoom[i].number;
                roomNew.idtyperoom = listRoom[i].idtyperoom;
                roomModel.Add(roomNew);
            }
            ViewBag.room = roomModel;
            return RedirectToAction("ManageRooms");
        }
    }
}