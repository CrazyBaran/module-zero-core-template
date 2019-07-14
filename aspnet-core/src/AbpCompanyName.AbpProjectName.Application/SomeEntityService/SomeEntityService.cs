using Abp.Domain.Repositories;
using AbpCompanyName.AbpProjectName.SomeEntities;
using AbpCompanyName.AbpProjectName.SomeEntitiesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.SomeEntityService
{
    public class SomeEntityService : Generics.QueryService<SomeEntityDto, SomeEntity>
    {
        public SomeEntityService(IRepository<SomeEntity> repository) : base(repository)
        {
        }
    }
}
