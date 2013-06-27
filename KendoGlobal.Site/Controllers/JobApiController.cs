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
                Percent = (decimal)1.01,
                Price = (decimal)100.01,
                Name = "Job 1",
                StartDate = DateTime.Parse("01/01/2013"),
                EndDate = DateTime.Parse("03/01/2013")
            });
            _jobs.Add(new Job
            {
                Id = 2,
                Percent = (decimal)2.02,
                Price = (decimal)200.02,
                Name = "Job 2",
                StartDate = DateTime.Parse("01/02/2013"),
                EndDate = DateTime.Parse("03/02/2013")
            });
            _jobs.Add(new Job
            {
                Id = 3,
                Percent = (decimal)3.03,
                Price = (decimal)300.03,
                Name = "Job 3",
                StartDate = DateTime.Parse("01/03/2013"),
                EndDate = DateTime.Parse("03/03/2013")
            });
            _jobs.Add(new Job
            {
                Id = 4,
                Percent = (decimal)4.04,
                Price = (decimal)400.04,
                Name = "Job 4",
                StartDate = DateTime.Parse("01/04/2013"),
                EndDate = DateTime.Parse("03/04/2013")
            });
            _jobs.Add(new Job
            {
                Id = 5,
                Percent = (decimal)5.05,
                Price = (decimal)500.05,
                Name = "Job 5",
                StartDate = DateTime.Parse("01/05/2013"),
                EndDate = DateTime.Parse("03/05/2013")
            });
            _jobs.Add(new Job
            {
                Id = 6,
                Percent = (decimal)6.06,
                Price = (decimal)600.06,
                Name = "Job 6",
                StartDate = DateTime.Parse("01/06/2013"),
                EndDate = DateTime.Parse("03/06/2013")
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
    }
}
