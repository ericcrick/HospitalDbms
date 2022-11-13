using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HospitalDbms;

[Dependency(ReplaceServices = true)]
public class HospitalDbmsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HospitalDbms";
}
