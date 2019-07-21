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
    public class SomeType2Service : Generics.QueryService<SomeTypeDto2, SomeType2>
    {
        public SomeType2Service(IRepository<SomeType2> repository) : base(repository)
        {
        }
    }
}
