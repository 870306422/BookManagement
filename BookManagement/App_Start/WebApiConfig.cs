using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
<<<<<<< HEAD
using System.Web.Http.Cors;
=======
>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1

namespace BookManagement
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
<<<<<<< HEAD
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
=======

>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
