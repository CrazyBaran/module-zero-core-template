using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AbpCompanyName.AbpProjectName.IGenerics;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Generics
{
    public abstract class QueryService<T, TE> : ApplicationService, IQueryService<T> where T : IEntityDto<string> where TE : class, IEntity
    {
        protected readonly IRepository<TE> _repository;
        public QueryService(IRepository<TE> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public IQueryable<T> GetAllQueryable()
        {
            return _repository.GetAll().ProjectTo<T>();
        }
    }
}
