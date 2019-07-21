using Abp.AspNetCore.Mvc.Controllers;
using AbpCompanyName.AbpProjectName.IGenerics;
using AbpCompanyName.AbpProjectName.SomeEntitiesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Web.Host.Controllers
{
    public class SomeEntityController : AbpController
    {
        public SomeEntityController(IQueryService<SomeTypeDto> queryService)
        {

        }
    }
}
