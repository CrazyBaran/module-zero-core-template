using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.IGenerics
{
    public interface IQueryService<T> : IApplicationService where T : IEntityDto<string>
    {
        IQueryable<T> GetAllQueryable();
    }
}
