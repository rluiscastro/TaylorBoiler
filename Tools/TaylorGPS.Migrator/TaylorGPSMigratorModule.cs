using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TaylorGPS.EntityFramework;

namespace TaylorGPS.Migrator
{
    [DependsOn(typeof(TaylorGPSDataModule))]
    public class TaylorGPSMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TaylorGPSDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}