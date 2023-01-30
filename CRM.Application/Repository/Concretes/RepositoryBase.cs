using CRM.Application.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRM.Application.Repository.Concretes;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected CrmContext Context { get; set; }
    public RepositoryBase(CrmContext crmContext)
    {
        Context = crmContext;
    }

    public IQueryable<T> FindAll() => Context.Set<T>().AsNoTracking();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
        Context.Set<T>().Where(expression).AsNoTracking();

    public void Create(T entity) => Context.Set<T>().Add(entity);

    public void Update(T entity) => Context.Set<T>().Update(entity);

    public void Delete(T entity) => Context.Set<T>().Remove(entity);
}