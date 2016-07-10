using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
using Ninject;
using NotesManager.Domain.Abstract;
using System.Collections.Generic;
using NotesManager.Domain.Concrete;
using NotesManager.WebUI.Infrastructure.Abstract;
using NotesManager.WebUI.Infrastructure.Concrete;

namespace NotesManager.WebUI.Infrastructure
{   //ralization user fabric conrollers
    //inhereted from fabric used default
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            // create container
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

       protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext,
       Type controllerType)
        {
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            // configure conteiner
            ninjectKernel.Bind<INoteRepository>().To<EFNoteRepository>();
            ninjectKernel.Bind<IUserRepository>().To<EFUserRepository>();
            ninjectKernel.Bind<IUserAccessPermissions>().To<EFUserAccessPermissions>();
            ninjectKernel.Bind<IUserAccPerm>().To<UserAccPerm>();
            ninjectKernel.Bind<IAuthProvider>().To<FormsAuthProvider>();     
        }
         

    }
}