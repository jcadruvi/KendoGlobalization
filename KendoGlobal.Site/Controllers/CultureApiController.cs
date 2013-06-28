using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KendoGlobal.Services;

namespace KendoGlobal.Controllers
{
    public class CultureApiController : ApiController
    {
        private ICollection<KeyValuePair<string, string>> _cultures;
        private ICultureService _service;
        public CultureApiController(ICultureService service)
        {
            _cultures = new Collection<KeyValuePair<string, string>>();
            _cultures.Add(new KeyValuePair<string, string>("bg-BG", "Bulgarian"));
            _cultures.Add(new KeyValuePair<string, string>("de-DE", "German"));
            _cultures.Add(new KeyValuePair<string, string>("en-GB", "English GB"));
            _cultures.Add(new KeyValuePair<string, string>("en-US", "English US"));
            _cultures.Add(new KeyValuePair<string, string>("fr-FR", "French"));
            _service = service;
        }
        public IEnumerable<KeyValuePair<string, string>> GetCultures()
        {
            return _cultures;
        }
        [HttpPut]
        public void SetCulture(string culture)
        {
            _service.SetCurrentCutlure(culture);
        }
    }
}
