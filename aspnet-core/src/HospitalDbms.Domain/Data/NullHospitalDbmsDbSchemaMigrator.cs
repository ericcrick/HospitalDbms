using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalDbms.Data;

/* This is used if database provider does't define
 * IHospitalDbmsDbSchemaMigrator implementation.
 */
public class NullHospitalDbmsDbSchemaMigrator : IHospitalDbmsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
