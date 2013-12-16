using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using AbmsgModel.Repositories;
using AbmsgModel;
using System.Web.Http;

namespace Abmsg
{
  public static class Bootstrapper
  {
      public static IUnityContainer Initialise()
      {
          var container = BuildUnityContainer();

          DependencyResolver.SetResolver(new UnityDependencyResolver(container));

          GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

          return container;
      }

    private static IUnityContainer BuildUnityContainer()
    {
        IUnityContainer myContainer = new UnityContainer();

        RepositoryFactories repositoryFactory = new RepositoryFactories();          // This is the backend where our repositories are stored.

        myContainer.RegisterInstance<RepositoryFactories>(repositoryFactory);       // Will provide a singleton for RepositoryFactory
        myContainer.Resolve<RepositoryFactories>();

        myContainer.RegisterType<IRepositoryProvider, RepositoryProvider>();         // This is what provide repositories to Unit Of Work

        myContainer.RegisterType<IUow, Uow>();

        return myContainer;
    }

  }
}