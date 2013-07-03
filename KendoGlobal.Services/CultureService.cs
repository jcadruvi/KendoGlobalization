﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            string culture = _repository.CurrentCulture;
            if (culture == null) 
            {
                culture = "en-US";
            }
            return culture;
        }
        public void SetCurrentCutlure(string culture)
        {
            _repository.CurrentCulture = culture;
        }
    }
}
