using Livraria.Domain.Interfaces.Services;
using Livraria.Domain.Services;
using Livraria.Presentation.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Livraria.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
        }

        //protected override IKernel CreateKernel()
        //{
        //    return Container;
        //}

        //static IKernel _container;
        //public static IKernel Container
        //{
        //    get
        //    {
        //        if (_container == null)
        //        {
        //            _container = new StandardKernel(new SiteModule());
        //        }
        //        return _container;
        //    }
        //}

        //internal class SiteModule : NinjectModule
        //{
        //    public override void Load()
        //    {
        //        //Set up ninject bindings here.
        //        Bind<ILivroService>().To<LivroService>();
        //    }
        //}
    }
}
