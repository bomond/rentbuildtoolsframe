using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace rentbuildtoolsframe
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapMvcAttributeRoutes();
			//routes.MapRoute(
			//	"ToolsByRentDay",
			//	"tools/rentdays/{year}/{month}/{day}",
			//	new { controller = "Tools", action = "ByRentDate" },	
			//	new { year = @"2015|2019", month = @"\d{2}", day = @"\d{2}"});
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
