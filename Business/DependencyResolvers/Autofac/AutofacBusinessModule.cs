using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.İnterceptars;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();



            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<CityDal>().As<ICityDal>().SingleInstance();



            builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
            builder.RegisterType<PersonDal>().As<IPersonDal>().SingleInstance();


            builder.RegisterType<UniversityManager>().As<IUniversityService>().SingleInstance();
            builder.RegisterType<UniversityDal>().As<IUniversityDal>().SingleInstance();


            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<ImageDal>().As<IImageDal>().SingleInstance();
 
            builder.RegisterType<FileHeplerManager>().As<IFileHelper>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
