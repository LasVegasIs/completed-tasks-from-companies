using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
using Ninject;
using Moq;
using GoodsStore.Domain.Abstract;
using System.Collections.Generic;
using GoodsStore.Domain.Concrete;

namespace GoodsStore.WebUI.Infrastructure
{
    // реализация пользовательской фабрики контроллеров,
    // наследуясь от фабрики используемой по умолчанию
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            // создание контейнера
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

       protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext,
       Type controllerType)
        {
            // получение объекта контроллера из контейнера
            // используя его тип
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            // конфигурирование контейнера
            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();
            ninjectKernel.Bind<IShopRepository>().To<EFShopRepository>();
        }
         

    }
}