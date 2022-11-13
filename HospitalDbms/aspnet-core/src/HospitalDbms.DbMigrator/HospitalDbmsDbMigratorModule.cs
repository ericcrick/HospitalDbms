using HospitalDbms.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HospitalDbms.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HospitalDbmsEntityFrameworkCoreModule),
    typeof(HospitalDbmsApplicationContractsModule)
    )]
public class HospitalDbmsDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
