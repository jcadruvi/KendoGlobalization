using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoGlobal.Repositories;

namespace KendoGlobal.Services
{
    public class CultureService : ICultureService
    {
        private CultureRepository _repository;
        public CultureService()
        {
            _repository = CultureRepository.Instance;
        }
        public string GetCurrentCulture()
        {
            return _repository.CurrentCulture;
        }
        public void SetCurrentCutlure(string culture)
        {
            _repository.CurrentCulture = culture;
        }
    }
}
