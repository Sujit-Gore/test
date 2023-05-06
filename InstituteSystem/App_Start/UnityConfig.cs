using DatabaseServices.Implementations;
using DatabaseServices.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using DatabaseOperation;

namespace InstituteSystem
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<ISubjectService, SubjectService>();
            container.RegisterType<ISubTechService, SubTechService>();
            container.RegisterType<ITeacherService, TeacherService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}