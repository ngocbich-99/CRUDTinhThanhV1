using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using test2.EntityFrameworkCore;
using test2.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace test2.Web.Tests
{
    [DependsOn(
        typeof(test2WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class test2WebTestModule : AbpModule
    {
        public test2WebTestModule(test2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(test2WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(test2WebMvcModule).Assembly);
        }
    }
}