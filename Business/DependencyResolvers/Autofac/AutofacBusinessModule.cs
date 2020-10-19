using Autofac;
using Business.Abstract;
using Business.Concrate;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CourseManager>().As<ICourseService>();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>();

            builder.RegisterType<CurriculumManager>().As<ICurriculumService>();
            builder.RegisterType<EfCurriculumDal>().As<ICurriculumDal>();

            builder.RegisterType<InstructorManager>().As<IInstructorService>();
            builder.RegisterType<EfInstructorDal>().As<IInstructorDal>();

            builder.RegisterType<SectionManager>().As<ISectionService>();
            builder.RegisterType<EfSectionDal>().As<ISectionDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();


        }
    }
}
