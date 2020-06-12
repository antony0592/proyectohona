using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorSeasonController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public AdministratorSeasonController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }
        // GET: /<controller>/
        [Authorize]
        public IActionResult Season()
        {
            SeasonModel seasonModel = new SeasonModel(connectionString);
            IList<Season> season = seasonModel.GetAllSeason();
            List<SeasonModel> seasonModellist = new List<SeasonModel>();

            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();

            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            for (int i = 0; i < season.Count; i++)
            {

                SeasonModel reservationNew = new SeasonModel();
                reservationNew.id = season[i].id;
                reservationNew.percentation = season[i].percentation;
                reservationNew.state = season[i].state;
                reservationNew.dateinputseason = season[i].dateinputseason;
                reservationNew.dateoutputseason = season[i].dateoutputseason;
                reservationNew.description = season[i].description;
                seasonModellist.Add(reservationNew);
            }

            for (int j = 0; j < typeRoom.Count; j++)
            {
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[j].description;
                typeRoomNew.id = typeRoom[j].id;
                typeroomModel.Add(typeRoomNew);
            }

            ViewBag.type = typeroomModel;
            ViewBag.season = seasonModellist;
            return View(typeroomModel);

        }//State

        [Authorize]
        [HttpPost]
        public ActionResult insert(string dateinputseason, string dateoutputseason, string descriptionText, int percentation)
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            SeasonModel seasonModel = new SeasonModel(connectionString);

            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            int idtyperoom = 1;
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            seasonModel.InsertSeason(idtyperoom, dateinputseason, dateoutputseason, descriptionText, 1, percentation);

            Season();

            return View("Season", typeroomModel);

        }


        public ActionResult DeleteSeason(int id)
        {
            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            SeasonModel seasonModel = new SeasonModel(connectionString);
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            for (int j = 0; j < typeRoom.Count; j++)
            {
                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                typeRoomNew.description = typeRoom[j].description;
                typeRoomNew.id = typeRoom[j].id;
                typeroomModel.Add(typeRoomNew);
            }

            seasonModel.DeleteSeason(id);
            Season();

            return View("Season", typeroomModel);

        }

    }
}