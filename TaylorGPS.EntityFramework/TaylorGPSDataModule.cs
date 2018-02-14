using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TaylorGPS.EntityFramework;

namespace TaylorGPS
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TaylorGPSCoreModule))]
    public class TaylorGPSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TaylorGPSDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
