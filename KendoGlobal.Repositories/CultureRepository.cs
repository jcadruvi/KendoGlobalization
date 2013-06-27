using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoGlobal.Repositories
{
    public class CultureRepository
    {
        private static CultureRepository _instance = new CultureRepository();
        public static CultureRepository Instance { get { return _instance; } }
        public string CurrentCulture { get; set; }
        static CultureRepository()
        {
            
        }
        private CultureRepository()
        {
            
        }
    }
}
