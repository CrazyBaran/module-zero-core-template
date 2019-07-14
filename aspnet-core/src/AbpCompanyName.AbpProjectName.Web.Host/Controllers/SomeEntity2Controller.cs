using Abp.AspNetCore.Mvc.Controllers;
using AbpCompanyName.AbpProjectName.IGenerics;
using AbpCompanyName.AbpProjectName.SomeEntities;
using AbpCompanyName.AbpProjectName.SomeEntitiesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Web.Host.Controllers
{
    public class SomeEntity2Controller : AbpController
    {
        public SomeEntity2Controller(IQueryService<SomeEntityDto2> queryService)
        {

        }

        
        public string Get()
        {
            return "test";
        }
    }
}
