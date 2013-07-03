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
        
        public string CurrencyDecimalSeperator { get; set; }
        public string CurrencyGroupSeperator { get; set; }
        public string CurrencySymbol { get; set; }
        public string DateFormat { get; set; }
        
        public BaseViewModel()
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            Culture = cultureInfo.Name;
            CurrencyDecimalSeperator = cultureInfo.NumberFormat.CurrencyDecimalSeparator;
            CurrencyGroupSeperator = cultureInfo.NumberFormat.CurrencyGroupSeparator;
            CurrencySymbol = cultureInfo.NumberFormat.CurrencySymbol;
            DateFormat = cultureInfo.DateTimeFormat.ShortDatePattern;
        }
    }
}