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
        private ICollection<Job> _jobs; 
        public JobApiController()
        {
            _jobs = new Collection<Job>();
            _jobs.Add(new Job
            {
                Id = 1,
                Percent = (decimal).01,
                Price = (decimal)1100.01,
                Name = "Job 1",
                StartDate = DateTime.Parse("01/21/2013"),
                EndDate = DateTime.Parse("03/21/2013")
            });
            _jobs.Add(new Job
            {
                Id = 2,
                Percent = (decimal).02,
                Price = (decimal)2200.02,
                Name = "Job 2",
                StartDate = DateTime.Parse("01/22/2013"),
                EndDate = DateTime.Parse("03/22/2013")
            });
            _jobs.Add(new Job
            {
                Id = 3,
                Percent = (decimal).03,
                Price = (decimal)3300.03,
                Name = "Job 3",
                StartDate = DateTime.Parse("01/23/2013"),
                EndDate = DateTime.Parse("03/23/2013")
            });
            _jobs.Add(new Job
            {
                Id = 4,
                Percent = (decimal).04,
                Price = (decimal)4400.04,
                Name = "Job 4",
                StartDate = DateTime.Parse("01/24/2013"),
                EndDate = DateTime.Parse("03/24/2013")
            });
            _jobs.Add(new Job
            {
                Id = 5,
                Percent = (decimal).05,
                Price = (decimal)5500.05,
                Name = "Job 5",
                StartDate = DateTime.Parse("01/25/2013"),
                EndDate = DateTime.Parse("03/25/2013")
            });
            _jobs.Add(new Job
            {
                Id = 6,
                Percent = (decimal).06,
                Price = (decimal)6600.06,
                Name = "Job 6",
                StartDate = DateTime.Parse("01/26/2013"),
                EndDate = DateTime.Parse("03/26/2013")
            });
        }
        public Job GetJob(int id)
        {
            return _jobs.First(j => j.Id == id);
        }
        public IEnumerable<Job> GetJobs()
        {
            return _jobs;
        }
        [HttpPost]
        public object Post(JobViewModel job)
        {
            return null;
        }
    }
}
