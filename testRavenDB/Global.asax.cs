using Raven.Client.Document;
using Raven.Client.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace testRavenDB
{
    // test 2
    public class MvcApplication : System.Web.HttpApplication
    {
        public static DocumentStore MyStore;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MyStore = new DocumentStore { ConnectionStringName = "RavenDB" };
            MyStore.Initialize();

            IndexCreation.CreateIndexes(Assembly.GetCallingAssembly(), MyStore);
        }
    }
}
