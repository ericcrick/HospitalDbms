using System.Threading.Tasks;

namespace HospitalDbms.Data;

public interface IHospitalDbmsDbSchemaMigrator
{
    Task MigrateAsync();
}
