using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HospitalDbms.Data;
using Volo.Abp.DependencyInjection;

namespace HospitalDbms.EntityFrameworkCore;

public class EntityFrameworkCoreHospitalDbmsDbSchemaMigrator
    : IHospitalDbmsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHospitalDbmsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HospitalDbmsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HospitalDbmsDbContext>()
            .Database
            .MigrateAsync();
    }
}
