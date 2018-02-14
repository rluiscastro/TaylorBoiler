using System.Data.Common;
using Abp.Zero.EntityFramework;
using TaylorGPS.Authorization.Roles;
using TaylorGPS.Authorization.Users;
using TaylorGPS.MultiTenancy;

namespace TaylorGPS.EntityFramework
{
    public class TaylorGPSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TaylorGPSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TaylorGPSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TaylorGPSDbContext since ABP automatically handles it.
         */
        public TaylorGPSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TaylorGPSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TaylorGPSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
