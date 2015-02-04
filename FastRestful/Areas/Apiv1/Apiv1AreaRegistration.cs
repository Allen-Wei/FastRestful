using System.Web.Mvc;

namespace FastRestful.Areas.Apiv1
{
    public class Apiv1AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Apiv1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Apiv1_default",
                "Apiv1/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
