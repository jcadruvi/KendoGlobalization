using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoGlobal.Services
{
    public interface ICultureService
    {
        string GetCurrentCulture();
        void SetCurrentCutlure(string culture);
    }
}
