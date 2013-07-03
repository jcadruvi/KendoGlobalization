using KendoGlobal.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace KendoGlobal.Models
{
    public class NullableDateTimeBinder : IModelBinder
    {
        public object BindModel(ControllerContext actionContext, ModelBindingContext modelBindingContext)
        {
            ICultureService service = new CultureService();
            CultureInfo cultureInfo = new CultureInfo(service.GetCurrentCulture());
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            var value = modelBindingContext.ValueProvider.GetValue(modelBindingContext.ModelName);
            if (value != null)
            {
                var date = value.ConvertTo(typeof(DateTime), CultureInfo.CurrentCulture);
                return date;
            }
            return null;
        }

    }
}