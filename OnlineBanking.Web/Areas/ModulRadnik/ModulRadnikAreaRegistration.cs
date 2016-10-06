using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik
{
    public class ModulRadnikAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ModulRadnik";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ModulRadnik_default",
                "ModulRadnik/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}