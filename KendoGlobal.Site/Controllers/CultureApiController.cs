using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KendoGlobal.Controllers
{
    public class CultureApiController : ApiController
    {
        private ICollection<KeyValuePair<string, string>> _cultures;
        public CultureApiController()
        {
            _cultures = new Collection<KeyValuePair<string, string>>();
            _cultures.Add(new KeyValuePair<string, string>("en-US", "English US"));
            _cultures.Add(new KeyValuePair<string, string>("en-GB", "English GB"));
        }
        public IEnumerable<KeyValuePair<string, string>> GetCultures()
        {
            return _cultures;
        }
    }
}
