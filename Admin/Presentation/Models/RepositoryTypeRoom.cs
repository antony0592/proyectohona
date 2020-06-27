using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Presentation.Models
{
    public class RepositoryTypeRoom
    {

        TypeRoomBusiness typeRoomBusiness;

        private readonly IHostingEnvironment environment;

        public RepositoryTypeRoom(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public RepositoryTypeRoom(string connectionString)
        {
            this.typeRoomBusiness = new TypeRoomBusiness(connectionString);
        }

        public List<TypeRoom> GetAllTypeRoom()
        {
            return typeRoomBusiness.GetAllTypeRoom();
        }

        public List<TypeRoom> Getroom(string description)
        {
            return typeRoomBusiness.Getroom(description);
        }

        public void UpdateTypeRoom(string description, string amount, string urlimage, int descriptionType)
        {
            typeRoomBusiness.UpdateTypeRoom(description, amount, urlimage, descriptionType);
        }

        public int SaveImage(IFormFile file, string folderFiles)
        {
            var filePath = Path.Combine(folderFiles, file.FileName);
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    fileStream.Close();
                }
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}