using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace KendoGlobal.Models
{
    public class BaseViewModel
    {
        public string Culture { get; set; }
        public string DateFormat { get; set; }
        
        public BaseViewModel()
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            Culture = cultureInfo.Name;
            DateFormat = cultureInfo.DateTimeFormat.ShortDatePattern;
        }
    }
}