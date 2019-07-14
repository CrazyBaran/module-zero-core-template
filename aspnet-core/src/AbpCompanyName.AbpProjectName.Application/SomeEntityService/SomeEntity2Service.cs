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
    public class SomeEntity2Service : Generics.QueryService<SomeEntityDto2, SomeEntity2>
    {
        public SomeEntity2Service(IRepository<SomeEntity2> repository) : base(repository)
        {
        }
    }
}
