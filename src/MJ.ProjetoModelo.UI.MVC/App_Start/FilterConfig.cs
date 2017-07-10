using System.Web;
using System.Web.Mvc;

namespace MJ.ProjetoModelo.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
