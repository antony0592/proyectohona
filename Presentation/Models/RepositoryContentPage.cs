using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain;

namespace Presentation.Models
{
    public class RepositoryContentPage
    {

        ContentPageBusiness contentepageBusiness;
        public RepositoryContentPage(string connectionString)
        {
            this.contentepageBusiness = new ContentPageBusiness(connectionString);
        }

        public List<ContentPage> GetAllContentPage()
        {
            return contentepageBusiness.GetAllContentPage();
        }

    }
}
