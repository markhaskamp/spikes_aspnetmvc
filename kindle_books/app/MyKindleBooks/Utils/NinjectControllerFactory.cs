using System;
using System.Web.Mvc;
using MyKindleBooks.Models;
using Ninject.Core;

namespace MyKindleBooks.Utils
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel = new StandardKernel(new BookRepositoryDependencies());

        protected override IController GetControllerInstance(Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }

        private class BookRepositoryDependencies : StandardModule
        {
            public override void Load()
            {
                Bind<IBookRepository>().To<SampleBookRepository>();
            }
        }
    }
}
