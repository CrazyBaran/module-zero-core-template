using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCompanyName.AbpProjectName.Configuration;
using AbpCompanyName.AbpProjectName.IGenerics;

namespace AbpCompanyName.AbpProjectName.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpProjectNameWebCoreModule))]
    public class AbpProjectNameWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpProjectNameWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpProjectNameWebHostModule).GetAssembly());

            var resolve = IocManager.IocContainer.Resolve<IQueryService<SomeEntitiesDto.SomeEntityDto>>(); //Here is test of registration
        }
    }
}
