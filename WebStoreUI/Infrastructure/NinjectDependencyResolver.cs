using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Moq;
using Ninject;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace WebStoreUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {

            Mock<IBookRepository> mock = new Mock<Domain.Abstract.IBookRepository>();
            mock.Setup(m => m.Books).Returns(new List<Book>
    {
        new Book { Name = "Witcher", Price = 200 },
        new Book { Name = "Clear Code", Price=300 },
    });
            kernel.Bind<IBookRepository>().ToConstant(mock.Object);
        }
    }
}