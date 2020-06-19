using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Presentation.Models
{
    public class SeasonModel : Season
    {
        SeasonBusiness seasonBusiness;
        public SeasonModel(string connectionString)
        {
            this.seasonBusiness = new SeasonBusiness(connectionString);
        }

        public SeasonModel()
        {

        }

        public List<Season> GetAllSeason()
        {
            return seasonBusiness.GetAllSeason();
        }

        public void InsertSeason(int id, int idtyperoom, string dateinputseason, string dateoutputseason, string description, int state, int percentation)

        {
            seasonBusiness.InsertSeason(id, idtyperoom, dateinputseason, dateoutputseason, description, state, percentation);
        }

        public void DeleteSeason(int id)
        {
            this.seasonBusiness.DeleteSeason(id);
        }
    }
}
