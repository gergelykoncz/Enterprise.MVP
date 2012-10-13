using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web;

[assembly: WebActivator.PreApplicationStartMethod(typeof(WebUI.App_Start.NinjectWeb), "Start")]

namespace WebUI.App_Start
{
    public static class NinjectWeb 
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}
