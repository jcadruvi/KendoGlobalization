using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoGlobal.Models
{
    public class Job
    {
        public DateTime EndDate { get; set; }
        public int Id { get; set; }
        public decimal Percent { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}