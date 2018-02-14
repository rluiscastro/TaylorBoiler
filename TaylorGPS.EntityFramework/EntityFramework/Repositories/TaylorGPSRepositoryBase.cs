using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TaylorGPS.EntityFramework.Repositories
{
    public abstract class TaylorGPSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TaylorGPSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TaylorGPSRepositoryBase(IDbContextProvider<TaylorGPSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TaylorGPSRepositoryBase<TEntity> : TaylorGPSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TaylorGPSRepositoryBase(IDbContextProvider<TaylorGPSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
