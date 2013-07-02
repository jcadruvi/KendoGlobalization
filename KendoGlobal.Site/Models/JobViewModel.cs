using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoGlobal.Models
{
    public class JobViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Percent { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}