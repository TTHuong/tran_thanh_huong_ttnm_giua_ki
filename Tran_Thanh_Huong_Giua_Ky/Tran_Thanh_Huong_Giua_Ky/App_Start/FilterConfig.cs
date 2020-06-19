using System.Web;
using System.Web.Mvc;

namespace Tran_Thanh_Huong_Giua_Ky
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
