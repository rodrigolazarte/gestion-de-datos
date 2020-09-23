[assembly: WebActivator.PostApplicationStartMethod(typeof(viabana_nuevo.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace viabana_nuevo.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using viabana_nuevo.Servicios;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
            container.RegisterConditional(
                typeof(IRepositorio<>),
                typeof(Repositorio<>),
                c => !c.Handled);
            container.Register<IRepositorioConceptoCategoria, RepositorioConceptoCategoria>(Lifestyle.Scoped);
        }
    }
}