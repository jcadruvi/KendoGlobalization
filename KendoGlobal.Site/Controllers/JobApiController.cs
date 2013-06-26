using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KendoGlobal.Models;

namespace Mvc4.Controllers
{
    public class JobApiController : ApiController
    {
        public IEnumerable<Job> GetJobs()
        {
            ICollection<Job> jobs = new Collection<Job>();
            jobs.Add(new Job
            {
                Id = 1,
                Name = "Job 1",
                StartDate = DateTime.Parse("01/01/2013"),
                EndDate = DateTime.Parse("03/01/2013")
            });
            jobs.Add(new Job
            {
                Id = 2,
                Name = "Job 2",
                StartDate = DateTime.Parse("01/02/2013"),
                EndDate = DateTime.Parse("03/02/2013")
            });
            jobs.Add(new Job
            {
                Id = 3,
                Name = "Job 3",
                StartDate = DateTime.Parse("01/03/2013"),
                EndDate = DateTime.Parse("03/03/2013")
            });
            jobs.Add(new Job
            {
                Id = 4,
                Name = "Job 4",
                StartDate = DateTime.Parse("01/04/2013"),
                EndDate = DateTime.Parse("03/04/2013")
            });
            jobs.Add(new Job
            {
                Id = 5,
                Name = "Job 5",
                StartDate = DateTime.Parse("01/05/2013"),
                EndDate = DateTime.Parse("03/05/2013")
            });
            jobs.Add(new Job
            {
                Id = 6,
                Name = "Job 6",
                StartDate = DateTime.Parse("01/06/2013"),
                EndDate = DateTime.Parse("03/06/2013")
            });
            return jobs;
        }
    }
}
