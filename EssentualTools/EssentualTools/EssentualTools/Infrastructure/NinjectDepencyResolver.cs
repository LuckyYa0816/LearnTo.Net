using EssentualTools.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentualTools.Infrastructure
{
    public class NinjectDepencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDepencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind <IValueCalculator>().To<LinqValueCalculator>().InSingletonScope();
            kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>()
                //.WithPropertyValue("DiscountSize",50M);
                .WithConstructorArgument("discountParam",50M);
            kernel.Bind<IDiscountHelper>().To<FlexibleDiscountHelper>()
                .WhenInjectedInto<LinqValueCalculator>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }


    }
}