using System.Web.Mvc;

namespace SoftSupply.Help.Areas.PotSoft
{
    public class PotSoftAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PotSoft";
            }
        }
        
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}