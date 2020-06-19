using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Season
    {

        public Season(int id, int idtyperoom, string dateinputseason, string dateoutputseason, string description, int state, int percentation)
        {
            this.id = id;
            this.idtyperoom = idtyperoom;
            this.dateinputseason = dateinputseason;
            this.dateoutputseason = dateoutputseason;
            this.description = description;
            this.state = state;
            this.percentation = percentation;
        }

        public Season()
        {
            this.id = 0;
            this.idtyperoom = 0;
            this.dateinputseason = null;
            this.dateoutputseason = null;
            this.description = "";
            this.state = 0;
            this.percentation = 0;
        }

        public int id { get; set; }
        public int idtyperoom { get; set; }
        public string dateinputseason { get; set; }
        public string dateoutputseason { get; set; }
        public string description { get; set; }
        public int state { get; set; }
        public int percentation { get; set; }
    }

}
