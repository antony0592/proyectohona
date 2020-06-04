using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
   public class SeasonBusiness
    {
        private SeasonData seasonData;

        public SeasonBusiness(String connString)
        {
            this.seasonData = new SeasonData(connString);
        }//Fin del constructor.

        public List<Season> GetAllSeason()
        {
            return this.seasonData.GetAllSeason();
        }

        public void InsertSeason(int id, int idtyperoom, string dateinputseason, string dateoutputseason, string description, int state,int percentation)
        {
            this.seasonData.InsertSeason(id, idtyperoom, dateinputseason, dateoutputseason, description, state, percentation);
        }

    }//
}
